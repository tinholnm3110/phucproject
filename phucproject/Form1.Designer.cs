namespace phucproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tap = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.id1 = new System.Windows.Forms.TextBox();
            this.bt_xacnhan1 = new System.Windows.Forms.Button();
            this.bt_xoa1 = new System.Windows.Forms.Button();
            this.bt_sua1 = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bl2 = new System.Windows.Forms.Label();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.listsp = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_them2 = new System.Windows.Forms.Button();
            this.bt_sua2 = new System.Windows.Forms.Button();
            this.bt_xacnhan2 = new System.Windows.Forms.Button();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.list_the_loai = new System.Windows.Forms.DataGridView();
            this.tap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_the_loai)).BeginInit();
            this.SuspendLayout();
            // 
            // tap
            // 
            this.tap.Controls.Add(this.tabPage1);
            this.tap.Controls.Add(this.tabPage2);
            this.tap.Location = new System.Drawing.Point(4, 5);
            this.tap.Name = "tap";
            this.tap.SelectedIndex = 0;
            this.tap.Size = new System.Drawing.Size(793, 442);
            this.tap.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbbox);
            this.tabPage1.Controls.Add(this.id1);
            this.tabPage1.Controls.Add(this.bt_xacnhan1);
            this.tabPage1.Controls.Add(this.bt_xoa1);
            this.tabPage1.Controls.Add(this.bt_sua1);
            this.tabPage1.Controls.Add(this.bt_them);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bl2);
            this.tabPage1.Controls.Add(this.tb_2);
            this.tabPage1.Controls.Add(this.tb_1);
            this.tabPage1.Controls.Add(this.listsp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Giá sản phẩm";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên sản phẩm";
            // 
            // cbbox
            // 
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Location = new System.Drawing.Point(601, 222);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(111, 24);
            this.cbbox.TabIndex = 19;
            // 
            // id1
            // 
            this.id1.Enabled = false;
            this.id1.Location = new System.Drawing.Point(771, 177);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(8, 22);
            this.id1.TabIndex = 18;
            // 
            // bt_xacnhan1
            // 
            this.bt_xacnhan1.Location = new System.Drawing.Point(657, 374);
            this.bt_xacnhan1.Name = "bt_xacnhan1";
            this.bt_xacnhan1.Size = new System.Drawing.Size(111, 36);
            this.bt_xacnhan1.TabIndex = 17;
            this.bt_xacnhan1.Text = "Xác nhận";
            this.bt_xacnhan1.UseVisualStyleBackColor = true;
            this.bt_xacnhan1.Click += new System.EventHandler(this.bt_xacnhan_1_Click);
            // 
            // bt_xoa1
            // 
            this.bt_xoa1.Location = new System.Drawing.Point(473, 352);
            this.bt_xoa1.Name = "bt_xoa1";
            this.bt_xoa1.Size = new System.Drawing.Size(111, 36);
            this.bt_xoa1.TabIndex = 16;
            this.bt_xoa1.Text = "Xóa";
            this.bt_xoa1.UseVisualStyleBackColor = true;
            this.bt_xoa1.Click += new System.EventHandler(this.bt_xoa1_Click);
            // 
            // bt_sua1
            // 
            this.bt_sua1.Location = new System.Drawing.Point(312, 352);
            this.bt_sua1.Name = "bt_sua1";
            this.bt_sua1.Size = new System.Drawing.Size(111, 36);
            this.bt_sua1.TabIndex = 15;
            this.bt_sua1.Text = "Sửa";
            this.bt_sua1.UseVisualStyleBackColor = true;
            this.bt_sua1.Click += new System.EventHandler(this.bt_sua1_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(154, 352);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(111, 36);
            this.bt_them.TabIndex = 14;
            this.bt_them.Text = "Thêm SP";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 13;
            // 
            // bl2
            // 
            this.bl2.Location = new System.Drawing.Point(40, 225);
            this.bl2.Name = "bl2";
            this.bl2.Size = new System.Drawing.Size(108, 21);
            this.bl2.TabIndex = 12;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(154, 277);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(430, 22);
            this.tb_2.TabIndex = 11;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(154, 222);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(430, 22);
            this.tb_1.TabIndex = 10;
            // 
            // listsp
            // 
            this.listsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listsp.Location = new System.Drawing.Point(4, -7);
            this.listsp.Name = "listsp";
            this.listsp.RowTemplate.Height = 24;
            this.listsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listsp.Size = new System.Drawing.Size(776, 206);
            this.listsp.TabIndex = 9;
            this.listsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listsp_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.id2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bt_them2);
            this.tabPage2.Controls.Add(this.bt_sua2);
            this.tabPage2.Controls.Add(this.bt_xacnhan2);
            this.tabPage2.Controls.Add(this.tb_3);
            this.tabPage2.Controls.Add(this.list_the_loai);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh muc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên hãng";
            // 
            // id2
            // 
            this.id2.Enabled = false;
            this.id2.Location = new System.Drawing.Point(776, 214);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(8, 22);
            this.id2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 6;
            // 
            // bt_them2
            // 
            this.bt_them2.Location = new System.Drawing.Point(367, 331);
            this.bt_them2.Name = "bt_them2";
            this.bt_them2.Size = new System.Drawing.Size(109, 40);
            this.bt_them2.TabIndex = 5;
            this.bt_them2.Text = "Thêm";
            this.bt_them2.UseVisualStyleBackColor = true;
            this.bt_them2.Click += new System.EventHandler(this.bt_them2_Click);
            // 
            // bt_sua2
            // 
            this.bt_sua2.Location = new System.Drawing.Point(30, 331);
            this.bt_sua2.Name = "bt_sua2";
            this.bt_sua2.Size = new System.Drawing.Size(109, 40);
            this.bt_sua2.TabIndex = 4;
            this.bt_sua2.Text = "Sửa";
            this.bt_sua2.UseVisualStyleBackColor = true;
            this.bt_sua2.Click += new System.EventHandler(this.bt_sua2_Click);
            // 
            // bt_xacnhan2
            // 
            this.bt_xacnhan2.Location = new System.Drawing.Point(658, 364);
            this.bt_xacnhan2.Name = "bt_xacnhan2";
            this.bt_xacnhan2.Size = new System.Drawing.Size(109, 43);
            this.bt_xacnhan2.TabIndex = 3;
            this.bt_xacnhan2.Text = "Xác nhận";
            this.bt_xacnhan2.UseVisualStyleBackColor = true;
            this.bt_xacnhan2.Click += new System.EventHandler(this.bt_xacnhan2_Click);
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(145, 249);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(331, 22);
            this.tb_3.TabIndex = 1;
            // 
            // list_the_loai
            // 
            this.list_the_loai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_the_loai.Location = new System.Drawing.Point(4, 2);
            this.list_the_loai.Name = "list_the_loai";
            this.list_the_loai.RowTemplate.Height = 24;
            this.list_the_loai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_the_loai.Size = new System.Drawing.Size(780, 234);
            this.list_the_loai.TabIndex = 0;
            this.list_the_loai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_the_loai_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tap);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tap.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listsp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_the_loai)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox cbbox;

        private System.Windows.Forms.TextBox id1;

        private System.Windows.Forms.Button bt_them;

        private System.Windows.Forms.Button bt_xoa1;

        private System.Windows.Forms.Button bt_sua1;

        private System.Windows.Forms.Button bt_xacnhan1;

        private System.Windows.Forms.Button bt_sua2;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Button bt_xacnhan2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button bt_them2;

        private System.Windows.Forms.DataGridView list_the_loai;

        private System.Windows.Forms.TabControl tap;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bl2;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.DataGridView listsp;

        #endregion
    }
}