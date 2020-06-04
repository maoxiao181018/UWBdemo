using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using SuperSocket.ProtoBase;
using WebSocket4Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Xml;

namespace UWBclient_demo
{
    public delegate void CbDelegate();//定义委托
    public delegate void CbDelegate<T1>(T1 obj1);
    public delegate void CbDelegate<T1, T2>(T1 obj1, T2 obj2);
    public delegate void CbDelegate2<T1, T2>(T1 obj1, T2 obj2);
    public partial class UWBclient : Form
    {
        #region Websocket_para //—————————————————WebSocket部分参数—————————————————————
        private WebSocket client = null;//WebSocket连接
        private System.Threading.Timer tmrHeartBeat = null;// 心跳检查定时器
        private System.Threading.Timer tmrReConnection = null;// 断线重连定时器
        private int mHeartBeatInterval = 1000 * 10;
        private int mReConnectionInterval = 1000 * 10;
        #endregion

        #region map_para //—————————————————————MAP所用参数—————————————————————
        public Region rion1 = new Region(new Rectangle(0, 0, 5, 5));
        public Region rion2 = new Region(new Rectangle(0, 0, 5, 5));
        public int x_ld = 18, y_ld = 326, x_ru = 283, y_ru = 11;
        public double Xmax = 7.23, Ymax = 8.60;
        public string TagID1 = "1296", TagID2 = "1241";
        public string port_map = "9000";
        #endregion

        #region Camera_para //———————————————————Camera部分参数—————————————————————
        private uint iLastErr = 0;//错误号
        private Int32 m_lUserID = -1;//登录接口的返回值
        private bool m_bInitSDK = false;//初始化的返回值
        private bool m_TimeSDK = false;//连接时间设置的返回值
        private bool m_CallbackSDK = false;//注册异常回调的返回值
        private bool m_bRecord = false;//判断是否录像
        private Int32 m_lRealHandle = -1;//预览句柄，NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值
        private string str = "";//错误文字

        private bool bRet = false;
        private int heart = 0;

        private System.Threading.Timer Camera_HeartBeat = null;// 心跳检查定时器
        private int CHeartBeatInterval = 1000 * 10;

        CHCNetSDK.REALDATACALLBACK RealData = null;//预览实时流回调
        CHCNetSDK.LOGINRESULTCALLBACK LoginCallBack = null;//注册回调


        public CHCNetSDK.NET_DVR_PTZPOS m_struPtzCfg;//PTZ坐标结构体
        public CHCNetSDK.NET_DVR_FOCUSMODE_CFG m_struFocusmode;//聚焦结构体
        public CHCNetSDK.NET_DVR_CAMERAPARAMCFG m_struCameraPa;//前端参数结构体

        public CHCNetSDK.NET_DVR_USER_LOGIN_INFO struLogInfo;//用户登录参数结构体
        public CHCNetSDK.NET_DVR_DEVICEINFO_V40 DeviceInfoV40;//设备参数结构体

        public delegate void UpdateTextStatusCallback(string strLogStatus, IntPtr lpDeviceInfo);

        public string[] Errors;
        public int[,] XYZ = new int[9, 3] { { 1, 0, 0 }, { 50, 0, 0 }, { 150, 0, 0 }, { 250, 0, 0 },{ 350, 0 , 0},{ 450, 0 , 0},
                                             { 550, 0 , 0},{ 650, 0 , 0},{ 700, 0 , 0}};
        //

        public int m_lChannel = 1;//通道号 
        public int PreSetNo = 0;//预置点号
        public CHCNetSDK.NET_DVR_PTZSCOPE m_struPtzCfg1;//PTZ限值
        public CHCNetSDK.NET_DVR_PRESET_NAME[] m_struPreSetCfg = new CHCNetSDK.NET_DVR_PRESET_NAME[300];//预置点名称
        #endregion

        #region Xml_para //———————————————————Xml部分参数—————————————————————
        public static string[] User_header = { "name","username","password","description","right","createdate","modifydate" };
        public static string[] Tag_header = { "number", "name", "type", "battery", "show","picture","track"};
        public static string[][] Xml_User = null;
        #endregion
        public UWBclient()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
            //在多线程程序中，新创建的线程不能访问UI线程创建的窗口控件，
            //如果需要访问窗口中的控件，可以在窗口构造函数中将CheckForIllegalCrossThreadCalls设置为 false

