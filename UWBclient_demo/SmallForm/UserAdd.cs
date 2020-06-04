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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }
        private UWBclient uWBclient;
        private int line2 = -1;

        public UserAdd(int line)
        {
            InitializeComponent();
            if (line != -1)
            {
                this.Text = "UserModify";
            }
            line2 = line;
        }




        //添加一个构造函数
        public UserAdd(int line, UWBclient uWBclient) : this(line)
        {
            this.uWBclient = uWBclient;
        }


        private void UserAdd_Load(object sender, EventArgs e)
        {
            if (line2 != -1)
            {
                int count = 0;
                foreach (Control c in this.Controls)
                {

                    //判断控件是不是TextBox
                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text=UWBclient.Xml_User[line2-1][count+1] ;
                        count++;
                    }
                }
                UA_tb_password.Text = Encrypt.Decode(UA_tb_password.Text);
                UA_tb_password.Text = UA_tb_password.Text.Substring(UA_tb_username.Text.Length);
            }

        }
        private void btn_UserAdd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void UA_btn_Save_Click(object sender, EventArgs e)
        {
            string[] data = new string[7];
            int count = 0;
            foreach (Control c in this.Controls)
            {

                //判断控件是不是TextBox
                if (c is TextBox || c is ComboBox)
                {
                    //如果是，检查其内容是否为空
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        //将内容为空的TextBox存放到list中
                        MessageBox.Show("数据不能为空");
                        return;
                    }
                    else
                    {
                        //内容不zhi为空的处理dao
                        data[count] = c.Text;
                        count++;
                    }
                }
            }
            data[2] = Encrypt.Encode(data[1] + data[2]);
            data[data.Length - 1] = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");


                if (line2 != -1)
                {
                data[data.Length - 2] = UWBclient.Xml_User[line2 - 1][UWBclient.Xml_User[0].Length - 2];
                XmlDeal.Modify_XmlFile("Users", line2,data, UWBclient.User_header);
                }
            else
                {
                data[data.Length - 2] = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                XmlDeal.Add_XmlFile("Users", data, UWBclient.User_header);
                }
                
                uWBclient.User_Update();
     
            this.Close();
        }
    }
}
