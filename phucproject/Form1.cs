using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace phucproject
{
    public partial class Form1 : Form
    {
        private static String connString = "server = localhost; user id = root; password = ; database = phuc_net";
        private MySqlConnection conn = new MySqlConnection(connString);
        private static String sql, sql1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_them.Enabled = true;
            bt_them2.Enabled = true;
            bt_sua1.Enabled = false;
            bt_sua2.Enabled = false;
            bt_xoa1.Enabled = false;
            bt_xacnhan1.Enabled = false;
            bt_xacnhan2.Enabled = false;
            tb_1.Enabled = false;
            tb_2.Enabled = false;
            tb_3.Enabled = false;
            cbbox.Enabled = false;
            bt_sua2.Enabled = false;
            bt_xacnhan2.Enabled = false;
            tb_3.Enabled = false;
            sql = "SELECT s.id, s.nameSanpham, s.gia, h.nameHang FROM sanpham s INNER JOIN hang h ON h.id = s.hang";
            MySqlDataAdapter a1 = new MySqlDataAdapter(sql, conn);
            DataTable t1 = new DataTable();
            a1.Fill(t1);
            listsp.DataSource = t1;
            sql1 = "SELECT * FROM hang";
            MySqlDataAdapter a2 = new MySqlDataAdapter(sql1, conn);
            DataTable t2 = new DataTable();
            a2.Fill(t2);
            list_the_loai.DataSource = t2;
            cbbox.DataSource = t2;
            //displaymember la phan hien thi cho nguoi ta xem no la cai gi no phai chua display member
            cbbox.DisplayMember = "nameHang";
            cbbox.ValueMember = "id";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            tb_1.Enabled = true;
            tb_2.Enabled = true;
            bt_xacnhan1.Enabled = true;
            cbbox.Enabled = true;
            //selecsource 
        }

        private void bt_xacnhan_1_Click(object sender, EventArgs e)
        {
            string ten = tb_1.Text;
            int gia = Int32.Parse(tb_2.Text);
            int box = (int)cbbox.SelectedValue;
            sql = "INSERT INTO sanpham(nameSanpham,gia,hang)VALUES ('"+ten+"','"+gia+"','"+box+"')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(sql,conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xac nhan thanh cong");
            Form1_Load(null,null);
        }

        private void bt_them2_Click(object sender, EventArgs e)
        {
            bt_sua2.Enabled = false;
            bt_xacnhan2.Enabled = true;
            tb_3.Enabled = true;
        }

        private void bt_xacnhan2_Click(object sender, EventArgs e)
        {
            string ten = tb_3.Text; //dat bien ten = voi gia tri cua textbox 3
            // int gia = Int32.Parse(tb_2.Text);
            // int box = (int)cbbox.SelectedValue;
            sql = "INSERT INTO hang(namehang)VALUES ('"+ten+"')";//câu lệnh sql//biến sql
            conn.Open(); // mở database
            //conn=(database)
            //open = mở database
            //command ="INSERT INTO hang(namehang)VALUES ('"+ten+"')"
            MySqlCommand command = new MySqlCommand(sql,conn);//yêu cầu trỏ tới 
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xac nhan thanh cong");
            Form1_Load(null,null);
        }

        private void list_the_loai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ids = list_the_loai.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string nameHang = list_the_loai.Rows[e.RowIndex].Cells["nameHang"].Value.ToString();
            tb_3.Text = nameHang;
            id2.Text = ids;

            bt_them2.Enabled = false;
            bt_sua2.Enabled = true;
            tb_3.Enabled = true;
        }

        private void bt_sua2_Click(object sender, EventArgs e)
        {
            string name = tb_3.Text;
            sql = "update hang set nameHang ='"+name+"' where id = '"+id2.Text+"' ";
            MySqlCommand command = new MySqlCommand(sql,conn);//yêu cầu trỏ tới 
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("sua thanh cong");
            Form1_Load(null,null);
        }

        private void listsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ids = listsp.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string nameSanpham = listsp.Rows[e.RowIndex].Cells["nameSanpham"].Value.ToString();
            string gia = listsp.Rows[e.RowIndex].Cells["gia"].Value.ToString();
            string hang = listsp.Rows[e.RowIndex].Cells["nameHang"].Value.ToString();

            bt_sua1.Enabled = true;
            tb_1.Enabled = true;
            tb_2.Enabled = true;
            bt_them.Enabled = false;
            cbbox.Enabled = true;
            bt_xoa1.Enabled = true;
            bt_xacnhan1.Enabled = true;

            id1.Text = ids;
            tb_1.Text = nameSanpham;
            tb_2.Text = gia;
            cbbox.SelectedIndex = cbbox.FindString(hang);
        }

        private void bt_sua1_Click(object sender, EventArgs e)
        {
            string id = id1.Text;
            string nameSanpham = tb_1.Text;
            int gia = Int32.Parse(tb_2.Text);
            int hang = Int32.Parse(cbbox.SelectedValue.ToString());
            sql = "update sanpham set nameSanpham ='"+nameSanpham+"' ,gia='"+gia+"',hang='"+hang+"' where id = '"+id1.Text+"' ";
            MySqlCommand command = new MySqlCommand(sql,conn);//yêu cầu trỏ tới 
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("sua thanh cong");
            Form1_Load(null,null);
            
        }

        private void bt_xoa1_Click(object sender, EventArgs e)
        {
            string id = id1.Text;
            sql = "delete from sanpham where id = '"+id+"'";
            MySqlCommand command = new MySqlCommand(sql,conn);//yêu cầu trỏ tới 
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xoa thanh cong");
            Form1_Load(null,null);
        }
    }
}