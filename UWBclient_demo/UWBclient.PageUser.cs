using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UWBclient_demo
{
    public partial class UWBclient : Form
    {
        private void btn_User_Modify_Click(object sender, EventArgs e)
        {
            if (lv_User.SelectedItems.Count > 0)
            {
                UserAdd Form_TagAdd = new UserAdd(int.Parse(lv_User.SelectedItems[0].SubItems[0].Text),this);
                Form_TagAdd.ShowDialog();
            }
        }

        private void btn_User_Delete_Click(object sender, EventArgs e)
        {
            if (lv_User.SelectedItems.Count > 0)
            {
                XmlDeal.Delete_XmlFile("Users", int.Parse(lv_User.SelectedItems[0].SubItems[0].Text));
            }
            User_Update();
        }


        public void User_Update()
        {
            lv_User.Items.Clear();
            Xml_User = null;
            Xml_User = XmlDeal.Load_XmlFile("Users");
            for (int i = 0; i < Xml_User.Length; i++)
            {

                ListViewItem item = new ListViewItem(Xml_User[i]); ;
                this.lv_User.Items.Add(item);//插入一行
                lv_User.Items[i].SubItems[3].Text = "******";
            }
        }


        private void btn_User_Add_Click(object sender, EventArgs e)
        {
            UserAdd Form_UserAdd = new UserAdd(-1,this);
            Form_UserAdd.ShowDialog();
        }

    }
}
