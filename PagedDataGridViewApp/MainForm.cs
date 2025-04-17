using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagedDataGridViewApp
{
    public partial class MainForm : Form
    {
        private const string ConnectionString =
            "Data Source=192.168.8.200;Initial Catalog=Firma;User ID=sa;Password=pwd1;TrustServerCertificate=True";

        private const int PageSize = 100;
        private readonly DataTable _fullData = new DataTable();
        private int _currentPage = 1;
        private CancellationTokenSource _searchCts;
        private int _totalRecords;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadFullDataAsync();
                ApplyPaging();
            }
            catch (Exception)
            {
                //
            }
        }

        private async Task RefreshDataAsync()
        {
            try
            {
                _fullData.Clear();
                Dgv_Data.DataSource = null;
                using (var conn = new SqlConnection(ConnectionString))
                {
                    var query = "SELECT * FROM Musteriler ORDER BY Id";
                    var da = new SqlDataAdapter(query, conn);
                    await Task.Run(() => da.Fill(_fullData));
                }

                ApplyPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Hata (veri çekme): " + ex.Message);
            }
        }

        private async Task LoadFullDataAsync()
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    var query = "SELECT * FROM Musteriler ORDER BY Id";
                    var da = new SqlDataAdapter(query, conn);
                    await Task.Run(() => da.Fill(_fullData));
                    _totalRecords = _fullData.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Hata (veri çekme): " + ex.Message);
            }
        }

        private void ApplySearch(string keyword)
        {
            if (_fullData == null || _fullData.Rows.Count == 0)
                return;

            try
            {
                var safeKeyword = keyword.Replace("'", "''");

                string[] columns = { "AdSoyad", "Email", "Telefon" };

                var filter = "";
                foreach (var col in columns)
                    if (_fullData.Columns.Contains(col))
                        filter += $"{col} LIKE '%{safeKeyword}%' OR ";

                if (filter.EndsWith(" OR "))
                    filter = filter.Substring(0, filter.Length - 4);

                _fullData.DefaultView.RowFilter = filter;
                Lbl_RowCount.Text = $@"Total: {_fullData.DefaultView.Count}";
                _currentPage = 1;
                ApplyPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Hata (arama): " + ex.Message);
            }
        }

        private void ApplyPaging()
        {
            try
            {
                var dv = _fullData.DefaultView;

                var totalFiltered = dv.Count;
                var maxPage = (int)Math.Ceiling((double)totalFiltered / PageSize);

                // Sayfa dışına çıkılmışsa geri getir
                if (_currentPage > maxPage)
                    _currentPage = maxPage == 0 ? 1 : maxPage;

                var skip = (_currentPage - 1) * PageSize;
                var pageTable = dv.ToTable().Clone();

                for (var i = skip; i < skip + PageSize && i < dv.Count; i++) pageTable.ImportRow(dv[i].Row);

                Dgv_Data.DataSource = pageTable;

                Lbl_PageInfo.Text = $@"Sayfa: {_currentPage} / {maxPage}";
                Lbl_RowCount.Text = $@"Toplam: {totalFiltered}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Hata (sayfalama): " + ex.Message);
            }
        }

        private async void Btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                Lbl_RowCount.Text = @"0";
                Txt_Search.Text = "";
                _currentPage = 1;
                await RefreshDataAsync();
            }
            catch (Exception)
            {
                //
            }
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            ApplyPaging();
        }

        private void Btn_Prev_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                ApplyPaging();
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (_currentPage * PageSize < _totalRecords)
            {
                _currentPage++;
                ApplyPaging();
            }
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            _currentPage = (int)Math.Ceiling((double)_fullData.DefaultView.Count / PageSize);
            ApplyPaging();
        }

        private async void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _searchCts?.Cancel();
                _searchCts = new CancellationTokenSource();
                var token = _searchCts.Token;

                try
                {
                    await Task.Delay(300, token);
                    if (!token.IsCancellationRequested)
                    {
                        _currentPage = 1;
                        ApplySearch(Txt_Search.Text);
                    }
                }
                catch (TaskCanceledException)
                {
                    //
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}