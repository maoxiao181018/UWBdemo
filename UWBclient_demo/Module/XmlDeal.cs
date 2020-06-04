using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace UWBclient_demo
{
    class XmlDeal
    {

        public void CreateXmlFile_user()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("Users");
            xmlDoc.AppendChild(root);

            XmlNode node1 = xmlDoc.CreateNode(XmlNodeType.Element, "User", null);
            CreateNode(xmlDoc, node1, "name", "超管");
            CreateNode(xmlDoc, node1, "username", "root");
            CreateNode(xmlDoc, node1, "password", Encrypt.Encode("root"+"123456"));
            CreateNode(xmlDoc, node1, "description", "管理所有功能");
            CreateNode(xmlDoc, node1, "right", "Root");
            CreateNode(xmlDoc, node1, "createdate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            CreateNode(xmlDoc, node1, "modifydate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            root.AppendChild(node1);

            XmlNode node2 = xmlDoc.CreateNode(XmlNodeType.Element, "User", null);
            CreateNode(xmlDoc, node2, "name", "管理员");
            CreateNode(xmlDoc, node2, "username", "admin");
            CreateNode(xmlDoc, node2, "password", Encrypt.Encode("admin"+"123456"));
            CreateNode(xmlDoc, node2, "description", "管理除用户以外的功能");
            CreateNode(xmlDoc, node2, "right", "Administrator");
            CreateNode(xmlDoc, node2, "createdate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            CreateNode(xmlDoc, node2, "modifydate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            root.AppendChild(node2);

            XmlNode node3 = xmlDoc.CreateNode(XmlNodeType.Element, "User", null);
            CreateNode(xmlDoc, node3, "name", "客服");
            CreateNode(xmlDoc, node3, "username", "service");
            CreateNode(xmlDoc, node3, "password", Encrypt.Encode("service"+"123456"));
            CreateNode(xmlDoc, node3, "description", "负责监控");
            CreateNode(xmlDoc, node3, "right", "Guest");
            CreateNode(xmlDoc, node3, "createdate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            CreateNode(xmlDoc, node3, "modifydate", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
            root.AppendChild(node3);

            try
            {
                xmlDoc.Save(@"Information/Users.xml");
            }
            catch (Exception e)
            {
                //显示错误信息  
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();  
        }

        public static void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

        public static void CreateXmlFile(string Root, string[][] data, string[] header)
        {
            string Path = "Information/" + Root +1+ ".xml";
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode xn_root = xmlDoc.CreateElement(Root);
            xmlDoc.AppendChild(xn_root);

            for(int i=0;i< data.Length; i++)
            {
                XmlNode node1 = xmlDoc.CreateNode(XmlNodeType.Element, Root.Substring(0, Root.Length - 1), null);

                for (int j = 0; j < data[0].Length-1; j++)
                {
                    CreateNode(xmlDoc, node1, header[j], data[i][j+1]);
                }
                xn_root.AppendChild(node1);
            }

            try
            {
                xmlDoc.Save(Path);
            }
            catch (Exception e)
            {
                //显示错误信息  
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();  
        }

        public static string[][] Load_XmlFile(string Root)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            string Path = "Information/" + Root + ".xml";
            XmlReader reader = XmlReader.Create(@Path, settings);
            xmlDoc.Load(reader);
            reader.Close();



            // 得到根节点
            XmlNode xn_root = xmlDoc.SelectSingleNode(Root);

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn_root.ChildNodes;
            string[][] data = new string[xnl.Count][];

            int n = 0;
            foreach (XmlNode xn1 in xnl)
            {
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)xn1;

                // 得到属性值
                //bookModel.BookISBN = xe.GetAttribute("ISBN").ToString();
                //bookModel.BookType = xe.GetAttribute("Type").ToString();
                // 得到节点的所有子节点
                XmlNodeList xnl0 = xe.ChildNodes;
                data[n] = new string[xnl0.Count + 1];
                data[n][0] = (n + 1).ToString();
                for (int i = 0; i < xnl0.Count; i++)
                {
                    data[n][i + 1] = xnl0.Item(i).InnerText;
                }
                n++;
            }


            return data;

        }


        public static void Add_XmlFile(string Root,string[]data, string[] header)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            string Path = "Information/" + Root + ".xml";
            XmlReader reader = XmlReader.Create(@Path, settings);
            xmlDoc.Load(reader);
            reader.Close();

            // 得到根节点
            XmlNode xn_root = xmlDoc.SelectSingleNode(Root);

            // 创建一个结点,并设置结点的属性
            XmlElement xelKey = xmlDoc.CreateElement("User");
            //XmlAttribute xelType = doc.CreateAttribute("Type");
            //xelType.InnerText = "adfdsf";
            //xelKey.SetAttributeNode(xelType);

            //创建子结点:
            for (int i = 0; i < data.Length; i++)
            {
                XmlElement xelAuthor = xmlDoc.CreateElement(header[i]);
                xelAuthor.InnerText = data[i];
                xelKey.AppendChild(xelAuthor);
            }

            //最后把book结点挂接在要结点上,并保存整个文件:
            xn_root.AppendChild(xelKey);
            xmlDoc.Save(@Path);
            return;

        }

        public static void Delete_XmlFile(string Root,int line)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            string Path = "Information/" + Root + ".xml";
            XmlReader reader = XmlReader.Create(@Path, settings);
            xmlDoc.Load(reader);
            reader.Close();

            // 得到根节点
            XmlNode xn_root = xmlDoc.SelectSingleNode(Root);

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn_root.ChildNodes;
            XmlNode xn_select = xnl[line-1];
            xn_root.RemoveChild(xn_select);

            xmlDoc.Save(@Path);

            return;
        }

        public static void Modify_XmlFile(string Root, int line, string[] data, string[] header)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            string Path = "Information/" + Root + ".xml";
            XmlReader reader = XmlReader.Create(@Path, settings);
            xmlDoc.Load(reader);
            reader.Close();

            // 得到根节点
            XmlNode xn_root = xmlDoc.SelectSingleNode(Root);

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn_root.ChildNodes;
            XmlNode xn_select = xnl[line - 1];
            XmlElement xe_select = (XmlElement)xn_select;
            XmlNodeList xnl0 = xe_select.ChildNodes;

            for (int i = 0; i < xnl0.Count; i++)
            {
                xnl0.Item(i).InnerText=data[i];
            }

            xmlDoc.Save(@Path);

            return;
            
        }

        public static string[][] Modify_XmlFile(string Root)
        {
            List<UserInformation> userinformation_List = new List<UserInformation>();
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            string Path = "Information/" + Root + ".xml";
            XmlReader reader = XmlReader.Create(@Path, settings);
            xmlDoc.Load(reader);



            // 得到根节点
            XmlNode xn = xmlDoc.SelectSingleNode(Root);

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            string[][] data = new string[xnl.Count][];

            int n = 0;
            foreach (XmlNode xn1 in xnl)
            {
                UserInformation userinformation = new UserInformation();
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)xn1;

                // 得到属性值
                //bookModel.BookISBN = xe.GetAttribute("ISBN").ToString();
                //bookModel.BookType = xe.GetAttribute("Type").ToString();
                // 得到节点的所有子节点
                XmlNodeList xnl0 = xe.ChildNodes;
                data[n] = new string[xnl0.Count + 1];
                data[n][0] = (n + 1).ToString();
                for (int i = 0; i < xnl0.Count; i++)
                {
                    data[n][i + 1] = xnl0.Item(i).InnerText;
                }
                n++;
            }
            reader.Close();

            return data;

        }
        public static List<UserInformation> LoadXmlFile()
        {
            List<UserInformation> userinformation_List = new List<UserInformation>();
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create(@"Information/Users.xml", settings);
            xmlDoc.Load(reader);


            // 得到根节点
            XmlNode xn = xmlDoc.SelectSingleNode("Users");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;

            foreach (XmlNode xn1 in xnl)
            {
                UserInformation userinformation = new UserInformation();
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)xn1;
                // 得到属性值
                //bookModel.BookISBN = xe.GetAttribute("ISBN").ToString();
                //bookModel.BookType = xe.GetAttribute("Type").ToString();
                // 得到节点的所有子节点
                XmlNodeList xnl0 = xe.ChildNodes;
                userinformation.Name = xnl0.Item(0).InnerText;
                userinformation.Username = xnl0.Item(1).InnerText;
                userinformation.Password = xnl0.Item(2).InnerText;
                userinformation.Description = xnl0.Item(3).InnerText;
                userinformation.Right = xnl0.Item(4).InnerText;
                userinformation.CreateDate = xnl0.Item(5).InnerText;
                userinformation_List.Add(userinformation);
            }
            reader.Close();


            return userinformation_List;

        }

        public class UserInformation
        {
            public UserInformation()
            { }

            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string username;
            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            private string password;
            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            private string description;
            public string Description
            {
                get { return description; }
                set { description = value; }
            }

            private string right;
            public string Right
            {
                get { return right; }
                set { right = value; }
            }

            private string createdate;
            public string CreateDate
            {
                get { return createdate; }
                set { createdate = value; }
            }
        }

    }






}
