using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GiaiPhuongTrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton_PT1_CheckedChanged_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_PT1_CheckedChanged.Checked)
            {
                this.tb_c.Enabled = false;
            }
        }
        private void radioButton_PT2_CheckedChanged_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton_PT2_CheckedChanged.Checked)
            {
                this.tb_c.Enabled = true;
            }
        }
        private void bt_giaiphuongtrinh_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!radioButton_PT1_CheckedChanged.Checked && !radioButton_PT2_CheckedChanged.Checked) MessageBox.Show("Bạn hãy chọn 1 phương trình để giải!" , "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            else if(!double.TryParse(this.tb_a.Text , out a)||a==0) MessageBox.Show("a phải là số và a phải khác 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!double.TryParse(this.tb_b.Text, out b)) MessageBox.Show("b phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(radioButton_PT1_CheckedChanged.Checked)
            {
                this.tb_ketqua.Text = "Phương trình có nghiệm \t x=" + Math.Round(-b / a, 2).ToString();
            }
            else
            {
                double c;
                if (!double.TryParse(this.tb_c.Text, out c)) MessageBox.Show("c phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                double del = b * b - 4 * a * c;
                if (del == 0) this.tb_ketqua.Text = "Phương trình có ngiệm \t x1= x2=" + Math.Round(-b / 2 / a, 2).ToString();
                else if (del < 0) this.tb_ketqua.Text = "Phương trình vô nghiệm!";
                else
                {
                    double x1 = Math.Round(-b - Math.Sqrt(del) / 2 / a, 2);
                    double x2 = Math.Round(-b + Math.Sqrt(del) / 2 / a, 2);
                    this.tb_ketqua.Text = "Phương trình có \t\thai nghiệm phân biệt \t\tx1 = "+x1+" \t\t\tx2 =" + x2;
                }
            }   
        }
        private void bt_lamlai_Click(object sender, EventArgs e)
        {
            radioButton_PT1_CheckedChanged.Checked = false;
            radioButton_PT2_CheckedChanged.Checked = false;
            this.tb_a.Text = "";
            this.tb_b.Text = "";
            this.tb_c.Text = "";
            this.tb_ketqua.Text = "";
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?" , "Thông Báo" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
