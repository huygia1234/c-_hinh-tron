using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c___hinh_tron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndt_Click(object sender, EventArgs e)
        {
            double r, p;
            r = Convert.ToDouble(txtBK.Text);
            p = Math.PI * r * r;

            txtBK.Text = p.ToString();
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            double r, p;
            r = Convert.ToDouble(txtBK.Text);
            p = Math.PI * r * 2;

            txtBK.Text = p.ToString();
        }

        private void btntinh1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtBK.Text);
            if (rdbdt1.Checked) 
            {
                double dientich=r*r*Math.PI;
                string thongbao = "-diện tích" + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(txtBK.Text);
            string thongbao = "";
            if (rdbdt1.Checked)
            {
                double dientich=r*r*Math.PI;
                thongbao = thongbao + "-diện tích" + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (rdbdt1.Checked) 
            { 
                double chuvi = r*2*Math.PI;
                thongbao = thongbao + "-Chu vi" + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (thongbao.Length > 0) 
            {
                MessageBox.Show(thongbao, "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("vui long chon tinh nang", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
