namespace PagedDataGridViewApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Label Lbl_PageInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Lbl_PageInfo = new System.Windows.Forms.Label();
            this.Tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Tlp_Bottom_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_First = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Lbl_RowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.Tlp_Main.SuspendLayout();
            this.Tlp_Bottom_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AllowUserToAddRows = false;
            this.Dgv_Data.AllowUserToDeleteRows = false;
            this.Dgv_Data.AllowUserToOrderColumns = true;
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Data.Location = new System.Drawing.Point(8, 128);
            this.Dgv_Data.MultiSelect = false;
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Data.Size = new System.Drawing.Size(608, 215);
            this.Dgv_Data.TabIndex = 0;
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(8, 48);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(300, 20);
            this.Txt_Search.TabIndex = 1;
            this.Txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.Location = new System.Drawing.Point(78, 3);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(69, 23);
            this.Btn_Prev.TabIndex = 2;
            this.Btn_Prev.Text = "Önceki";
            this.Btn_Prev.UseVisualStyleBackColor = true;
            this.Btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(153, 3);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(69, 23);
            this.Btn_Next.TabIndex = 3;
            this.Btn_Next.Text = "Sonraki";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Lbl_PageInfo
            // 
            this.Lbl_PageInfo.AutoSize = true;
            this.Lbl_PageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_PageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_PageInfo.Location = new System.Drawing.Point(8, 396);
            this.Lbl_PageInfo.Name = "Lbl_PageInfo";
            this.Lbl_PageInfo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Lbl_PageInfo.Size = new System.Drawing.Size(608, 40);
            this.Lbl_PageInfo.TabIndex = 4;
            this.Lbl_PageInfo.Text = "-";
            // 
            // Tlp_Main
            // 
            this.Tlp_Main.ColumnCount = 1;
            this.Tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Main.Controls.Add(this.Txt_Search, 0, 1);
            this.Tlp_Main.Controls.Add(this.Lbl_PageInfo, 0, 5);
            this.Tlp_Main.Controls.Add(this.Dgv_Data, 0, 3);
            this.Tlp_Main.Controls.Add(this.Tlp_Bottom_Main, 0, 4);
            this.Tlp_Main.Controls.Add(this.Btn_Refresh, 0, 0);
            this.Tlp_Main.Controls.Add(this.Lbl_RowCount, 0, 2);
            this.Tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.Tlp_Main.Name = "Tlp_Main";
            this.Tlp_Main.Padding = new System.Windows.Forms.Padding(5);
            this.Tlp_Main.RowCount = 6;
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tlp_Main.Size = new System.Drawing.Size(624, 441);
            this.Tlp_Main.TabIndex = 5;
            // 
            // Tlp_Bottom_Main
            // 
            this.Tlp_Bottom_Main.ColumnCount = 5;
            this.Tlp_Bottom_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Bottom_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Bottom_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Bottom_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.Tlp_Bottom_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Bottom_Main.Controls.Add(this.Btn_Prev, 1, 0);
            this.Tlp_Bottom_Main.Controls.Add(this.Btn_Next, 2, 0);
            this.Tlp_Bottom_Main.Controls.Add(this.Btn_First, 0, 0);
            this.Tlp_Bottom_Main.Controls.Add(this.Btn_Last, 3, 0);
            this.Tlp_Bottom_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tlp_Bottom_Main.Location = new System.Drawing.Point(8, 349);
            this.Tlp_Bottom_Main.Name = "Tlp_Bottom_Main";
            this.Tlp_Bottom_Main.RowCount = 1;
            this.Tlp_Bottom_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tlp_Bottom_Main.Size = new System.Drawing.Size(608, 44);
            this.Tlp_Bottom_Main.TabIndex = 2;
            // 
            // Btn_First
            // 
            this.Btn_First.Location = new System.Drawing.Point(3, 3);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(69, 23);
            this.Btn_First.TabIndex = 4;
            this.Btn_First.Text = "<< İlk";
            this.Btn_First.UseVisualStyleBackColor = true;
            this.Btn_First.Click += new System.EventHandler(this.Btn_First_Click);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Location = new System.Drawing.Point(228, 3);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(69, 23);
            this.Btn_Last.TabIndex = 5;
            this.Btn_Last.Text = "Son >>";
            this.Btn_Last.UseVisualStyleBackColor = true;
            this.Btn_Last.Click += new System.EventHandler(this.Btn_Last_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Location = new System.Drawing.Point(8, 8);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.Btn_Refresh.TabIndex = 5;
            this.Btn_Refresh.Text = "Yenile";
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Lbl_RowCount
            // 
            this.Lbl_RowCount.AutoSize = true;
            this.Lbl_RowCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_RowCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_RowCount.Location = new System.Drawing.Point(8, 85);
            this.Lbl_RowCount.Name = "Lbl_RowCount";
            this.Lbl_RowCount.Padding = new System.Windows.Forms.Padding(5);
            this.Lbl_RowCount.Size = new System.Drawing.Size(608, 40);
            this.Lbl_RowCount.TabIndex = 6;
            this.Lbl_RowCount.Text = "0";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagedDataGridViewApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.Tlp_Main.ResumeLayout(false);
            this.Tlp_Main.PerformLayout();
            this.Tlp_Bottom_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel Tlp_Main;
        private System.Windows.Forms.TableLayoutPanel Tlp_Bottom_Main;
        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label Lbl_RowCount;
    }
}