            //——————————————————————————Websocket—————————————————————————————
            tmrHeartBeat = new System.Threading.Timer(HeartBeatCallBack, null, mHeartBeatInterval, mHeartBeatInterval);
            tmrReConnection = new System.Threading.Timer(ReConnectionCallBack, null, mReConnectionInterval, mReConnectionInterval);
            //在超过 dueTime 以后及此后每隔 period 时间间隔，都会调用一次 callback 参数所指定的委托。

            //——————————————————————————Camera—————————————————————————————

            Camera_HeartBeat = new System.Threading.Timer(Camera_HeartBeatCallBack, null, Timeout.Infinite, Timeout.Infinite);

            m_bInitSDK = CHCNetSDK.NET_DVR_Init();//初始化
            if (m_bInitSDK == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            else
            {
                //保存SDK日志 To save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }

        }

        private void UWBclient_Load(object sender, EventArgs e)
        {
            //—————————————————————————map—————————————————————————————
            picture_int();
            picture_load("grid1", "map1", "tag1", "tag3");//需要移动

            //—————————————————————————Camera—————————————————————————————
            comboBoxSpeed.SelectedIndex = 3;
            comboBoxAction.SelectedIndex = 0;
            checkBoxPreview.Checked = false;
            LoadErrors();


            m_TimeSDK = CHCNetSDK.NET_DVR_SetConnectTime(2000, 3);//设置网络连接超时时间和连接尝试次数
            if (m_TimeSDK == false)
            {
                MessageBox.Show("设置连接时间失败");
                //return;
            }
            CHCNetSDK.NET_DVR_SetRecvTimeOut(2000);//预览接收实时流数据、回放下载接收录像数据、报警接收报警信息等接收超时时间
            CHCNetSDK.NET_DVR_SetReconnect(5000, 1);//预览、透明通道和布防的重连时间

            m_CallbackSDK = CHCNetSDK.NET_DVR_SetExceptionCallBack_V30(0, IntPtr.Zero, g_ExceptionCallBack, IntPtr.Zero);
            if (m_CallbackSDK == false)
            {
                MessageBox.Show("设置异常回调函数失败");
                //return;
            }

            //—————————————————————————Xml—————————————————————————————
            User_Update();
        }

        private void picture_int()
        {
            pb_Map_Grid.Controls.Add(pb_Map_Map);
            pb_History_Grid.Controls.Add(pb_History_Map);

            rion1 = Pictureload.GetRegion(Properties.Resources.region2);//切取水滴图形
            rion2 = Pictureload.GetRegion(Properties.Resources.region2);//切取水滴图形

            pb_Map_Tag1.Region = rion2;
            pb_Map_Tag2.Region = rion2;
            pb_Map_Map.Controls.Add(pb_Map_Tag1);
            pb_Map_Tag1.Location = new Point(-50, -100);
            pb_Map_Map.Controls.Add(pb_Map_Tag2);
            pb_Map_Tag2.Location = new Point(-100, -50);

            pb_Monitor_Tag1.Region = rion1;
            pb_Monitor_Tag2.Region = rion1;
            pb_Monitor_Map.Controls.Add(pb_Monitor_Tag1);
            pb_Monitor_Tag1.Location = new Point(-20, -20);
            pb_Monitor_Map.Controls.Add(pb_Monitor_Tag2);
            pb_Monitor_Tag2.Location = new Point(-20, -20);

            pb_History_Tag1.Region = rion2;
            pb_History_Tag2.Region = rion2;
            pb_History_Map.Controls.Add(pb_History_Tag1);
            pb_History_Tag1.Location = new Point(-20, -20);
            pb_History_Map.Controls.Add(pb_History_Tag2);
            pb_History_Tag2.Location = new Point(-20, -20);
        }
        private void picture_load(string grid, string map, string tag1, string tag2)
        {
            //Map
            pb_Map_Grid.Image = Pictureload.GetResourceImage("grid1");//不需要带后缀名
            pb_Map_Grid.SizeMode = PictureBoxSizeMode.Zoom;

            pb_Map_Map.Image = Pictureload.GetResourceImage("map1");
            pb_Map_Map.SizeMode = PictureBoxSizeMode.Zoom;

            pb_Map_Tag1.Image = Pictureload.GetResourceImage("tag1");
            pb_Map_Tag1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Map_Tag2.Image = Pictureload.GetResourceImage("tag3");
            pb_Map_Tag2.SizeMode = PictureBoxSizeMode.Zoom;


            //Monitor
            pb_Monitor_Map.Image = Pictureload.GetResourceImage("map1");
            pb_Monitor_Map.SizeMode = PictureBoxSizeMode.Zoom;

            pb_Monitor_Tag1.Image = Pictureload.GetResourceImage("tag1");
            pb_Monitor_Tag1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Monitor_Tag2.Image = Pictureload.GetResourceImage("tag3");
            pb_Monitor_Tag2.SizeMode = PictureBoxSizeMode.Zoom;

            //History
            pb_History_Grid.Image = Pictureload.GetResourceImage("grid1");//不需要带后缀名
            pb_History_Grid.SizeMode = PictureBoxSizeMode.Zoom;

            pb_History_Map.Image = Pictureload.GetResourceImage("map1");
            pb_History_Map.SizeMode = PictureBoxSizeMode.Zoom;

            pb_History_Tag1.Image = Pictureload.GetResourceImage("tag1");
            pb_History_Tag1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_History_Tag2.Image = Pictureload.GetResourceImage("tag3");
            pb_History_Tag2.SizeMode = PictureBoxSizeMode.Zoom;
        }



        private void btn_LinkConnect_Click(object sender, EventArgs e)
        {

            //webBrowser1.Navigate("http://www.baidu.com");
            try
            {
                string wsUrl = string.Format("ws://{0}:{1}", this.tb_ServerIP.Text, port_map);
                //初始化并启动客户端引擎（TCP、文本协议）
                client = new WebSocket(uri: wsUrl)
                {
                    ReceiveBufferSize = 65535,//接收缓存区
                    EnableAutoSendPing = true,//自动ping，防止切断空闲连接
                    AutoSendPingInterval = 1000,
                };
                client.Opened += client_Opened;
                client.MessageReceived += client_MessageReceived;
                client.DataReceived += client_DataReceived;
                client.Closed += client_Closed;
                client.Error += client_Error;
                client.Open();
                if (client.State == WebSocketState.Connecting)
                {
                    this.BeginInvoke(new CbDelegate(() =>
                    {
                        this.btnSend.Enabled = true;
                        this.btn_LinkConnect.Enabled = false;
                        this.btn_LinkDisconnect.Enabled = true;
                        ShowMessage("连接中...", "System");
                    }));
                }
                else
                {
                    ShowMessage("连接失败！", "Error");
                }
            }
            catch (Exception ex)
            {
                ShowMessage(string.Format("连接服务器失败:{0}", ex.Message), "Error");
            }
        }

        private void btn_LinkDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    client.Close();
                    client.Dispose();
                    client = null;
                }
                ShowMessage("连接断开！", "System");
                this.btn_LinkConnect.Enabled = true;
                this.btnSend.Enabled = false;
                this.btn_LinkDisconnect.Enabled = false;//???
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "Error");
            }
        }





        #region Websocket_fun
        void client_Opened(object sender, EventArgs e)
        {
            ShowMessage("连接成功！", "System");
        }

        void client_Closed(object sender, EventArgs e)
        {
            this.BeginInvoke(new CbDelegate(() =>
            {
                this.btnSend.Enabled = false;
                this.btn_LinkConnect.Enabled = true;
                ShowMessage("您已经掉线！", "System");
                //this.btnClose_Click(null, null);//???
            }));
        }

        void client_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            if (e.Exception.GetType() == typeof(System.Net.Sockets.SocketException))
            {
                var socketExceptin = e.Exception as System.Net.Sockets.SocketException;
                if (socketExceptin.SocketErrorCode == SocketError.ConnectionRefused)
                {
                    ShowMessage("请先启动AppServer 服务端！", "Error");
                }
                else
                    ShowMessage(e.Exception.Message, "Error");
            }
            else
                ShowMessage(e.Exception.Message, "Error");
        }

        void client_DataReceived(object sender, DataReceivedEventArgs e)
        {
            string message = Encoding.UTF8.GetString(e.Data);
            string key = string.Empty;
            string body = string.Empty;
            key = Regex.Split(message, "\u0020")[0];
            body = string.Join("", message.ToArray().Skip(key.ToArray().Length + 1).ToList()); ;
            switch (key)
            {
                case "echo":
                    this.ShowMessage(body, key);
                    break;
                case "heartbeat":
                    this.ShowMessage(body, key);
                    break;
                case "push":
                    this.ShowMessage(body, key);
                    break;
                default:
                    this.ShowMessage("未知的指令（error unknow command）", "Unknown");
                    break;
            }
        }

        void client_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            string message = e.Message;
            JArray JA_message = (JArray)JsonConvert.DeserializeObject(message);

            string key = JA_message[0]["type"].ToString();
            string[] body = Regex.Split(message, "},{", RegexOptions.IgnoreCase);

            int cut = 10 + key.Length;//去除头尾
            body[0] = body[0].Substring(2, body[0].Length - 2);
            body[JA_message.Count - 1] = body[JA_message.Count - 1].Substring(0, body[JA_message.Count - 1].Length - 2);
            for (int i = 0; i < JA_message.Count; i++)
            {
                body[i] = body[i].Substring(cut, body[i].Length - cut);
            }

            switch (key)
            {
                case "station":
                    this.ShowMessage(body, key);
                    break;
                case "distance":
                    this.ShowMessage(body, key);
                    break;
                case "tag":
                    this.ShowMessage(body, key);

                    for (int i = 0; i < JA_message.Count; i++)
                    {
                        if (JA_message[i]["type"].ToString() == "tag")//
                        {
                            if (JA_message[i]["id"].ToString() == TagID1)

                            {
                                IDbox_Tag1.Text = JA_message[i]["id"].ToString();
                                Xbox_Tag1.Text = JA_message[i]["x"].ToString();
                                Ybox_Tag1.Text = JA_message[i]["y"].ToString();
                                Zbox_Tag1.Text = JA_message[i]["z"].ToString();
                                string[] XY1 = { JA_message[i]["x"].ToString(), JA_message[i]["y"].ToString() }; //xy为窗口坐标 XY为实际坐标
                                int[] xy1 = DataHelper.XYtoxy(XY1, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                                TagPicture1.Left = xy1[0] - TagPicture1.Width / 2;
                                TagPicture1.Top = xy1[1] - TagPicture1.Height;
                            }

                            if (JA_message[i]["id"].ToString() == TagID2)

                            {
                                IDbox_Tag2.Text = JA_message[i]["id"].ToString();
                                Xbox_Tag2.Text = JA_message[i]["x"].ToString();
                                Ybox_Tag2.Text = JA_message[i]["y"].ToString();
                                Zbox_Tag2.Text = JA_message[i]["z"].ToString();
                                string[] XY2 = { JA_message[i]["x"].ToString(), JA_message[i]["y"].ToString() };
                                int[] xy2 = DataHelper.XYtoxy(XY2, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                                TagPicture2.Left = xy2[0] - TagPicture1.Width / 2;
                                TagPicture2.Top = xy2[1] - TagPicture2.Height;
                            }


                        }
                    }

                    break;
                /*string[] TagXYZ = new string[JA_message.Count * 4];
                for (int i = 0; i < JA_message.Count; i++)
                {
                    if (JA_message[i]["type"].ToString() != key)//数据混杂
                    {
                        return;
                    }

                    if

                    TagXYZ[4 * i] = JA_message[i]["id"].ToString();
                    TagXYZ[4 * i + 1] = JA_message[i]["x"].ToString();
                    TagXYZ[4 * i + 2] = JA_message[i]["y"].ToString();
                    TagXYZ[4 * i + 3] = JA_message[i]["z"].ToString();
                }
                int j = 0;
                foreach (TextBox item in panel_tag.Controls)
                {
                    if (j >= TagXYZ.Length)
                    {
                        break;
                    }
                    item.Text = TagXYZ[j];
                    j++;
                }

                MoveTag(Xbox_Tag1.Text, Ybox_Tag1.Text, IDbox_Tag1.Text);
                MoveTag(Xbox_Tag2.Text, Ybox_Tag2.Text, IDbox_Tag2.Text);*/

                default:
                    this.ShowMessage(body, "unknown");
                    break;
            }

        }

        private void ShowMessage(string msg, string key)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate<string, string>(this.ShowMessage), msg, key);//来自其他线程的异步？？？
            }
            else
            {
                ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), key, msg });
                this.lsvReceviedMsg.Items.Insert(0, item);//插入一行
            }
        }

        private void ShowMessage(string[] msg, string key)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbDelegate2<string[], string>(this.ShowMessage), msg, key);//来自其他线程的异步？？？
            }
            else
            {

                for (int i = 0; i < msg.Length; i++)
                {
                    if (i == msg.Length - 1)
                    {
                        ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss fff"), key, msg[i] });
                        this.lsvReceviedMsg.Items.Insert(0, item);//插入一行
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(new string[] { "", "", msg[i] });
                        this.lsvReceviedMsg.Items.Insert(0, item);//插入一行
                    }

                }

            }
        }


        private void HeartBeatCallBack(object state)//心跳包
        {
            try
            {
                tmrHeartBeat.Change(Timeout.Infinite, Timeout.Infinite);//停止timer

                if (client != null && client.State == WebSocketState.Open)
                {
                    var sbMessage = new StringBuilder();//可变字符串对象
                    //sbMessage.AppendFormat(string.Format("heartbeat #{0}#\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffffff")));
                    sbMessage.AppendFormat(string.Format("heartbeat #{0}#\r\n", "心跳数据包:ok"));
                    var data = Encoding.UTF8.GetBytes(sbMessage.ToString());
                    client.Send(data, 0, data.Length);//传输心跳包
                }
            }
            finally
            {
                tmrHeartBeat.Change(mHeartBeatInterval, mHeartBeatInterval);//启动timer
            }
        }

        private void ReConnectionCallBack(object state)//重连
        {
            try
            {
                tmrReConnection.Change(Timeout.Infinite, Timeout.Infinite);
                if (client != null &&
                    client.State == WebSocketState.Closed)
                {
                    btn_LinkConnect_Click(null, null);//点击连接
                }
            }
            finally
            {
                tmrReConnection.Change(mHeartBeatInterval, mHeartBeatInterval);
            }
        }

        #endregion




        private void MoveTag(string Xloc, string Yloc, string TagID)
        {
            if (TagID == TagID1)

            {
                string[] XY1 = { Xloc, Yloc };
                int[] xy1 = DataHelper.XYtoxy(XY1, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                TagPicture1.Left = xy1[0] - TagPicture1.Width / 2;
                TagPicture1.Top = xy1[1] - TagPicture1.Height;
            }

            if (TagID == TagID2)

            {
                string[] XY2 = { Xloc, Yloc };
                int[] xy2 = DataHelper.XYtoxy(XY2, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                TagPicture2.Left = xy2[0] - TagPicture1.Width / 2;
                TagPicture2.Top = xy2[1] - TagPicture2.Height;
            }

        }

        private void mapbox_Click(object sender, EventArgs e)
        {
            int x = mapbox.PointToClient(Control.MousePosition).X;
            int y = mapbox.PointToClient(Control.MousePosition).Y;

            xbox_local.Text = x.ToString();
            ybox_local.Text = y.ToString();

            double[] XY = DataHelper.xytoXY(x, y, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
            Xbox_mouse.Text = XY[0].ToString("#0.00");//点后面几个0就保留几位
            Ybox_mouse.Text = XY[1].ToString("#0.00");

            string[] XY2 = { Xbox_mouse.Text, Ybox_mouse.Text };
            int[] xy = DataHelper.XYtoxy(XY2, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client != null && client.State == WebSocketState.Open)
            {
                var sbMessage = new StringBuilder();
                sbMessage.AppendFormat(string.Format("echo {0}", this.textBox_msg.Text + Environment.NewLine));
                var data = Encoding.UTF8.GetBytes(sbMessage.ToString());
                client.Send(data, 0, data.Length);
                //EchoAsync(client, this.textBox_msg.Text);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Encrypt.Encode(tb_Username.Text+tb_Password.Text);
        }


        private void btn_SZ_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("将该点设为零点?", "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                x_ld = int.Parse(xbox_local.Text);
                y_ld = int.Parse(ybox_local.Text);

            }
        }


        private void btn_SM_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("将该点设为最大点?", "对话框标题", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string inputBox = Interaction.InputBox("请输入XY的最大值,用\",\"间隔开", "XmaxYmax输入框", "0,0", -1, -1);
                string[] XYmax = inputBox.Split(',');

                if (inputBox == "")
                {
                    return;
                }
                else if (XYmax.Length == 2 && Regex.IsMatch(XYmax[0], "-[0-9]+(.[0-9]+)?|[0-9]+(.[0-9]+)?") && Regex.IsMatch(XYmax[1], "-[0-9]+(.[0-9]+)?|[0-9]+(.[0-9]+)?") && XYmax[0] != "0" && XYmax[1] != "0")
                {
                    MessageBox.Show("输入成功", "Success", MessageBoxButtons.OK);
                    x_ru = int.Parse(xbox_local.Text);
                    y_ru = int.Parse(ybox_local.Text);

                }
                else
                {
                    MessageBox.Show("输入错误", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string message = "[{\"type\":\"station\",\"id\":206,\"status\":1,\"ip\":\"\",\"x\":0,\"y\":0,\"z\":0},{\"type\":\"station\",\"id\":211,\"status\":1,\"ip\":\"\",\"x\":0,\"y\":0,\"z\":0},{\"type\":\"station\",\"id\":220,\"status\":1,\"ip\":\"\",\"x\":0,\"y\":0,\"z\":0},{\"type\":\"station\",\"id\":186,\"status\":1,\"ip\":\"\",\"x\":0,\"y\":0,\"z\":0}]";
            //JArray JA_message = (JArray)JsonConvert.DeserializeObject(message);

            //string message = "[{\"type\":\"distance\",\"tagid\":1296,\"ancid\":211,\"value\":10105}]";
            //JArray JA_message = (JArray)JsonConvert.DeserializeObject(message);

            string message = "[{\"type\":\"tag\",\"id\":1296,\"mapId\":4,\"voltag\":8,\"x\":\"0.392\",\"y\":\"6.222\",\"z\":\"1.449\",\"hearID\":0,\"name\":\"1296\",\"tag_id\":\"4\",\"icon\":\"17\",\"show_track\":1},{\"type\":\"tag\",\"id\":1241,\"mapId\":4,\"voltag\":73,\"x\":\"0.031\",\"y\":\"6.433\",\"z\":\"1.338\",\"hearID\":0,\"name\":\"1241\",\"tag_id\":\"5\",\"icon\":\"20\",\"show_track\":1}]";
            JArray JA_message = (JArray)JsonConvert.DeserializeObject(message);

            //string message = "[{\"type\":\"tag\",\"id\":1296,\"mapId\":4,\"voltag\":8,\"x\":\"0.392\",\"y\":\"6.222\",\"z\":\"1.449\",\"hearID\":0,\"name\":\"1296\",\"tag_id\":\"4\",\"icon\":\"17\",\"show_track\":1}]";
            //JArray JA_message = (JArray)JsonConvert.DeserializeObject(message);

            //string jsonText = "{\"shenzheng\":\"深圳\",\"beijing\":\"北京\",\"shanghai\":[{\"zj1\":\"zj11\",\"zj2\":\"zj22\"},\"zjs\"]}";
            //JObject jo = (JObject)JsonConvert.DeserializeObject(jsonText);

            string key = JA_message[0]["type"].ToString();
            string[] message_show = Regex.Split(message, "},{", RegexOptions.IgnoreCase);

            int cut = 10 + key.Length;
            message_show[0] = message_show[0].Substring(2, message_show[0].Length - 2);
            message_show[JA_message.Count - 1] = message_show[JA_message.Count - 1].Substring(0, message_show[JA_message.Count - 1].Length - 2);
            for (int i = 0; i < JA_message.Count; i++)
            {
                message_show[i] = message_show[i].Substring(cut, message_show[i].Length - cut);
            }

            this.ShowMessage(message_show, key);

            for (int i = 0; i < JA_message.Count; i++)
            {
                if (JA_message[i]["type"].ToString() == "tag")//
                {
                    if (JA_message[i]["ID"].ToString() == TagID1)

                    {
                        IDbox_Tag1.Text = JA_message[i]["id"].ToString();
                        Xbox_Tag1.Text = JA_message[i]["x"].ToString();
                        Ybox_Tag1.Text = JA_message[i]["y"].ToString();
                        Zbox_Tag1.Text = JA_message[i]["z"].ToString();
                        string[] XY1 = { JA_message[i]["x"].ToString(), JA_message[i]["y"].ToString() };
                        int[] xy1 = DataHelper.XYtoxy(XY1, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                        TagPicture1.Left = xy1[0] - TagPicture1.Width / 2;
                        TagPicture1.Top = xy1[1] - TagPicture1.Height;
                    }

                    if (JA_message[i]["ID"].ToString() == TagID2)

                    {
                        IDbox_Tag2.Text = JA_message[i]["id"].ToString();
                        Xbox_Tag2.Text = JA_message[i]["x"].ToString();
                        Ybox_Tag2.Text = JA_message[i]["y"].ToString();
                        Zbox_Tag2.Text = JA_message[i]["z"].ToString();
                        string[] XY2 = { JA_message[i]["x"].ToString(), JA_message[i]["y"].ToString() };
                        int[] xy2 = DataHelper.XYtoxy(XY2, x_ld, x_ru, Xmax, y_ld, y_ru, Ymax);
                        TagPicture2.Left = xy2[0] - TagPicture1.Width / 2;
                        TagPicture2.Top = xy2[1] - TagPicture2.Height;
                    }


                }
                /*TagXYZ[4 * i] = JA_message[i]["id"].ToString();
                TagXYZ[4 * i + 1] = JA_message[i]["x"].ToString();
                TagXYZ[4 * i + 2] = JA_message[i]["y"].ToString();
                TagXYZ[4 * i + 3] = JA_message[i]["z"].ToString();*/
            }

            /*string[] TagXYZ = new string[JA_message.Count * 4];
            for (int i = 0; i < JA_message.Count; i++)
            {
                if (JA_message[i]["type"].ToString() != key)//
                {
                    return;
                }
                TagXYZ[4*i]= JA_message[i]["id"].ToString();
                TagXYZ[4 * i+1] = JA_message[i]["x"].ToString();
                TagXYZ[4 * i+2] = JA_message[i]["y"].ToString();
                TagXYZ[4 * i + 3] = JA_message[i]["z"].ToString();
            }


            /*int j = 0;
            foreach (TextBox item in panel_tag.Controls)
            {
                if (j >= TagXYZ.Length)
                {
                    break;
                }
                item.Text = TagXYZ[j];
                j++;
            }

            MoveTag(Xbox_Tag1.Text, Ybox_Tag1.Text, IDbox_Tag1.Text);
            MoveTag(Xbox_Tag2.Text, Ybox_Tag2.Text, IDbox_Tag2.Text);*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDeal.CreateXmlFile("Users", Xml_User, User_header);
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Anchor_Add_Click(object sender, EventArgs e)
        {
            AnchorAdd Form_AnchorAdd = new AnchorAdd();
            Form_AnchorAdd.ShowDialog();
        }

 
        private void btn_Tag_Add_Click(object sender, EventArgs e)
        {
            TagAdd Form_TagAdd = new TagAdd();
            Form_TagAdd.ShowDialog();
        }





        private void UWBclient_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Environment.Exit(0);
            if (btn_LinkDisconnect.Enabled == true)
            {
                e.Cancel = true;
                MessageBox.Show("请先断开连接", "Error", MessageBoxButtons.OK);
            }
            else
            {

                e.Cancel = false;
            }

        }



        /*private void button5_Click(object sender, EventArgs e)
        {
            lv_User.Items.Clear();
            //List<XmlDeal.UserInformation> userinformation_List = XmlDeal.LoadXmlFile();
            Thread th = new Thread(new ThreadStart(ThreadMethod)); //创建线程                     
            th.Start(); //启动线程

            User_Update();

        }


        void ThreadMethod()
        {
            while (true)
            {

                Thread.Sleep(5);//如果不延时，将占用CPU过高  
            }
        }
        */



        private void button2_Click(object sender, EventArgs e)
        {
            XmlDeal app = new XmlDeal();
            app.CreateXmlFile_user();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

    


    }
}
