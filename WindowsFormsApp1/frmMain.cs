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
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmNhanVien chill = new frmNhanVien();
            chill.ShowDialog();

            if(!string.IsNullOrEmpty(chill.Id) && !string.IsNullOrEmpty(this.Name))
            {
                ListViewItem lvi = new ListViewItem(chill.Id);
                lvi.SubItems.Add(chill.Name1);
                lvi.SubItems.Add(chill.LuongCb.ToString());
                listView1.Items.Add(lvi);
            }    
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNhanVien chill = new frmNhanVien();
            ListViewItem lvi;

            if (listView1.SelectedIndices.Count > 0)
            {
                lvi = listView1.SelectedItems[0];

                chill.Id = lvi.SubItems[0].Text;
                chill.Name1 = lvi.SubItems[1].Text;
                chill.LuongCb = int.Parse(lvi.SubItems[2].Text);
                chill.ShowDialog();
                if (!string.IsNullOrEmpty(chill.Id) && !string.IsNullOrEmpty(this.Name))
                {
                    lvi.SubItems[0].Text = chill.Id;
                    lvi.SubItems[1].Text = chill.Name1;
                    lvi.SubItems[2].Text = chill.LuongCb.ToString();

                }
            }


        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                listView1.Items.RemoveAt(lvi.Index);
            }
        }
    }
}
