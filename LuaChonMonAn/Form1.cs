using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuaChonMonAn
{
    public partial class ThucDon : Form
    {
        public ThucDon()
        {
            InitializeComponent();
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTNChoices_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0; i<List_Thucdon.Items.Count; i++)
            {
                if(textChoices.Text == List_Thucdon.Items[i].ToString())
                {
                    break;
                }
            }
            if (i == List_Thucdon.Items.Count)
            {
                List_Thucdon.Items.Add(textChoices.Text);
            }
            else MessageBox.Show("Món ăn đã có trong thực đơn!");
            textChoices.Clear();
        }

        private void textChoices_TextChanged(object sender, EventArgs e)
        {
            if(textChoices.Text.Length > 0) BTNChoices.Enabled = true;
        }
        //di chuyen mon an tu list A sang List B
        //test pull
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0; i<List_Chon.Items.Count; i++) { 
                if(List_Thucdon.SelectedItem == List_Chon.Items[i])
                {
                    break;
                }
            }
            if(List_Chon.Items.Count == i)
            {
                List_Chon.Items.Add(List_Thucdon.SelectedItem);
            } else
            {
                MessageBox.Show("Món ăn đã được chọn!");
            }
            
            
        }

        private void BTNAddAll_Click(object sender, EventArgs e)
        {
            List_Chon.Items.Clear();
            List_Chon.Items.AddRange(List_Thucdon.Items);
        }

        private void BTNSub_Click(object sender, EventArgs e)
        {
            List_Chon.Items.Remove(List_Chon.SelectedItem);
        }

        private void BTNSubAll_Click(object sender, EventArgs e)
        {
            List_Chon.Items.Clear();
        }

        private void textChoices_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Nhập sai rồi!");
                }
                else e.Handled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
