using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmNhanVien : Form
    {
        private string id;
        private string name;
        private int luongCb;

        public string Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public int LuongCb { get => luongCb; set => luongCb = value; }

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            txtMsnv.Text = this.id;
            txtHoTen.Text = this.name;
            if(this.luongCb == 0)
            {
                txtLuongCB.Text = string.Empty;
            }
            else
            {
                txtLuongCB.Text = this.luongCb.ToString();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.id = "";
            this.name = "";
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.id = txtMsnv.Text;
            this.Name1 = txtHoTen.Text;
            if (int.TryParse(txtLuongCB.Text, out this.luongCb))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lương CB không hợp lệ", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
