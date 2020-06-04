namespace UWBclient_demo
{
    partial class UWBclient
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
            }
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
            }
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UWBclient));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("地图0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("地图1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("地图2");
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Page_Map = new System.Windows.Forms.TabPage();
            this.pb_Map_Tag2 = new System.Windows.Forms.PictureBox();
            this.pb_Map_Tag1 = new System.Windows.Forms.PictureBox();
            this.panel_Map_Assist = new System.Windows.Forms.Panel();
            this.Page_Search = new System.Windows.Forms.TextBox();
            this.btn_Map_Search = new System.Windows.Forms.Button();
            this.btn_Map_Fence_ShowFence = new System.Windows.Forms.Button();
            this.btn_Fence_Draw = new System.Windows.Forms.Button();
            this.btn_Map_ShowAnchor = new System.Windows.Forms.Button();
            this.btn_Map_Rotate2 = new System.Windows.Forms.Button();
            this.btn_Map_Rotate1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Map_Zoom = new System.Windows.Forms.Panel();
            this.btn_Map_ZoomNormal = new System.Windows.Forms.Button();
            this.btn_Map_ZoomFull = new System.Windows.Forms.Button();
            this.btn_Map_ZoomOut = new System.Windows.Forms.Button();
            this.btn_Map_ZoomIn = new System.Windows.Forms.Button();
            this.Trackbar_Map = new System.Windows.Forms.TrackBar();
            this.pb_Map_Map = new System.Windows.Forms.PictureBox();
            this.pb_Map_Grid = new System.Windows.Forms.PictureBox();
            this.Page_Monitor = new System.Windows.Forms.TabPage();
            this.tb_Monitor_ID = new System.Windows.Forms.TextBox();
            this.lab_Monitor_ID = new System.Windows.Forms.Label();
            this.tb_Monitor_Channel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Monitor_Select = new System.Windows.Forms.Button();
            this.cb_Monitor_Camera = new System.Windows.Forms.ComboBox();
            this.lab_Monitor_Record = new System.Windows.Forms.Label();
            this.lab_Monitor_JPEG = new System.Windows.Forms.Label();
            this.lab_Monitor_BMP = new System.Windows.Forms.Label();
            this.lab_Monitor_Preview = new System.Windows.Forms.Label();
            this.TabControl_PTZ = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.btn_Cloud_IrisAuto = new System.Windows.Forms.Button();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            this.btn_Cloud_ZoomIn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.btn_Cloud_FocusAuto = new System.Windows.Forms.Button();
            this.btn_Cloud_IrisDown = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Cloud_Up = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Cloud_IrisOpen = new System.Windows.Forms.Button();
            this.btn_Cloud_Left = new System.Windows.Forms.Button();
            this.btn_Cloud_Right = new System.Windows.Forms.Button();
            this.btn_Cloud_Down = new System.Windows.Forms.Button();
            this.btn_Cloud_FocusFar = new System.Windows.Forms.Button();
            this.btn_Cloud_ZoomOut = new System.Windows.Forms.Button();
            this.btn_Cloud_FocusNear = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.btn_Cloud_Match = new System.Windows.Forms.Button();
            this.ZPosition = new System.Windows.Forms.TextBox();
            this.YPosition = new System.Windows.Forms.TextBox();
            this.btn_Cloud_PreSet_Find = new System.Windows.Forms.Button();
            this.XPosition = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_Cloud_PtzGet = new System.Windows.Forms.Button();
            this.tb_Cloud_PanPos = new System.Windows.Forms.TextBox();
            this.btn_Cloud_PtzSet = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_Cloud_TiltPos = new System.Windows.Forms.TextBox();
            this.tb_Cloud_ZoomPos = new System.Windows.Forms.TextBox();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tb_Cloud_PreZoomPos = new System.Windows.Forms.TextBox();
            this.lab_Preset_name = new System.Windows.Forms.Label();
            this.tb_Cloud_PreTiltPos = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_Cloud_PrePanPos = new System.Windows.Forms.TextBox();
            this.tb_Cloud_PreSetName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_Cloud_PreSet_Name = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_Cloud_PreSet_Inf = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.btn_Cloud_PreSet_Go = new System.Windows.Forms.Button();
            this.btn_Cloud_PreSet_Delete = new System.Windows.Forms.Button();
            this.btn_Cloud_PreSet_Set = new System.Windows.Forms.Button();
            this.lab_Monitor_State = new System.Windows.Forms.Label();
            this.btn_Monitor_Record = new System.Windows.Forms.Button();
            this.btn_Monitor_JPEG = new System.Windows.Forms.Button();
            this.btn_Monitor_BMP = new System.Windows.Forms.Button();
            this.btn_Monitor_Preview = new System.Windows.Forms.Button();
            this.pb_Monitor_Tag2 = new System.Windows.Forms.PictureBox();
            this.pb_Monitor_Tag1 = new System.Windows.Forms.PictureBox();
            this.pb_Monitor_Map = new System.Windows.Forms.PictureBox();
            this.pb_Monitor_View = new System.Windows.Forms.PictureBox();
            this.Page_Alarm = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Alarm_Deal = new System.Windows.Forms.Button();
            this.btn_Alarm_Correct = new System.Windows.Forms.Button();
            this.btn_Alarm_Delete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lv_Alarm = new System.Windows.Forms.ListView();
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LineHeight = new System.Windows.Forms.ImageList(this.components);
            this.Page_Fence = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Fence_List = new System.Windows.Forms.Panel();
            this.btn_Fence_Add = new System.Windows.Forms.Button();
            this.btn_Fence_Modify = new System.Windows.Forms.Button();
            this.btn_Fence_Delete = new System.Windows.Forms.Button();
            this.Page_Tag = new System.Windows.Forms.TabPage();
            this.panel_People_btn = new System.Windows.Forms.Panel();
            this.btn_Tag_Add = new System.Windows.Forms.Button();
            this.btn_Tag_Modify = new System.Windows.Forms.Button();
            this.btn_Tag_Delete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lv_People = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader57 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_Anchor = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lv_Anchor = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Anchor_btn = new System.Windows.Forms.Panel();
            this.btn_Anchor_Add = new System.Windows.Forms.Button();
            this.btn_Anchor_Modify = new System.Windows.Forms.Button();
            this.btn_Anchor_Delete = new System.Windows.Forms.Button();
            this.Page_Camera = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Camera_Add = new System.Windows.Forms.Button();
            this.btn_Camera_Modify = new System.Windows.Forms.Button();
            this.btn_Camera_Delete = new System.Windows.Forms.Button();
            this.Page_Map_M = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lv_Map_M = new System.Windows.Forms.ListView();
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_Map_Add = new System.Windows.Forms.Button();
            this.btn_Map_Modify = new System.Windows.Forms.Button();
            this.btn_Map_Delete = new System.Windows.Forms.Button();
            this.Page_History = new System.Windows.Forms.TabPage();
            this.pb_History_Tag2 = new System.Windows.Forms.PictureBox();
            this.pb_History_Tag1 = new System.Windows.Forms.PictureBox();
            this.pb_History_Map = new System.Windows.Forms.PictureBox();
            this.panel_Map_Zoom_History = new System.Windows.Forms.Panel();
            this.btn_History_ZoomNormal = new System.Windows.Forms.Button();
            this.btn_History_ZoomFull = new System.Windows.Forms.Button();
            this.btn_History_ZoomOut = new System.Windows.Forms.Button();
            this.btn_History_ZoomIn = new System.Windows.Forms.Button();
            this.Trackbar_H_Map = new System.Windows.Forms.TrackBar();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtp_History_Stop = new System.Windows.Forms.DateTimePicker();
            this.dtp_History_Start = new System.Windows.Forms.DateTimePicker();
            this.Trackbar_H_Play = new System.Windows.Forms.TrackBar();
            this.cb_SelectTag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_History_Start = new System.Windows.Forms.Button();
            this.btn_History_Stop = new System.Windows.Forms.Button();
            this.btn_History_ShowFence = new System.Windows.Forms.Button();
            this.btn_History_DrawFence = new System.Windows.Forms.Button();
            this.btn_History_ShowAnchor = new System.Windows.Forms.Button();
            this.btn_History_Rotate2 = new System.Windows.Forms.Button();
            this.btn_History_Rotate1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_History_Grid = new System.Windows.Forms.PictureBox();
            this.Page_User = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_User_Add = new System.Windows.Forms.Button();
            this.btn_User_Modify = new System.Windows.Forms.Button();
            this.btn_User_Delete = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lv_User = new System.Windows.Forms.ListView();
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Page_System = new System.Windows.Forms.TabPage();
            this.btn_System_Set = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TagPicture2 = new System.Windows.Forms.PictureBox();
            this.TagPicture1 = new System.Windows.Forms.PictureBox();
            this.xy_mouse = new System.Windows.Forms.Label();
            this.Z_Tag2 = new System.Windows.Forms.Label();
            this.X_mouse = new System.Windows.Forms.Label();
            this.Y_mouse = new System.Windows.Forms.Label();
            this.Y_Tag2 = new System.Windows.Forms.Label();
            this.label_Mouse = new System.Windows.Forms.Label();
            this.Xbox_mouse = new System.Windows.Forms.TextBox();
            this.Z_Tag1 = new System.Windows.Forms.Label();
            this.ybox_local = new System.Windows.Forms.TextBox();
            this.xbox_local = new System.Windows.Forms.TextBox();
            this.X_Tag2 = new System.Windows.Forms.Label();
            this.Ybox_mouse = new System.Windows.Forms.TextBox();
            this.Y_Tag1 = new System.Windows.Forms.Label();
            this.label_Tag1 = new System.Windows.Forms.Label();
            this.label_Tag2 = new System.Windows.Forms.Label();
            this.X_Tag1 = new System.Windows.Forms.Label();
            this.ID_Tag2 = new System.Windows.Forms.Label();
            this.btn_SM = new System.Windows.Forms.Button();
            this.ID_Tag1 = new System.Windows.Forms.Label();
            this.btn_SZ = new System.Windows.Forms.Button();
            this.mapbox = new System.Windows.Forms.PictureBox();
            this.panel_tag = new System.Windows.Forms.Panel();
            this.IDbox_Tag1 = new System.Windows.Forms.TextBox();
            this.Xbox_Tag1 = new System.Windows.Forms.TextBox();
            this.Ybox_Tag1 = new System.Windows.Forms.TextBox();
            this.Zbox_Tag1 = new System.Windows.Forms.TextBox();
            this.IDbox_Tag2 = new System.Windows.Forms.TextBox();
            this.Xbox_Tag2 = new System.Windows.Forms.TextBox();
            this.Ybox_Tag2 = new System.Windows.Forms.TextBox();
            this.Zbox_Tag2 = new System.Windows.Forms.TextBox();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsvReceviedMsg = new System.Windows.Forms.ListView();
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_Log = new System.Windows.Forms.Panel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tb_ServerPort = new System.Windows.Forms.TextBox();
            this.lab_Username = new System.Windows.Forms.Label();
            this.tb_ServerIP = new System.Windows.Forms.TextBox();
            this.lab_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lab_Camera = new System.Windows.Forms.Label();
            this.lab_ServerIP = new System.Windows.Forms.Label();
            this.btn_LinkDisconnect = new System.Windows.Forms.Button();
            this.btn_LinkConnect = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.Page_Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Tag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Tag1)).BeginInit();
            this.panel_Map_Assist.SuspendLayout();
            this.panel_Map_Zoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Grid)).BeginInit();
            this.Page_Monitor.SuspendLayout();
            this.TabControl_PTZ.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Tag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Tag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_View)).BeginInit();
            this.Page_Alarm.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Page_Fence.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Fence_List.SuspendLayout();
            this.Page_Tag.SuspendLayout();
            this.panel_People_btn.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Page_Anchor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Anchor_btn.SuspendLayout();
            this.Page_Camera.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Page_Map_M.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.Page_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Tag2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Tag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Map)).BeginInit();
            this.panel_Map_Zoom_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_H_Map)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_H_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Grid)).BeginInit();
            this.Page_User.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.Page_System.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapbox)).BeginInit();
            this.panel_tag.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.Page_Map);
            this.TabControl1.Controls.Add(this.Page_Monitor);
            this.TabControl1.Controls.Add(this.Page_Alarm);
            this.TabControl1.Controls.Add(this.Page_Fence);
            this.TabControl1.Controls.Add(this.Page_Tag);
            this.TabControl1.Controls.Add(this.Page_Anchor);
            this.TabControl1.Controls.Add(this.Page_Camera);
            this.TabControl1.Controls.Add(this.Page_Map_M);
            this.TabControl1.Controls.Add(this.Page_History);
            this.TabControl1.Controls.Add(this.Page_User);
            this.TabControl1.Controls.Add(this.Page_System);
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage4);
            this.TabControl1.ItemSize = new System.Drawing.Size(48, 30);
            this.TabControl1.Location = new System.Drawing.Point(168, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1026, 655);
            this.TabControl1.TabIndex = 2;
            // 
            // Page_Map
            // 
            this.Page_Map.Controls.Add(this.pb_Map_Tag2);
            this.Page_Map.Controls.Add(this.pb_Map_Tag1);
            this.Page_Map.Controls.Add(this.panel_Map_Assist);
            this.Page_Map.Controls.Add(this.panel_Map_Zoom);
            this.Page_Map.Controls.Add(this.pb_Map_Map);
            this.Page_Map.Controls.Add(this.pb_Map_Grid);
            this.Page_Map.Location = new System.Drawing.Point(4, 34);
            this.Page_Map.Name = "Page_Map";
            this.Page_Map.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Map.Size = new System.Drawing.Size(1018, 617);
            this.Page_Map.TabIndex = 0;
            this.Page_Map.Text = "地图";
            this.Page_Map.UseVisualStyleBackColor = true;
            // 
            // pb_Map_Tag2
            // 
            this.pb_Map_Tag2.BackColor = System.Drawing.Color.Transparent;
            this.pb_Map_Tag2.Location = new System.Drawing.Point(577, 202);
            this.pb_Map_Tag2.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Map_Tag2.Name = "pb_Map_Tag2";
            this.pb_Map_Tag2.Size = new System.Drawing.Size(30, 42);
            this.pb_Map_Tag2.TabIndex = 41;
            this.pb_Map_Tag2.TabStop = false;
            // 
            // pb_Map_Tag1
            // 
            this.pb_Map_Tag1.BackColor = System.Drawing.Color.Transparent;
            this.pb_Map_Tag1.Location = new System.Drawing.Point(534, 280);
            this.pb_Map_Tag1.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Map_Tag1.Name = "pb_Map_Tag1";
            this.pb_Map_Tag1.Size = new System.Drawing.Size(30, 41);
            this.pb_Map_Tag1.TabIndex = 41;
            this.pb_Map_Tag1.TabStop = false;
            // 
            // panel_Map_Assist
            // 
            this.panel_Map_Assist.Controls.Add(this.Page_Search);
            this.panel_Map_Assist.Controls.Add(this.btn_Map_Search);
            this.panel_Map_Assist.Controls.Add(this.btn_Map_Fence_ShowFence);
            this.panel_Map_Assist.Controls.Add(this.btn_Fence_Draw);
            this.panel_Map_Assist.Controls.Add(this.btn_Map_ShowAnchor);
            this.panel_Map_Assist.Controls.Add(this.btn_Map_Rotate2);
            this.panel_Map_Assist.Controls.Add(this.btn_Map_Rotate1);
            this.panel_Map_Assist.Controls.Add(this.label5);
            this.panel_Map_Assist.Location = new System.Drawing.Point(-4, 0);
            this.panel_Map_Assist.Name = "panel_Map_Assist";
            this.panel_Map_Assist.Size = new System.Drawing.Size(1022, 47);
            this.panel_Map_Assist.TabIndex = 42;
            // 
            // Page_Search
            // 
            this.Page_Search.Location = new System.Drawing.Point(790, 14);
            this.Page_Search.Name = "Page_Search";
            this.Page_Search.Size = new System.Drawing.Size(124, 21);
            this.Page_Search.TabIndex = 2;
            // 
            // btn_Map_Search
            // 
            this.btn_Map_Search.Location = new System.Drawing.Point(920, 14);
            this.btn_Map_Search.Name = "btn_Map_Search";
            this.btn_Map_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Map_Search.TabIndex = 1;
            this.btn_Map_Search.Text = "搜索";
            this.btn_Map_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Map_Fence_ShowFence
            // 
            this.btn_Map_Fence_ShowFence.Location = new System.Drawing.Point(456, 14);
            this.btn_Map_Fence_ShowFence.Name = "btn_Map_Fence_ShowFence";
            this.btn_Map_Fence_ShowFence.Size = new System.Drawing.Size(75, 23);
            this.btn_Map_Fence_ShowFence.TabIndex = 1;
            this.btn_Map_Fence_ShowFence.Text = "显示围栏";
            this.btn_Map_Fence_ShowFence.UseVisualStyleBackColor = true;
            // 
            // btn_Fence_Draw
            // 
            this.btn_Fence_Draw.Location = new System.Drawing.Point(372, 14);
            this.btn_Fence_Draw.Name = "btn_Fence_Draw";
            this.btn_Fence_Draw.Size = new System.Drawing.Size(75, 23);
            this.btn_Fence_Draw.TabIndex = 1;
            this.btn_Fence_Draw.Text = "添加围栏";
            this.btn_Fence_Draw.UseVisualStyleBackColor = true;
            // 
            // btn_Map_ShowAnchor
            // 
            this.btn_Map_ShowAnchor.Location = new System.Drawing.Point(284, 14);
            this.btn_Map_ShowAnchor.Name = "btn_Map_ShowAnchor";
            this.btn_Map_ShowAnchor.Size = new System.Drawing.Size(75, 23);
            this.btn_Map_ShowAnchor.TabIndex = 1;
            this.btn_Map_ShowAnchor.Text = "显示基站";
            this.btn_Map_ShowAnchor.UseVisualStyleBackColor = true;
            // 
            // btn_Map_Rotate2
            // 
            this.btn_Map_Rotate2.Location = new System.Drawing.Point(192, 14);
            this.btn_Map_Rotate2.Name = "btn_Map_Rotate2";
            this.btn_Map_Rotate2.Size = new System.Drawing.Size(75, 23);
            this.btn_Map_Rotate2.TabIndex = 1;
            this.btn_Map_Rotate2.Text = "逆时针转";
            this.btn_Map_Rotate2.UseVisualStyleBackColor = true;
            // 
            // btn_Map_Rotate1
            // 
            this.btn_Map_Rotate1.Location = new System.Drawing.Point(100, 14);
            this.btn_Map_Rotate1.Name = "btn_Map_Rotate1";
            this.btn_Map_Rotate1.Size = new System.Drawing.Size(75, 23);
            this.btn_Map_Rotate1.TabIndex = 1;
            this.btn_Map_Rotate1.Text = "顺时针转";
            this.btn_Map_Rotate1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "X,Y";
            // 
            // panel_Map_Zoom
            // 
            this.panel_Map_Zoom.BackColor = System.Drawing.Color.White;
            this.panel_Map_Zoom.Controls.Add(this.btn_Map_ZoomNormal);
            this.panel_Map_Zoom.Controls.Add(this.btn_Map_ZoomFull);
            this.panel_Map_Zoom.Controls.Add(this.btn_Map_ZoomOut);
            this.panel_Map_Zoom.Controls.Add(this.btn_Map_ZoomIn);
            this.panel_Map_Zoom.Controls.Add(this.Trackbar_Map);
            this.panel_Map_Zoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Map_Zoom.Location = new System.Drawing.Point(83, 53);
            this.panel_Map_Zoom.Name = "panel_Map_Zoom";
            this.panel_Map_Zoom.Size = new System.Drawing.Size(88, 240);
            this.panel_Map_Zoom.TabIndex = 4;
            // 
            // btn_Map_ZoomNormal
            // 
            this.btn_Map_ZoomNormal.Location = new System.Drawing.Point(4, 172);
            this.btn_Map_ZoomNormal.Name = "btn_Map_ZoomNormal";
            this.btn_Map_ZoomNormal.Size = new System.Drawing.Size(41, 33);
            this.btn_Map_ZoomNormal.TabIndex = 4;
            this.btn_Map_ZoomNormal.Text = "1:1";
            this.btn_Map_ZoomNormal.UseVisualStyleBackColor = true;
            // 
            // btn_Map_ZoomFull
            // 
            this.btn_Map_ZoomFull.Location = new System.Drawing.Point(4, 133);
            this.btn_Map_ZoomFull.Name = "btn_Map_ZoomFull";
            this.btn_Map_ZoomFull.Size = new System.Drawing.Size(41, 33);
            this.btn_Map_ZoomFull.TabIndex = 4;
            this.btn_Map_ZoomFull.Text = "Full";
            this.btn_Map_ZoomFull.UseVisualStyleBackColor = true;
            // 
            // btn_Map_ZoomOut
            // 
            this.btn_Map_ZoomOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Map_ZoomOut.Location = new System.Drawing.Point(4, 75);
            this.btn_Map_ZoomOut.Name = "btn_Map_ZoomOut";
            this.btn_Map_ZoomOut.Size = new System.Drawing.Size(41, 33);
            this.btn_Map_ZoomOut.TabIndex = 4;
            this.btn_Map_ZoomOut.Text = "-";
            this.btn_Map_ZoomOut.UseVisualStyleBackColor = true;
            // 
            // btn_Map_ZoomIn
            // 
            this.btn_Map_ZoomIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Map_ZoomIn.Location = new System.Drawing.Point(4, 26);
            this.btn_Map_ZoomIn.Name = "btn_Map_ZoomIn";
            this.btn_Map_ZoomIn.Size = new System.Drawing.Size(41, 33);
            this.btn_Map_ZoomIn.TabIndex = 4;
            this.btn_Map_ZoomIn.Text = "+";
            this.btn_Map_ZoomIn.UseVisualStyleBackColor = true;
            // 
            // Trackbar_Map
            // 
            this.Trackbar_Map.Location = new System.Drawing.Point(51, 3);
            this.Trackbar_Map.Name = "Trackbar_Map";
            this.Trackbar_Map.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Trackbar_Map.Size = new System.Drawing.Size(45, 232);
            this.Trackbar_Map.TabIndex = 3;
            // 
            // pb_Map_Map
            // 
            this.pb_Map_Map.Location = new System.Drawing.Point(299, 56);
            this.pb_Map_Map.Name = "pb_Map_Map";
            this.pb_Map_Map.Size = new System.Drawing.Size(471, 545);
            this.pb_Map_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Map_Map.TabIndex = 0;
            this.pb_Map_Map.TabStop = false;
            // 
            // pb_Map_Grid
            // 
            this.pb_Map_Grid.Location = new System.Drawing.Point(0, 0);
            this.pb_Map_Grid.Name = "pb_Map_Grid";
            this.pb_Map_Grid.Size = new System.Drawing.Size(1018, 631);
            this.pb_Map_Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Map_Grid.TabIndex = 1;
            this.pb_Map_Grid.TabStop = false;
            // 
            // Page_Monitor
            // 
            this.Page_Monitor.Controls.Add(this.tb_Monitor_ID);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_ID);
            this.Page_Monitor.Controls.Add(this.tb_Monitor_Channel);
            this.Page_Monitor.Controls.Add(this.label13);
            this.Page_Monitor.Controls.Add(this.btn_Monitor_Select);
            this.Page_Monitor.Controls.Add(this.cb_Monitor_Camera);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_Record);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_JPEG);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_BMP);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_Preview);
            this.Page_Monitor.Controls.Add(this.TabControl_PTZ);
            this.Page_Monitor.Controls.Add(this.lab_Monitor_State);
            this.Page_Monitor.Controls.Add(this.btn_Monitor_Record);
            this.Page_Monitor.Controls.Add(this.btn_Monitor_JPEG);
            this.Page_Monitor.Controls.Add(this.btn_Monitor_BMP);
            this.Page_Monitor.Controls.Add(this.btn_Monitor_Preview);
            this.Page_Monitor.Controls.Add(this.pb_Monitor_Tag2);
            this.Page_Monitor.Controls.Add(this.pb_Monitor_Tag1);
            this.Page_Monitor.Controls.Add(this.pb_Monitor_Map);
            this.Page_Monitor.Controls.Add(this.pb_Monitor_View);
            this.Page_Monitor.Location = new System.Drawing.Point(4, 34);
            this.Page_Monitor.Name = "Page_Monitor";
            this.Page_Monitor.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Monitor.Size = new System.Drawing.Size(1018, 617);
            this.Page_Monitor.TabIndex = 1;
            this.Page_Monitor.Text = "监控";
            this.Page_Monitor.UseVisualStyleBackColor = true;
            // 
            // tb_Monitor_ID
            // 
            this.tb_Monitor_ID.Location = new System.Drawing.Point(331, 50);
            this.tb_Monitor_ID.Name = "tb_Monitor_ID";
            this.tb_Monitor_ID.Size = new System.Drawing.Size(185, 21);
            this.tb_Monitor_ID.TabIndex = 53;
            // 
            // lab_Monitor_ID
            // 
            this.lab_Monitor_ID.AutoSize = true;
            this.lab_Monitor_ID.Location = new System.Drawing.Point(296, 53);
            this.lab_Monitor_ID.Name = "lab_Monitor_ID";
            this.lab_Monitor_ID.Size = new System.Drawing.Size(29, 12);
            this.lab_Monitor_ID.TabIndex = 52;
            this.lab_Monitor_ID.Text = "流ID";
            // 
            // tb_Monitor_Channel
            // 
            this.tb_Monitor_Channel.Location = new System.Drawing.Point(478, 19);
            this.tb_Monitor_Channel.Name = "tb_Monitor_Channel";
            this.tb_Monitor_Channel.Size = new System.Drawing.Size(36, 21);
            this.tb_Monitor_Channel.TabIndex = 50;
            this.tb_Monitor_Channel.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(435, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 51;
            this.label13.Text = "通道";
            // 
            // btn_Monitor_Select
            // 
            this.btn_Monitor_Select.Location = new System.Drawing.Point(541, 19);
            this.btn_Monitor_Select.Name = "btn_Monitor_Select";
            this.btn_Monitor_Select.Size = new System.Drawing.Size(103, 46);
            this.btn_Monitor_Select.TabIndex = 49;
            this.btn_Monitor_Select.Text = "Select";
            this.btn_Monitor_Select.UseVisualStyleBackColor = true;
            this.btn_Monitor_Select.Click += new System.EventHandler(this.btn_Monitor_Select_Click);
            // 
            // cb_Monitor_Camera
            // 
            this.cb_Monitor_Camera.FormattingEnabled = true;
            this.cb_Monitor_Camera.Location = new System.Drawing.Point(298, 20);
            this.cb_Monitor_Camera.Name = "cb_Monitor_Camera";
            this.cb_Monitor_Camera.Size = new System.Drawing.Size(121, 20);
            this.cb_Monitor_Camera.TabIndex = 48;
            // 
            // lab_Monitor_Record
            // 
            this.lab_Monitor_Record.AutoSize = true;
            this.lab_Monitor_Record.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Monitor_Record.Location = new System.Drawing.Point(493, 570);
            this.lab_Monitor_Record.Name = "lab_Monitor_Record";
            this.lab_Monitor_Record.Size = new System.Drawing.Size(77, 14);
            this.lab_Monitor_Record.TabIndex = 47;
            this.lab_Monitor_Record.Text = "客户端录像";
            // 
            // lab_Monitor_JPEG
            // 
            this.lab_Monitor_JPEG.AutoSize = true;
            this.lab_Monitor_JPEG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Monitor_JPEG.Location = new System.Drawing.Point(356, 570);
            this.lab_Monitor_JPEG.Name = "lab_Monitor_JPEG";
            this.lab_Monitor_JPEG.Size = new System.Drawing.Size(63, 14);
            this.lab_Monitor_JPEG.TabIndex = 46;
            this.lab_Monitor_JPEG.Text = "JPEG抓图";
            // 
            // lab_Monitor_BMP
            // 
            this.lab_Monitor_BMP.AutoSize = true;
            this.lab_Monitor_BMP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Monitor_BMP.Location = new System.Drawing.Point(230, 570);
            this.lab_Monitor_BMP.Name = "lab_Monitor_BMP";
            this.lab_Monitor_BMP.Size = new System.Drawing.Size(56, 14);
            this.lab_Monitor_BMP.TabIndex = 45;
            this.lab_Monitor_BMP.Text = "BMP抓图";
            // 
            // lab_Monitor_Preview
            // 
            this.lab_Monitor_Preview.AutoSize = true;
            this.lab_Monitor_Preview.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Monitor_Preview.Location = new System.Drawing.Point(106, 570);
            this.lab_Monitor_Preview.Name = "lab_Monitor_Preview";
            this.lab_Monitor_Preview.Size = new System.Drawing.Size(35, 14);
            this.lab_Monitor_Preview.TabIndex = 44;
            this.lab_Monitor_Preview.Text = "预览";
            // 
            // TabControl_PTZ
            // 
            this.TabControl_PTZ.Controls.Add(this.tabPage11);
            this.TabControl_PTZ.Controls.Add(this.tabPage12);
            this.TabControl_PTZ.Controls.Add(this.tabPage13);
            this.TabControl_PTZ.Location = new System.Drawing.Point(682, 346);
            this.TabControl_PTZ.Name = "TabControl_PTZ";
            this.TabControl_PTZ.SelectedIndex = 0;
            this.TabControl_PTZ.Size = new System.Drawing.Size(283, 253);
            this.TabControl_PTZ.TabIndex = 43;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.btn_Cloud_IrisAuto);
            this.tabPage11.Controls.Add(this.checkBoxPreview);
            this.tabPage11.Controls.Add(this.btn_Cloud_ZoomIn);
            this.tabPage11.Controls.Add(this.label20);
            this.tabPage11.Controls.Add(this.comboBoxSpeed);
            this.tabPage11.Controls.Add(this.btn_Cloud_FocusAuto);
            this.tabPage11.Controls.Add(this.btn_Cloud_IrisDown);
            this.tabPage11.Controls.Add(this.label15);
            this.tabPage11.Controls.Add(this.label16);
            this.tabPage11.Controls.Add(this.btn_Cloud_Up);
            this.tabPage11.Controls.Add(this.label19);
            this.tabPage11.Controls.Add(this.btn_Cloud_IrisOpen);
            this.tabPage11.Controls.Add(this.btn_Cloud_Left);
            this.tabPage11.Controls.Add(this.btn_Cloud_Right);
            this.tabPage11.Controls.Add(this.btn_Cloud_Down);
            this.tabPage11.Controls.Add(this.btn_Cloud_FocusFar);
            this.tabPage11.Controls.Add(this.btn_Cloud_ZoomOut);
            this.tabPage11.Controls.Add(this.btn_Cloud_FocusNear);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(275, 227);
            this.tabPage11.TabIndex = 0;
            this.tabPage11.Text = "云台控制";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // btn_Cloud_IrisAuto
            // 
            this.btn_Cloud_IrisAuto.Location = new System.Drawing.Point(52, 160);
            this.btn_Cloud_IrisAuto.Name = "btn_Cloud_IrisAuto";
            this.btn_Cloud_IrisAuto.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_IrisAuto.TabIndex = 59;
            this.btn_Cloud_IrisAuto.Text = "自动";
            this.btn_Cloud_IrisAuto.UseVisualStyleBackColor = true;
            this.btn_Cloud_IrisAuto.Click += new System.EventHandler(this.btn_Cloud_IrisAuto_Click);
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Enabled = false;
            this.checkBoxPreview.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxPreview.Location = new System.Drawing.Point(187, 199);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(59, 20);
            this.checkBoxPreview.TabIndex = 46;
            this.checkBoxPreview.Text = "预览";
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            this.checkBoxPreview.Visible = false;
            // 
            // btn_Cloud_ZoomIn
            // 
            this.btn_Cloud_ZoomIn.Location = new System.Drawing.Point(52, 88);
            this.btn_Cloud_ZoomIn.Name = "btn_Cloud_ZoomIn";
            this.btn_Cloud_ZoomIn.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_ZoomIn.TabIndex = 45;
            this.btn_Cloud_ZoomIn.Text = "伸";
            this.btn_Cloud_ZoomIn.UseVisualStyleBackColor = true;
            this.btn_Cloud_ZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_ZoomIn_MouseDown);
            this.btn_Cloud_ZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_ZoomIn_MouseUp);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(11, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 58;
            this.label20.Text = "光圈";
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(95, 198);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(84, 20);
            this.comboBoxSpeed.TabIndex = 45;
            // 
            // btn_Cloud_FocusAuto
            // 
            this.btn_Cloud_FocusAuto.Location = new System.Drawing.Point(52, 127);
            this.btn_Cloud_FocusAuto.Name = "btn_Cloud_FocusAuto";
            this.btn_Cloud_FocusAuto.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_FocusAuto.TabIndex = 54;
            this.btn_Cloud_FocusAuto.Text = "自动";
            this.btn_Cloud_FocusAuto.UseVisualStyleBackColor = true;
            this.btn_Cloud_FocusAuto.Click += new System.EventHandler(this.btn_Cloud_FocusAuto_Click);
            // 
            // btn_Cloud_IrisDown
            // 
            this.btn_Cloud_IrisDown.Location = new System.Drawing.Point(187, 159);
            this.btn_Cloud_IrisDown.Name = "btn_Cloud_IrisDown";
            this.btn_Cloud_IrisDown.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_IrisDown.TabIndex = 57;
            this.btn_Cloud_IrisDown.Text = "小";
            this.btn_Cloud_IrisDown.UseVisualStyleBackColor = true;
            this.btn_Cloud_IrisDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_IrisClose_MouseDown);
            this.btn_Cloud_IrisDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_IrisClose_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(11, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 44;
            this.label15.Text = "云台速度：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(10, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "调焦";
            // 
            // btn_Cloud_Up
            // 
            this.btn_Cloud_Up.Location = new System.Drawing.Point(120, 6);
            this.btn_Cloud_Up.Name = "btn_Cloud_Up";
            this.btn_Cloud_Up.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_Up.TabIndex = 13;
            this.btn_Cloud_Up.Text = "Up";
            this.btn_Cloud_Up.UseVisualStyleBackColor = true;
            this.btn_Cloud_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Up_MouseDown);
            this.btn_Cloud_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Up_MouseUp);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(11, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 16);
            this.label19.TabIndex = 52;
            this.label19.Text = "聚焦";
            // 
            // btn_Cloud_IrisOpen
            // 
            this.btn_Cloud_IrisOpen.Location = new System.Drawing.Point(120, 159);
            this.btn_Cloud_IrisOpen.Name = "btn_Cloud_IrisOpen";
            this.btn_Cloud_IrisOpen.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_IrisOpen.TabIndex = 56;
            this.btn_Cloud_IrisOpen.Text = "大";
            this.btn_Cloud_IrisOpen.UseVisualStyleBackColor = true;
            this.btn_Cloud_IrisOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_IrisOpen_MouseDown);
            this.btn_Cloud_IrisOpen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_IrisOpen_MouseUp);
            // 
            // btn_Cloud_Left
            // 
            this.btn_Cloud_Left.Location = new System.Drawing.Point(52, 34);
            this.btn_Cloud_Left.Name = "btn_Cloud_Left";
            this.btn_Cloud_Left.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_Left.TabIndex = 14;
            this.btn_Cloud_Left.Text = "Left";
            this.btn_Cloud_Left.UseVisualStyleBackColor = true;
            this.btn_Cloud_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Left_MouseDown);
            this.btn_Cloud_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Left_MouseUp);
            // 
            // btn_Cloud_Right
            // 
            this.btn_Cloud_Right.Location = new System.Drawing.Point(186, 34);
            this.btn_Cloud_Right.Name = "btn_Cloud_Right";
            this.btn_Cloud_Right.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_Right.TabIndex = 16;
            this.btn_Cloud_Right.Text = "Right";
            this.btn_Cloud_Right.UseVisualStyleBackColor = true;
            this.btn_Cloud_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Right_MouseDown);
            this.btn_Cloud_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Right_MouseUp);
            // 
            // btn_Cloud_Down
            // 
            this.btn_Cloud_Down.Location = new System.Drawing.Point(120, 61);
            this.btn_Cloud_Down.Name = "btn_Cloud_Down";
            this.btn_Cloud_Down.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_Down.TabIndex = 17;
            this.btn_Cloud_Down.Text = "Down";
            this.btn_Cloud_Down.UseVisualStyleBackColor = true;
            this.btn_Cloud_Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Down_MouseDown);
            this.btn_Cloud_Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_Down_MouseUp);
            // 
            // btn_Cloud_FocusFar
            // 
            this.btn_Cloud_FocusFar.Location = new System.Drawing.Point(187, 127);
            this.btn_Cloud_FocusFar.Name = "btn_Cloud_FocusFar";
            this.btn_Cloud_FocusFar.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_FocusFar.TabIndex = 48;
            this.btn_Cloud_FocusFar.Text = "远";
            this.btn_Cloud_FocusFar.UseVisualStyleBackColor = true;
            this.btn_Cloud_FocusFar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_FocusFar_MouseDown);
            this.btn_Cloud_FocusFar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_FocusFar_MouseUp);
            // 
            // btn_Cloud_ZoomOut
            // 
            this.btn_Cloud_ZoomOut.Location = new System.Drawing.Point(188, 87);
            this.btn_Cloud_ZoomOut.Name = "btn_Cloud_ZoomOut";
            this.btn_Cloud_ZoomOut.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_ZoomOut.TabIndex = 46;
            this.btn_Cloud_ZoomOut.Text = "缩";
            this.btn_Cloud_ZoomOut.UseVisualStyleBackColor = true;
            this.btn_Cloud_ZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_ZoomOut_MouseDown);
            this.btn_Cloud_ZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_ZoomOut_MouseUp);
            // 
            // btn_Cloud_FocusNear
            // 
            this.btn_Cloud_FocusNear.Location = new System.Drawing.Point(120, 127);
            this.btn_Cloud_FocusNear.Name = "btn_Cloud_FocusNear";
            this.btn_Cloud_FocusNear.Size = new System.Drawing.Size(60, 27);
            this.btn_Cloud_FocusNear.TabIndex = 47;
            this.btn_Cloud_FocusNear.Text = "近";
            this.btn_Cloud_FocusNear.UseVisualStyleBackColor = true;
            this.btn_Cloud_FocusNear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_FocusNear_MouseDown);
            this.btn_Cloud_FocusNear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cloud_FocusNear_MouseUp);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.btn_Cloud_Match);
            this.tabPage12.Controls.Add(this.ZPosition);
            this.tabPage12.Controls.Add(this.YPosition);
            this.tabPage12.Controls.Add(this.btn_Cloud_PreSet_Find);
            this.tabPage12.Controls.Add(this.XPosition);
            this.tabPage12.Controls.Add(this.label21);
            this.tabPage12.Controls.Add(this.label22);
            this.tabPage12.Controls.Add(this.label23);
            this.tabPage12.Controls.Add(this.label33);
            this.tabPage12.Controls.Add(this.label26);
            this.tabPage12.Controls.Add(this.btn_Cloud_PtzGet);
            this.tabPage12.Controls.Add(this.tb_Cloud_PanPos);
            this.tabPage12.Controls.Add(this.btn_Cloud_PtzSet);
            this.tabPage12.Controls.Add(this.label25);
            this.tabPage12.Controls.Add(this.comboBoxAction);
            this.tabPage12.Controls.Add(this.label24);
            this.tabPage12.Controls.Add(this.label18);
            this.tabPage12.Controls.Add(this.tb_Cloud_TiltPos);
            this.tabPage12.Controls.Add(this.tb_Cloud_ZoomPos);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(275, 227);
            this.tabPage12.TabIndex = 1;
            this.tabPage12.Text = "坐标控制";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // btn_Cloud_Match
            // 
            this.btn_Cloud_Match.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_Match.Location = new System.Drawing.Point(144, 193);
            this.btn_Cloud_Match.Name = "btn_Cloud_Match";
            this.btn_Cloud_Match.Size = new System.Drawing.Size(75, 27);
            this.btn_Cloud_Match.TabIndex = 65;
            this.btn_Cloud_Match.Text = "Match";
            this.btn_Cloud_Match.UseVisualStyleBackColor = true;
            this.btn_Cloud_Match.Click += new System.EventHandler(this.btn_Cloud_Match_Click);
            // 
            // ZPosition
            // 
            this.ZPosition.Location = new System.Drawing.Point(205, 163);
            this.ZPosition.Name = "ZPosition";
            this.ZPosition.Size = new System.Drawing.Size(39, 21);
            this.ZPosition.TabIndex = 58;
            this.ZPosition.Text = "0";
            // 
            // YPosition
            // 
            this.YPosition.Location = new System.Drawing.Point(135, 163);
            this.YPosition.Name = "YPosition";
            this.YPosition.Size = new System.Drawing.Size(37, 21);
            this.YPosition.TabIndex = 63;
            this.YPosition.Text = "0";
            // 
            // btn_Cloud_PreSet_Find
            // 
            this.btn_Cloud_PreSet_Find.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Find.Location = new System.Drawing.Point(50, 193);
            this.btn_Cloud_PreSet_Find.Name = "btn_Cloud_PreSet_Find";
            this.btn_Cloud_PreSet_Find.Size = new System.Drawing.Size(71, 27);
            this.btn_Cloud_PreSet_Find.TabIndex = 64;
            this.btn_Cloud_PreSet_Find.Text = "Find";
            this.btn_Cloud_PreSet_Find.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Find.Click += new System.EventHandler(this.btn_Cloud_PreSet_Find_Click);
            // 
            // XPosition
            // 
            this.XPosition.Location = new System.Drawing.Point(60, 163);
            this.XPosition.Name = "XPosition";
            this.XPosition.Size = new System.Drawing.Size(37, 21);
            this.XPosition.TabIndex = 62;
            this.XPosition.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(185, 167);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 16);
            this.label21.TabIndex = 61;
            this.label21.Text = "z:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(112, 167);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 16);
            this.label22.TabIndex = 60;
            this.label22.Text = "y:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(37, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 16);
            this.label23.TabIndex = 59;
            this.label23.Text = "x:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(20, 46);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(233, 12);
            this.label33.TabIndex = 55;
            this.label33.Text = "范围：P∈( ,   )  T∈( ,  )  Z∈( ,  )";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(20, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 16);
            this.label26.TabIndex = 45;
            this.label26.Text = "P:";
            // 
            // btn_Cloud_PtzGet
            // 
            this.btn_Cloud_PtzGet.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PtzGet.Location = new System.Drawing.Point(155, 107);
            this.btn_Cloud_PtzGet.Name = "btn_Cloud_PtzGet";
            this.btn_Cloud_PtzGet.Size = new System.Drawing.Size(64, 20);
            this.btn_Cloud_PtzGet.TabIndex = 50;
            this.btn_Cloud_PtzGet.Text = "PtzGet";
            this.btn_Cloud_PtzGet.UseVisualStyleBackColor = true;
            this.btn_Cloud_PtzGet.Click += new System.EventHandler(this.btn_Cloud_PtzGet_Click);
            // 
            // tb_Cloud_PanPos
            // 
            this.tb_Cloud_PanPos.Location = new System.Drawing.Point(45, 15);
            this.tb_Cloud_PanPos.Name = "tb_Cloud_PanPos";
            this.tb_Cloud_PanPos.Size = new System.Drawing.Size(33, 21);
            this.tb_Cloud_PanPos.TabIndex = 46;
            // 
            // btn_Cloud_PtzSet
            // 
            this.btn_Cloud_PtzSet.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PtzSet.Location = new System.Drawing.Point(50, 107);
            this.btn_Cloud_PtzSet.Name = "btn_Cloud_PtzSet";
            this.btn_Cloud_PtzSet.Size = new System.Drawing.Size(63, 20);
            this.btn_Cloud_PtzSet.TabIndex = 51;
            this.btn_Cloud_PtzSet.Text = "PtzSet";
            this.btn_Cloud_PtzSet.UseVisualStyleBackColor = true;
            this.btn_Cloud_PtzSet.Click += new System.EventHandler(this.btn_Cloud_PtzSet_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(109, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 16);
            this.label25.TabIndex = 47;
            this.label25.Text = "T:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.AutoCompleteCustomSource.AddRange(new string[] {
            "1-定位PTZ参数",
            "2-定位P参数",
            "3-定位T参数",
            "4-定位Z参数",
            "5-定位PT参数"});
            this.comboBoxAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "1-定位PTZ参数",
            "2-定位P参数",
            "3-定位T参数",
            "4-定位Z参数",
            "5-定位PT参数"});
            this.comboBoxAction.Location = new System.Drawing.Point(114, 72);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(124, 20);
            this.comboBoxAction.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(187, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 16);
            this.label24.TabIndex = 48;
            this.label24.Text = "Z:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(20, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "操作类型：";
            // 
            // tb_Cloud_TiltPos
            // 
            this.tb_Cloud_TiltPos.Location = new System.Drawing.Point(133, 15);
            this.tb_Cloud_TiltPos.Name = "tb_Cloud_TiltPos";
            this.tb_Cloud_TiltPos.Size = new System.Drawing.Size(31, 21);
            this.tb_Cloud_TiltPos.TabIndex = 49;
            // 
            // tb_Cloud_ZoomPos
            // 
            this.tb_Cloud_ZoomPos.Location = new System.Drawing.Point(215, 15);
            this.tb_Cloud_ZoomPos.Name = "tb_Cloud_ZoomPos";
            this.tb_Cloud_ZoomPos.Size = new System.Drawing.Size(38, 21);
            this.tb_Cloud_ZoomPos.TabIndex = 54;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.label28);
            this.tabPage13.Controls.Add(this.comboBox1);
            this.tabPage13.Controls.Add(this.tb_Cloud_PreZoomPos);
            this.tabPage13.Controls.Add(this.lab_Preset_name);
            this.tabPage13.Controls.Add(this.tb_Cloud_PreTiltPos);
            this.tabPage13.Controls.Add(this.label32);
            this.tabPage13.Controls.Add(this.tb_Cloud_PrePanPos);
            this.tabPage13.Controls.Add(this.tb_Cloud_PreSetName);
            this.tabPage13.Controls.Add(this.label29);
            this.tabPage13.Controls.Add(this.btn_Cloud_PreSet_Name);
            this.tabPage13.Controls.Add(this.label30);
            this.tabPage13.Controls.Add(this.btn_Cloud_PreSet_Inf);
            this.tabPage13.Controls.Add(this.label31);
            this.tabPage13.Controls.Add(this.btn_Cloud_PreSet_Go);
            this.tabPage13.Controls.Add(this.btn_Cloud_PreSet_Delete);
            this.tabPage13.Controls.Add(this.btn_Cloud_PreSet_Set);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(275, 227);
            this.tabPage13.TabIndex = 2;
            this.tabPage13.Text = "预置点设置";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(23, 198);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(191, 12);
            this.label28.TabIndex = 59;
            this.label28.Text = "注：不能直接以PTZ坐标设置预置点";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300"});
            this.comboBox1.Location = new System.Drawing.Point(10, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 20);
            this.comboBox1.TabIndex = 46;
            // 
            // tb_Cloud_PreZoomPos
            // 
            this.tb_Cloud_PreZoomPos.Location = new System.Drawing.Point(191, 121);
            this.tb_Cloud_PreZoomPos.Name = "tb_Cloud_PreZoomPos";
            this.tb_Cloud_PreZoomPos.Size = new System.Drawing.Size(39, 21);
            this.tb_Cloud_PreZoomPos.TabIndex = 44;
            // 
            // lab_Preset_name
            // 
            this.lab_Preset_name.AutoSize = true;
            this.lab_Preset_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Preset_name.Location = new System.Drawing.Point(29, 83);
            this.lab_Preset_name.Name = "lab_Preset_name";
            this.lab_Preset_name.Size = new System.Drawing.Size(91, 14);
            this.lab_Preset_name.TabIndex = 45;
            this.lab_Preset_name.Text = "预置点名称：";
            // 
            // tb_Cloud_PreTiltPos
            // 
            this.tb_Cloud_PreTiltPos.Location = new System.Drawing.Point(121, 121);
            this.tb_Cloud_PreTiltPos.Name = "tb_Cloud_PreTiltPos";
            this.tb_Cloud_PreTiltPos.Size = new System.Drawing.Size(37, 21);
            this.tb_Cloud_PreTiltPos.TabIndex = 58;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(10, 17);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 14);
            this.label32.TabIndex = 47;
            this.label32.Text = "预置点号";
            // 
            // tb_Cloud_PrePanPos
            // 
            this.tb_Cloud_PrePanPos.Location = new System.Drawing.Point(46, 121);
            this.tb_Cloud_PrePanPos.Name = "tb_Cloud_PrePanPos";
            this.tb_Cloud_PrePanPos.Size = new System.Drawing.Size(37, 21);
            this.tb_Cloud_PrePanPos.TabIndex = 57;
            // 
            // tb_Cloud_PreSetName
            // 
            this.tb_Cloud_PreSetName.Location = new System.Drawing.Point(137, 80);
            this.tb_Cloud_PreSetName.Name = "tb_Cloud_PreSetName";
            this.tb_Cloud_PreSetName.Size = new System.Drawing.Size(93, 21);
            this.tb_Cloud_PreSetName.TabIndex = 48;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(171, 123);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 16);
            this.label29.TabIndex = 56;
            this.label29.Text = "Z:";
            // 
            // btn_Cloud_PreSet_Name
            // 
            this.btn_Cloud_PreSet_Name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Name.Location = new System.Drawing.Point(10, 157);
            this.btn_Cloud_PreSet_Name.Name = "btn_Cloud_PreSet_Name";
            this.btn_Cloud_PreSet_Name.Size = new System.Drawing.Size(120, 31);
            this.btn_Cloud_PreSet_Name.TabIndex = 49;
            this.btn_Cloud_PreSet_Name.Text = "预置点名称设置";
            this.btn_Cloud_PreSet_Name.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Name.Click += new System.EventHandler(this.btn_Cloud_PreSet_Name_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(98, 123);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 16);
            this.label30.TabIndex = 55;
            this.label30.Text = "T:";
            // 
            // btn_Cloud_PreSet_Inf
            // 
            this.btn_Cloud_PreSet_Inf.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Inf.Location = new System.Drawing.Point(137, 157);
            this.btn_Cloud_PreSet_Inf.Name = "btn_Cloud_PreSet_Inf";
            this.btn_Cloud_PreSet_Inf.Size = new System.Drawing.Size(121, 31);
            this.btn_Cloud_PreSet_Inf.TabIndex = 50;
            this.btn_Cloud_PreSet_Inf.Text = "预置点信息获取";
            this.btn_Cloud_PreSet_Inf.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Inf.Click += new System.EventHandler(this.btn_Cloud_PreSet_Inf_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(23, 123);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(24, 16);
            this.label31.TabIndex = 54;
            this.label31.Text = "P:";
            // 
            // btn_Cloud_PreSet_Go
            // 
            this.btn_Cloud_PreSet_Go.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Go.Location = new System.Drawing.Point(144, 38);
            this.btn_Cloud_PreSet_Go.Name = "btn_Cloud_PreSet_Go";
            this.btn_Cloud_PreSet_Go.Size = new System.Drawing.Size(51, 27);
            this.btn_Cloud_PreSet_Go.TabIndex = 51;
            this.btn_Cloud_PreSet_Go.Text = "调用";
            this.btn_Cloud_PreSet_Go.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Go.Click += new System.EventHandler(this.btn_Cloud_PreSet_Go_Click);
            // 
            // btn_Cloud_PreSet_Delete
            // 
            this.btn_Cloud_PreSet_Delete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Delete.Location = new System.Drawing.Point(208, 39);
            this.btn_Cloud_PreSet_Delete.Name = "btn_Cloud_PreSet_Delete";
            this.btn_Cloud_PreSet_Delete.Size = new System.Drawing.Size(50, 26);
            this.btn_Cloud_PreSet_Delete.TabIndex = 53;
            this.btn_Cloud_PreSet_Delete.Text = "删除";
            this.btn_Cloud_PreSet_Delete.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Delete.Click += new System.EventHandler(this.btn_Cloud_PreSet_Delete_Click);
            // 
            // btn_Cloud_PreSet_Set
            // 
            this.btn_Cloud_PreSet_Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cloud_PreSet_Set.Location = new System.Drawing.Point(79, 38);
            this.btn_Cloud_PreSet_Set.Name = "btn_Cloud_PreSet_Set";
            this.btn_Cloud_PreSet_Set.Size = new System.Drawing.Size(51, 26);
            this.btn_Cloud_PreSet_Set.TabIndex = 52;
            this.btn_Cloud_PreSet_Set.Text = "设置";
            this.btn_Cloud_PreSet_Set.UseVisualStyleBackColor = true;
            this.btn_Cloud_PreSet_Set.Click += new System.EventHandler(this.btn_Cloud_PreSet_Set_Click);
            // 
            // lab_Monitor_State
            // 
            this.lab_Monitor_State.AutoSize = true;
            this.lab_Monitor_State.Location = new System.Drawing.Point(30, 22);
            this.lab_Monitor_State.Name = "lab_Monitor_State";
            this.lab_Monitor_State.Size = new System.Drawing.Size(65, 12);
            this.lab_Monitor_State.TabIndex = 42;
            this.lab_Monitor_State.Text = "状态提示：";
            // 
            // btn_Monitor_Record
            // 
            this.btn_Monitor_Record.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Monitor_Record.Location = new System.Drawing.Point(478, 506);
            this.btn_Monitor_Record.Name = "btn_Monitor_Record";
            this.btn_Monitor_Record.Size = new System.Drawing.Size(107, 48);
            this.btn_Monitor_Record.TabIndex = 14;
            this.btn_Monitor_Record.Text = "Start Record";
            this.btn_Monitor_Record.UseVisualStyleBackColor = true;
            this.btn_Monitor_Record.Click += new System.EventHandler(this.btn_Monitor_Record_Click);
            // 
            // btn_Monitor_JPEG
            // 
            this.btn_Monitor_JPEG.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Monitor_JPEG.Location = new System.Drawing.Point(338, 506);
            this.btn_Monitor_JPEG.Name = "btn_Monitor_JPEG";
            this.btn_Monitor_JPEG.Size = new System.Drawing.Size(105, 48);
            this.btn_Monitor_JPEG.TabIndex = 13;
            this.btn_Monitor_JPEG.Text = "Capture JPEG";
            this.btn_Monitor_JPEG.UseVisualStyleBackColor = true;
            this.btn_Monitor_JPEG.Click += new System.EventHandler(this.btn_Monitor_JPEG_Click);
            // 
            // btn_Monitor_BMP
            // 
            this.btn_Monitor_BMP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Monitor_BMP.Location = new System.Drawing.Point(213, 506);
            this.btn_Monitor_BMP.Name = "btn_Monitor_BMP";
            this.btn_Monitor_BMP.Size = new System.Drawing.Size(92, 47);
            this.btn_Monitor_BMP.TabIndex = 12;
            this.btn_Monitor_BMP.Text = "Capture BMP ";
            this.btn_Monitor_BMP.UseVisualStyleBackColor = true;
            this.btn_Monitor_BMP.Click += new System.EventHandler(this.btn_Monitor_BMP_Click);
            // 
            // btn_Monitor_Preview
            // 
            this.btn_Monitor_Preview.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Monitor_Preview.Location = new System.Drawing.Point(84, 505);
            this.btn_Monitor_Preview.Name = "btn_Monitor_Preview";
            this.btn_Monitor_Preview.Size = new System.Drawing.Size(87, 48);
            this.btn_Monitor_Preview.TabIndex = 11;
            this.btn_Monitor_Preview.Text = "Live View";
            this.btn_Monitor_Preview.Click += new System.EventHandler(this.btn_Monitor_Preview_Click);
            // 
            // pb_Monitor_Tag2
            // 
            this.pb_Monitor_Tag2.BackColor = System.Drawing.Color.Transparent;
            this.pb_Monitor_Tag2.Location = new System.Drawing.Point(790, 124);
            this.pb_Monitor_Tag2.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Monitor_Tag2.Name = "pb_Monitor_Tag2";
            this.pb_Monitor_Tag2.Size = new System.Drawing.Size(20, 27);
            this.pb_Monitor_Tag2.TabIndex = 40;
            this.pb_Monitor_Tag2.TabStop = false;
            // 
            // pb_Monitor_Tag1
            // 
            this.pb_Monitor_Tag1.BackColor = System.Drawing.Color.Transparent;
            this.pb_Monitor_Tag1.Location = new System.Drawing.Point(729, 104);
            this.pb_Monitor_Tag1.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Monitor_Tag1.Name = "pb_Monitor_Tag1";
            this.pb_Monitor_Tag1.Size = new System.Drawing.Size(20, 27);
            this.pb_Monitor_Tag1.TabIndex = 41;
            this.pb_Monitor_Tag1.TabStop = false;
            // 
            // pb_Monitor_Map
            // 
            this.pb_Monitor_Map.Location = new System.Drawing.Point(682, 6);
            this.pb_Monitor_Map.Name = "pb_Monitor_Map";
            this.pb_Monitor_Map.Size = new System.Drawing.Size(283, 324);
            this.pb_Monitor_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Monitor_Map.TabIndex = 2;
            this.pb_Monitor_Map.TabStop = false;
            // 
            // pb_Monitor_View
            // 
            this.pb_Monitor_View.BackColor = System.Drawing.Color.Black;
            this.pb_Monitor_View.Location = new System.Drawing.Point(32, 84);
            this.pb_Monitor_View.Name = "pb_Monitor_View";
            this.pb_Monitor_View.Size = new System.Drawing.Size(612, 390);
            this.pb_Monitor_View.TabIndex = 1;
            this.pb_Monitor_View.TabStop = false;
            // 
            // Page_Alarm
            // 
            this.Page_Alarm.Controls.Add(this.panel8);
            this.Page_Alarm.Controls.Add(this.panel7);
            this.Page_Alarm.Location = new System.Drawing.Point(4, 34);
            this.Page_Alarm.Name = "Page_Alarm";
            this.Page_Alarm.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Alarm.Size = new System.Drawing.Size(1018, 617);
            this.Page_Alarm.TabIndex = 7;
            this.Page_Alarm.Text = "报警处理";
            this.Page_Alarm.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Alarm_Deal);
            this.panel8.Controls.Add(this.btn_Alarm_Correct);
            this.panel8.Controls.Add(this.btn_Alarm_Delete);
            this.panel8.Location = new System.Drawing.Point(0, 533);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1018, 88);
            this.panel8.TabIndex = 35;
            // 
            // btn_Alarm_Deal
            // 
            this.btn_Alarm_Deal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Alarm_Deal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Alarm_Deal.Location = new System.Drawing.Point(322, 25);
            this.btn_Alarm_Deal.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Alarm_Deal.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Deal.Name = "btn_Alarm_Deal";
            this.btn_Alarm_Deal.Size = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Deal.TabIndex = 30;
            this.btn_Alarm_Deal.Text = "Deal";
            this.btn_Alarm_Deal.UseVisualStyleBackColor = true;
            // 
            // btn_Alarm_Correct
            // 
            this.btn_Alarm_Correct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Alarm_Correct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Alarm_Correct.Location = new System.Drawing.Point(600, 25);
            this.btn_Alarm_Correct.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Alarm_Correct.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Correct.Name = "btn_Alarm_Correct";
            this.btn_Alarm_Correct.Size = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Correct.TabIndex = 31;
            this.btn_Alarm_Correct.Text = "Correct";
            this.btn_Alarm_Correct.UseVisualStyleBackColor = true;
            // 
            // btn_Alarm_Delete
            // 
            this.btn_Alarm_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Alarm_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Alarm_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Alarm_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Alarm_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Delete.Name = "btn_Alarm_Delete";
            this.btn_Alarm_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Alarm_Delete.TabIndex = 32;
            this.btn_Alarm_Delete.Text = "Delete";
            this.btn_Alarm_Delete.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lv_Alarm);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 527);
            this.panel7.TabIndex = 31;
            // 
            // lv_Alarm
            // 
            this.lv_Alarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader45});
            this.lv_Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Alarm.FullRowSelect = true;
            this.lv_Alarm.GridLines = true;
            this.lv_Alarm.Location = new System.Drawing.Point(0, 0);
            this.lv_Alarm.Name = "lv_Alarm";
            this.lv_Alarm.Size = new System.Drawing.Size(1018, 527);
            this.lv_Alarm.SmallImageList = this.LineHeight;
            this.lv_Alarm.TabIndex = 1;
            this.lv_Alarm.UseCompatibleStateImageBehavior = false;
            this.lv_Alarm.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "序号";
            this.columnHeader26.Width = 100;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "围栏名称";
            this.columnHeader27.Width = 87;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "所在地图";
            this.columnHeader28.Width = 83;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "标签名称";
            this.columnHeader29.Width = 136;
            // 
            // columnHeader30
            // 
            this.columnHeader30.DisplayIndex = 5;
            this.columnHeader30.Text = "标签编号";
            this.columnHeader30.Width = 104;
            // 
            // columnHeader31
            // 
            this.columnHeader31.DisplayIndex = 6;
            this.columnHeader31.Text = "报警类型";
            this.columnHeader31.Width = 124;
            // 
            // columnHeader32
            // 
            this.columnHeader32.DisplayIndex = 4;
            this.columnHeader32.Text = "状态";
            this.columnHeader32.Width = 89;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "报警时间";
            // 
            // LineHeight
            // 
            this.LineHeight.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.LineHeight.ImageSize = new System.Drawing.Size(1, 24);
            this.LineHeight.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Page_Fence
            // 
            this.Page_Fence.Controls.Add(this.panel5);
            this.Page_Fence.Controls.Add(this.panel_Fence_List);
            this.Page_Fence.Location = new System.Drawing.Point(4, 34);
            this.Page_Fence.Name = "Page_Fence";
            this.Page_Fence.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Fence.Size = new System.Drawing.Size(1018, 617);
            this.Page_Fence.TabIndex = 6;
            this.Page_Fence.Text = "电子围栏";
            this.Page_Fence.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 527);
            this.panel5.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1018, 527);
            this.listView1.SmallImageList = this.LineHeight;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "序号";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "围栏名称";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "所在地图";
            this.columnHeader7.Width = 108;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "开始时间";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "结束时间";
            this.columnHeader33.Width = 116;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "围栏类型";
            this.columnHeader34.Width = 125;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "是否开启";
            this.columnHeader42.Width = 99;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "声音提示";
            this.columnHeader43.Width = 86;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "视频联动";
            this.columnHeader44.Width = 74;
            // 
            // panel_Fence_List
            // 
            this.panel_Fence_List.Controls.Add(this.btn_Fence_Add);
            this.panel_Fence_List.Controls.Add(this.btn_Fence_Modify);
            this.panel_Fence_List.Controls.Add(this.btn_Fence_Delete);
            this.panel_Fence_List.Location = new System.Drawing.Point(0, 533);
            this.panel_Fence_List.Name = "panel_Fence_List";
            this.panel_Fence_List.Size = new System.Drawing.Size(1018, 88);
            this.panel_Fence_List.TabIndex = 34;
            // 
            // btn_Fence_Add
            // 
            this.btn_Fence_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Fence_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Fence_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_Fence_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Fence_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Fence_Add.Name = "btn_Fence_Add";
            this.btn_Fence_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_Fence_Add.TabIndex = 30;
            this.btn_Fence_Add.Text = "Add";
            this.btn_Fence_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Fence_Modify
            // 
            this.btn_Fence_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Fence_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Fence_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_Fence_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Fence_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Fence_Modify.Name = "btn_Fence_Modify";
            this.btn_Fence_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_Fence_Modify.TabIndex = 31;
            this.btn_Fence_Modify.Text = "Modify";
            this.btn_Fence_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Fence_Delete
            // 
            this.btn_Fence_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Fence_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Fence_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Fence_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Fence_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Fence_Delete.Name = "btn_Fence_Delete";
            this.btn_Fence_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Fence_Delete.TabIndex = 32;
            this.btn_Fence_Delete.Text = "Delete";
            this.btn_Fence_Delete.UseVisualStyleBackColor = true;
            // 
            // Page_Tag
            // 
            this.Page_Tag.Controls.Add(this.panel_People_btn);
            this.Page_Tag.Controls.Add(this.panel4);
            this.Page_Tag.Location = new System.Drawing.Point(4, 34);
            this.Page_Tag.Name = "Page_Tag";
            this.Page_Tag.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Tag.Size = new System.Drawing.Size(1018, 617);
            this.Page_Tag.TabIndex = 2;
            this.Page_Tag.Text = "标签管理";
            this.Page_Tag.UseVisualStyleBackColor = true;
            // 
            // panel_People_btn
            // 
            this.panel_People_btn.Controls.Add(this.btn_Tag_Add);
            this.panel_People_btn.Controls.Add(this.btn_Tag_Modify);
            this.panel_People_btn.Controls.Add(this.btn_Tag_Delete);
            this.panel_People_btn.Location = new System.Drawing.Point(0, 533);
            this.panel_People_btn.Name = "panel_People_btn";
            this.panel_People_btn.Size = new System.Drawing.Size(1018, 88);
            this.panel_People_btn.TabIndex = 35;
            // 
            // btn_Tag_Add
            // 
            this.btn_Tag_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Tag_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Tag_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_Tag_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Tag_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Tag_Add.Name = "btn_Tag_Add";
            this.btn_Tag_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_Tag_Add.TabIndex = 30;
            this.btn_Tag_Add.Text = "Add";
            this.btn_Tag_Add.UseVisualStyleBackColor = true;
            this.btn_Tag_Add.Click += new System.EventHandler(this.btn_Tag_Add_Click);
            // 
            // btn_Tag_Modify
            // 
            this.btn_Tag_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Tag_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Tag_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_Tag_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Tag_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Tag_Modify.Name = "btn_Tag_Modify";
            this.btn_Tag_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_Tag_Modify.TabIndex = 31;
            this.btn_Tag_Modify.Text = "Modify";
            this.btn_Tag_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Tag_Delete
            // 
            this.btn_Tag_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Tag_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Tag_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Tag_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Tag_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Tag_Delete.Name = "btn_Tag_Delete";
            this.btn_Tag_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Tag_Delete.TabIndex = 32;
            this.btn_Tag_Delete.Text = "Delete";
            this.btn_Tag_Delete.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lv_People);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 527);
            this.panel4.TabIndex = 30;
            // 
            // lv_People
            // 
            this.lv_People.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader57,
            this.columnHeader9});
            this.lv_People.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_People.FullRowSelect = true;
            this.lv_People.GridLines = true;
            this.lv_People.Location = new System.Drawing.Point(0, 0);
            this.lv_People.Name = "lv_People";
            this.lv_People.Size = new System.Drawing.Size(1018, 527);
            this.lv_People.SmallImageList = this.LineHeight;
            this.lv_People.TabIndex = 1;
            this.lv_People.UseCompatibleStateImageBehavior = false;
            this.lv_People.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "标签编号";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "标签名称";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "标签类型";
            this.columnHeader4.Width = 136;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "地图显示";
            this.columnHeader10.Width = 104;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "显示轨迹";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader57
            // 
            this.columnHeader57.Text = "标签图案";
            this.columnHeader57.Width = 92;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "剩余电量";
            this.columnHeader9.Width = 89;
            // 
            // Page_Anchor
            // 
            this.Page_Anchor.Controls.Add(this.panel3);
            this.Page_Anchor.Controls.Add(this.panel_Anchor_btn);
            this.Page_Anchor.Location = new System.Drawing.Point(4, 34);
            this.Page_Anchor.Name = "Page_Anchor";
            this.Page_Anchor.Size = new System.Drawing.Size(1018, 617);
            this.Page_Anchor.TabIndex = 8;
            this.Page_Anchor.Text = "基站管理";
            this.Page_Anchor.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lv_Anchor);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 527);
            this.panel3.TabIndex = 31;
            // 
            // lv_Anchor
            // 
            this.lv_Anchor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lv_Anchor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Anchor.FullRowSelect = true;
            this.lv_Anchor.GridLines = true;
            this.lv_Anchor.Location = new System.Drawing.Point(0, 0);
            this.lv_Anchor.Name = "lv_Anchor";
            this.lv_Anchor.Size = new System.Drawing.Size(1018, 527);
            this.lv_Anchor.SmallImageList = this.LineHeight;
            this.lv_Anchor.TabIndex = 1;
            this.lv_Anchor.UseCompatibleStateImageBehavior = false;
            this.lv_Anchor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "序号";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "基站编号";
            this.columnHeader13.Width = 87;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "x坐标";
            this.columnHeader14.Width = 83;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "y坐标";
            this.columnHeader15.Width = 136;
            // 
            // columnHeader16
            // 
            this.columnHeader16.DisplayIndex = 5;
            this.columnHeader16.Text = "z坐标";
            this.columnHeader16.Width = 104;
            // 
            // columnHeader17
            // 
            this.columnHeader17.DisplayIndex = 6;
            this.columnHeader17.Text = "IP";
            this.columnHeader17.Width = 124;
            // 
            // columnHeader18
            // 
            this.columnHeader18.DisplayIndex = 4;
            this.columnHeader18.Text = "所属地图";
            this.columnHeader18.Width = 89;
            // 
            // panel_Anchor_btn
            // 
            this.panel_Anchor_btn.Controls.Add(this.btn_Anchor_Add);
            this.panel_Anchor_btn.Controls.Add(this.btn_Anchor_Modify);
            this.panel_Anchor_btn.Controls.Add(this.btn_Anchor_Delete);
            this.panel_Anchor_btn.Location = new System.Drawing.Point(0, 533);
            this.panel_Anchor_btn.Name = "panel_Anchor_btn";
            this.panel_Anchor_btn.Size = new System.Drawing.Size(1018, 88);
            this.panel_Anchor_btn.TabIndex = 36;
            // 
            // btn_Anchor_Add
            // 
            this.btn_Anchor_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Anchor_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Anchor_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_Anchor_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Anchor_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Add.Name = "btn_Anchor_Add";
            this.btn_Anchor_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Add.TabIndex = 30;
            this.btn_Anchor_Add.Text = "Add";
            this.btn_Anchor_Add.UseVisualStyleBackColor = true;
            this.btn_Anchor_Add.Click += new System.EventHandler(this.btn_Anchor_Add_Click);
            // 
            // btn_Anchor_Modify
            // 
            this.btn_Anchor_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Anchor_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Anchor_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_Anchor_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Anchor_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Modify.Name = "btn_Anchor_Modify";
            this.btn_Anchor_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Modify.TabIndex = 31;
            this.btn_Anchor_Modify.Text = "Modify";
            this.btn_Anchor_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Anchor_Delete
            // 
            this.btn_Anchor_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Anchor_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Anchor_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Anchor_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Anchor_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Delete.Name = "btn_Anchor_Delete";
            this.btn_Anchor_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Anchor_Delete.TabIndex = 32;
            this.btn_Anchor_Delete.Text = "Delete";
            this.btn_Anchor_Delete.UseVisualStyleBackColor = true;
            // 
            // Page_Camera
            // 
            this.Page_Camera.Controls.Add(this.panel6);
            this.Page_Camera.Controls.Add(this.panel2);
            this.Page_Camera.Location = new System.Drawing.Point(4, 34);
            this.Page_Camera.Name = "Page_Camera";
            this.Page_Camera.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Camera.Size = new System.Drawing.Size(1018, 617);
            this.Page_Camera.TabIndex = 3;
            this.Page_Camera.Text = "摄像头管理";
            this.Page_Camera.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listView3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 527);
            this.panel6.TabIndex = 31;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader35});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1018, 527);
            this.listView3.SmallImageList = this.LineHeight;
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "序号";
            this.columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "摄像头名称";
            this.columnHeader20.Width = 87;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "连接类型";
            this.columnHeader21.Width = 83;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "连接参数";
            this.columnHeader22.Width = 136;
            // 
            // columnHeader23
            // 
            this.columnHeader23.DisplayIndex = 5;
            this.columnHeader23.Text = "设备类型";
            this.columnHeader23.Width = 104;
            // 
            // columnHeader24
            // 
            this.columnHeader24.DisplayIndex = 6;
            this.columnHeader24.Text = "安全等级";
            this.columnHeader24.Width = 124;
            // 
            // columnHeader25
            // 
            this.columnHeader25.DisplayIndex = 4;
            this.columnHeader25.Text = "网络状态";
            this.columnHeader25.Width = 89;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "序列号";
            this.columnHeader35.Width = 74;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Camera_Add);
            this.panel2.Controls.Add(this.btn_Camera_Modify);
            this.panel2.Controls.Add(this.btn_Camera_Delete);
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 88);
            this.panel2.TabIndex = 36;
            // 
            // btn_Camera_Add
            // 
            this.btn_Camera_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Camera_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Camera_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_Camera_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Camera_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Camera_Add.Name = "btn_Camera_Add";
            this.btn_Camera_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_Camera_Add.TabIndex = 30;
            this.btn_Camera_Add.Text = "Add";
            this.btn_Camera_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Camera_Modify
            // 
            this.btn_Camera_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Camera_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Camera_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_Camera_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Camera_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Camera_Modify.Name = "btn_Camera_Modify";
            this.btn_Camera_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_Camera_Modify.TabIndex = 31;
            this.btn_Camera_Modify.Text = "Modify";
            this.btn_Camera_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Camera_Delete
            // 
            this.btn_Camera_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Camera_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Camera_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Camera_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Camera_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Camera_Delete.Name = "btn_Camera_Delete";
            this.btn_Camera_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Camera_Delete.TabIndex = 32;
            this.btn_Camera_Delete.Text = "Delete";
            this.btn_Camera_Delete.UseVisualStyleBackColor = true;
            // 
            // Page_Map_M
            // 
            this.Page_Map_M.Controls.Add(this.panel12);
            this.Page_Map_M.Controls.Add(this.panel11);
            this.Page_Map_M.Location = new System.Drawing.Point(4, 34);
            this.Page_Map_M.Name = "Page_Map_M";
            this.Page_Map_M.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Map_M.Size = new System.Drawing.Size(1018, 617);
            this.Page_Map_M.TabIndex = 9;
            this.Page_Map_M.Text = "地图管理";
            this.Page_Map_M.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lv_Map_M);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1018, 527);
            this.panel12.TabIndex = 38;
            // 
            // lv_Map_M
            // 
            this.lv_Map_M.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader36,
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41});
            this.lv_Map_M.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Map_M.FullRowSelect = true;
            this.lv_Map_M.GridLines = true;
            this.lv_Map_M.Location = new System.Drawing.Point(0, 0);
            this.lv_Map_M.Name = "lv_Map_M";
            this.lv_Map_M.Size = new System.Drawing.Size(1018, 527);
            this.lv_Map_M.SmallImageList = this.LineHeight;
            this.lv_Map_M.TabIndex = 1;
            this.lv_Map_M.UseCompatibleStateImageBehavior = false;
            this.lv_Map_M.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "序号";
            this.columnHeader36.Width = 100;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "地图ID";
            this.columnHeader37.Width = 87;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "地图地址";
            this.columnHeader38.Width = 83;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "图层名称";
            this.columnHeader39.Width = 136;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "地图名称";
            this.columnHeader40.Width = 104;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "排序";
            this.columnHeader41.Width = 124;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_Map_Add);
            this.panel11.Controls.Add(this.btn_Map_Modify);
            this.panel11.Controls.Add(this.btn_Map_Delete);
            this.panel11.Location = new System.Drawing.Point(0, 533);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1018, 88);
            this.panel11.TabIndex = 37;
            // 
            // btn_Map_Add
            // 
            this.btn_Map_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Map_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Map_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_Map_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Map_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Map_Add.Name = "btn_Map_Add";
            this.btn_Map_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_Map_Add.TabIndex = 30;
            this.btn_Map_Add.Text = "Add";
            this.btn_Map_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Map_Modify
            // 
            this.btn_Map_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Map_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Map_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_Map_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Map_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Map_Modify.Name = "btn_Map_Modify";
            this.btn_Map_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_Map_Modify.TabIndex = 31;
            this.btn_Map_Modify.Text = "Modify";
            this.btn_Map_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_Map_Delete
            // 
            this.btn_Map_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_Map_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Map_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_Map_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_Map_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_Map_Delete.Name = "btn_Map_Delete";
            this.btn_Map_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_Map_Delete.TabIndex = 32;
            this.btn_Map_Delete.Text = "Delete";
            this.btn_Map_Delete.UseVisualStyleBackColor = true;
            // 
            // Page_History
            // 
            this.Page_History.Controls.Add(this.pb_History_Tag2);
            this.Page_History.Controls.Add(this.pb_History_Tag1);
            this.Page_History.Controls.Add(this.pb_History_Map);
            this.Page_History.Controls.Add(this.panel_Map_Zoom_History);
            this.Page_History.Controls.Add(this.panel9);
            this.Page_History.Controls.Add(this.pb_History_Grid);
            this.Page_History.Location = new System.Drawing.Point(4, 34);
            this.Page_History.Name = "Page_History";
            this.Page_History.Padding = new System.Windows.Forms.Padding(3);
            this.Page_History.Size = new System.Drawing.Size(1018, 617);
            this.Page_History.TabIndex = 4;
            this.Page_History.Text = "统计分析";
            this.Page_History.UseVisualStyleBackColor = true;
            // 
            // pb_History_Tag2
            // 
            this.pb_History_Tag2.BackColor = System.Drawing.Color.Transparent;
            this.pb_History_Tag2.Location = new System.Drawing.Point(553, 219);
            this.pb_History_Tag2.Margin = new System.Windows.Forms.Padding(0);
            this.pb_History_Tag2.Name = "pb_History_Tag2";
            this.pb_History_Tag2.Size = new System.Drawing.Size(30, 42);
            this.pb_History_Tag2.TabIndex = 47;
            this.pb_History_Tag2.TabStop = false;
            // 
            // pb_History_Tag1
            // 
            this.pb_History_Tag1.BackColor = System.Drawing.Color.Transparent;
            this.pb_History_Tag1.Location = new System.Drawing.Point(325, 219);
            this.pb_History_Tag1.Margin = new System.Windows.Forms.Padding(0);
            this.pb_History_Tag1.Name = "pb_History_Tag1";
            this.pb_History_Tag1.Size = new System.Drawing.Size(30, 41);
            this.pb_History_Tag1.TabIndex = 46;
            this.pb_History_Tag1.TabStop = false;
            // 
            // pb_History_Map
            // 
            this.pb_History_Map.Location = new System.Drawing.Point(275, 73);
            this.pb_History_Map.Name = "pb_History_Map";
            this.pb_History_Map.Size = new System.Drawing.Size(471, 545);
            this.pb_History_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_History_Map.TabIndex = 45;
            this.pb_History_Map.TabStop = false;
            // 
            // panel_Map_Zoom_History
            // 
            this.panel_Map_Zoom_History.BackColor = System.Drawing.Color.White;
            this.panel_Map_Zoom_History.Controls.Add(this.btn_History_ZoomNormal);
            this.panel_Map_Zoom_History.Controls.Add(this.btn_History_ZoomFull);
            this.panel_Map_Zoom_History.Controls.Add(this.btn_History_ZoomOut);
            this.panel_Map_Zoom_History.Controls.Add(this.btn_History_ZoomIn);
            this.panel_Map_Zoom_History.Controls.Add(this.Trackbar_H_Map);
            this.panel_Map_Zoom_History.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Map_Zoom_History.Location = new System.Drawing.Point(112, 104);
            this.panel_Map_Zoom_History.Name = "panel_Map_Zoom_History";
            this.panel_Map_Zoom_History.Size = new System.Drawing.Size(88, 240);
            this.panel_Map_Zoom_History.TabIndex = 44;
            // 
            // btn_History_ZoomNormal
            // 
            this.btn_History_ZoomNormal.Location = new System.Drawing.Point(4, 172);
            this.btn_History_ZoomNormal.Name = "btn_History_ZoomNormal";
            this.btn_History_ZoomNormal.Size = new System.Drawing.Size(41, 33);
            this.btn_History_ZoomNormal.TabIndex = 4;
            this.btn_History_ZoomNormal.Text = "1:1";
            this.btn_History_ZoomNormal.UseVisualStyleBackColor = true;
            // 
            // btn_History_ZoomFull
            // 
            this.btn_History_ZoomFull.Location = new System.Drawing.Point(4, 133);
            this.btn_History_ZoomFull.Name = "btn_History_ZoomFull";
            this.btn_History_ZoomFull.Size = new System.Drawing.Size(41, 33);
            this.btn_History_ZoomFull.TabIndex = 4;
            this.btn_History_ZoomFull.Text = "Full";
            this.btn_History_ZoomFull.UseVisualStyleBackColor = true;
            // 
            // btn_History_ZoomOut
            // 
            this.btn_History_ZoomOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_History_ZoomOut.Location = new System.Drawing.Point(4, 75);
            this.btn_History_ZoomOut.Name = "btn_History_ZoomOut";
            this.btn_History_ZoomOut.Size = new System.Drawing.Size(41, 33);
            this.btn_History_ZoomOut.TabIndex = 4;
            this.btn_History_ZoomOut.Text = "-";
            this.btn_History_ZoomOut.UseVisualStyleBackColor = true;
            // 
            // btn_History_ZoomIn
            // 
            this.btn_History_ZoomIn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_History_ZoomIn.Location = new System.Drawing.Point(4, 26);
            this.btn_History_ZoomIn.Name = "btn_History_ZoomIn";
            this.btn_History_ZoomIn.Size = new System.Drawing.Size(41, 33);
            this.btn_History_ZoomIn.TabIndex = 4;
            this.btn_History_ZoomIn.Text = "+";
            this.btn_History_ZoomIn.UseVisualStyleBackColor = true;
            // 
            // Trackbar_H_Map
            // 
            this.Trackbar_H_Map.Location = new System.Drawing.Point(51, 3);
            this.Trackbar_H_Map.Name = "Trackbar_H_Map";
            this.Trackbar_H_Map.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Trackbar_H_Map.Size = new System.Drawing.Size(45, 232);
            this.Trackbar_H_Map.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtp_History_Stop);
            this.panel9.Controls.Add(this.dtp_History_Start);
            this.panel9.Controls.Add(this.Trackbar_H_Play);
            this.panel9.Controls.Add(this.cb_SelectTag);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.btn_History_Start);
            this.panel9.Controls.Add(this.btn_History_Stop);
            this.panel9.Controls.Add(this.btn_History_ShowFence);
            this.panel9.Controls.Add(this.btn_History_DrawFence);
            this.panel9.Controls.Add(this.btn_History_ShowAnchor);
            this.panel9.Controls.Add(this.btn_History_Rotate2);
            this.panel9.Controls.Add(this.btn_History_Rotate1);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1022, 67);
            this.panel9.TabIndex = 43;
            // 
            // dtp_History_Stop
            // 
            this.dtp_History_Stop.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_History_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_History_Stop.Location = new System.Drawing.Point(831, 14);
            this.dtp_History_Stop.Name = "dtp_History_Stop";
            this.dtp_History_Stop.Size = new System.Drawing.Size(181, 21);
            this.dtp_History_Stop.TabIndex = 52;
            // 
            // dtp_History_Start
            // 
            this.dtp_History_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_History_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_History_Start.Location = new System.Drawing.Point(632, 14);
            this.dtp_History_Start.Name = "dtp_History_Start";
            this.dtp_History_Start.Size = new System.Drawing.Size(181, 21);
            this.dtp_History_Start.TabIndex = 51;
            // 
            // Trackbar_H_Play
            // 
            this.Trackbar_H_Play.Location = new System.Drawing.Point(100, 41);
            this.Trackbar_H_Play.Name = "Trackbar_H_Play";
            this.Trackbar_H_Play.Size = new System.Drawing.Size(713, 45);
            this.Trackbar_H_Play.TabIndex = 50;
            // 
            // cb_SelectTag
            // 
            this.cb_SelectTag.FormattingEnabled = true;
            this.cb_SelectTag.Location = new System.Drawing.Point(544, 15);
            this.cb_SelectTag.Name = "cb_SelectTag";
            this.cb_SelectTag.Size = new System.Drawing.Size(72, 20);
            this.cb_SelectTag.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(816, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "-";
            // 
            // btn_History_Start
            // 
            this.btn_History_Start.Location = new System.Drawing.Point(831, 41);
            this.btn_History_Start.Name = "btn_History_Start";
            this.btn_History_Start.Size = new System.Drawing.Size(68, 23);
            this.btn_History_Start.TabIndex = 1;
            this.btn_History_Start.Text = "开始回放";
            this.btn_History_Start.UseVisualStyleBackColor = true;
            // 
            // btn_History_Stop
            // 
            this.btn_History_Stop.Location = new System.Drawing.Point(930, 41);
            this.btn_History_Stop.Name = "btn_History_Stop";
            this.btn_History_Stop.Size = new System.Drawing.Size(68, 23);
            this.btn_History_Stop.TabIndex = 1;
            this.btn_History_Stop.Text = "暂停回放";
            this.btn_History_Stop.UseVisualStyleBackColor = true;
            // 
            // btn_History_ShowFence
            // 
            this.btn_History_ShowFence.Location = new System.Drawing.Point(456, 14);
            this.btn_History_ShowFence.Name = "btn_History_ShowFence";
            this.btn_History_ShowFence.Size = new System.Drawing.Size(75, 23);
            this.btn_History_ShowFence.TabIndex = 1;
            this.btn_History_ShowFence.Text = "显示围栏";
            this.btn_History_ShowFence.UseVisualStyleBackColor = true;
            // 
            // btn_History_DrawFence
            // 
            this.btn_History_DrawFence.Location = new System.Drawing.Point(372, 14);
            this.btn_History_DrawFence.Name = "btn_History_DrawFence";
            this.btn_History_DrawFence.Size = new System.Drawing.Size(75, 23);
            this.btn_History_DrawFence.TabIndex = 1;
            this.btn_History_DrawFence.Text = "添加围栏";
            this.btn_History_DrawFence.UseVisualStyleBackColor = true;
            // 
            // btn_History_ShowAnchor
            // 
            this.btn_History_ShowAnchor.Location = new System.Drawing.Point(284, 14);
            this.btn_History_ShowAnchor.Name = "btn_History_ShowAnchor";
            this.btn_History_ShowAnchor.Size = new System.Drawing.Size(75, 23);
            this.btn_History_ShowAnchor.TabIndex = 1;
            this.btn_History_ShowAnchor.Text = "显示基站";
            this.btn_History_ShowAnchor.UseVisualStyleBackColor = true;
            // 
            // btn_History_Rotate2
            // 
            this.btn_History_Rotate2.Location = new System.Drawing.Point(192, 14);
            this.btn_History_Rotate2.Name = "btn_History_Rotate2";
            this.btn_History_Rotate2.Size = new System.Drawing.Size(75, 23);
            this.btn_History_Rotate2.TabIndex = 1;
            this.btn_History_Rotate2.Text = "逆时针转";
            this.btn_History_Rotate2.UseVisualStyleBackColor = true;
            // 
            // btn_History_Rotate1
            // 
            this.btn_History_Rotate1.Location = new System.Drawing.Point(100, 14);
            this.btn_History_Rotate1.Name = "btn_History_Rotate1";
            this.btn_History_Rotate1.Size = new System.Drawing.Size(75, 23);
            this.btn_History_Rotate1.TabIndex = 1;
            this.btn_History_Rotate1.Text = "顺时针转";
            this.btn_History_Rotate1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X,Y";
            // 
            // pb_History_Grid
            // 
            this.pb_History_Grid.Location = new System.Drawing.Point(0, -5);
            this.pb_History_Grid.Name = "pb_History_Grid";
            this.pb_History_Grid.Size = new System.Drawing.Size(1018, 631);
            this.pb_History_Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_History_Grid.TabIndex = 2;
            this.pb_History_Grid.TabStop = false;
            // 
            // Page_User
            // 
            this.Page_User.Controls.Add(this.panel14);
            this.Page_User.Controls.Add(this.panel13);
            this.Page_User.Location = new System.Drawing.Point(4, 34);
            this.Page_User.Name = "Page_User";
            this.Page_User.Padding = new System.Windows.Forms.Padding(3);
            this.Page_User.Size = new System.Drawing.Size(1018, 617);
            this.Page_User.TabIndex = 10;
            this.Page_User.Tag = "Users";
            this.Page_User.Text = "用户管理";
            this.Page_User.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button6);
            this.panel14.Controls.Add(this.button4);
            this.panel14.Controls.Add(this.btn_User_Add);
            this.panel14.Controls.Add(this.btn_User_Modify);
            this.panel14.Controls.Add(this.btn_User_Delete);
            this.panel14.Location = new System.Drawing.Point(0, 533);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1018, 88);
            this.panel14.TabIndex = 37;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(769, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(754, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_User_Add
            // 
            this.btn_User_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_User_Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_User_Add.Location = new System.Drawing.Point(322, 25);
            this.btn_User_Add.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_User_Add.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_User_Add.Name = "btn_User_Add";
            this.btn_User_Add.Size = new System.Drawing.Size(107, 31);
            this.btn_User_Add.TabIndex = 30;
            this.btn_User_Add.Text = "Add";
            this.btn_User_Add.UseVisualStyleBackColor = true;
            this.btn_User_Add.Click += new System.EventHandler(this.btn_User_Add_Click);
            // 
            // btn_User_Modify
            // 
            this.btn_User_Modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_User_Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_User_Modify.Location = new System.Drawing.Point(600, 25);
            this.btn_User_Modify.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_User_Modify.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_User_Modify.Name = "btn_User_Modify";
            this.btn_User_Modify.Size = new System.Drawing.Size(107, 31);
            this.btn_User_Modify.TabIndex = 31;
            this.btn_User_Modify.Text = "Modify";
            this.btn_User_Modify.UseVisualStyleBackColor = true;
            this.btn_User_Modify.Click += new System.EventHandler(this.btn_User_Modify_Click);
            // 
            // btn_User_Delete
            // 
            this.btn_User_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_User_Delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_User_Delete.Location = new System.Drawing.Point(463, 25);
            this.btn_User_Delete.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btn_User_Delete.MaximumSize = new System.Drawing.Size(107, 31);
            this.btn_User_Delete.Name = "btn_User_Delete";
            this.btn_User_Delete.Size = new System.Drawing.Size(107, 31);
            this.btn_User_Delete.TabIndex = 32;
            this.btn_User_Delete.Text = "Delete";
            this.btn_User_Delete.UseVisualStyleBackColor = true;
            this.btn_User_Delete.Click += new System.EventHandler(this.btn_User_Delete_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button5);
            this.panel13.Controls.Add(this.button3);
            this.panel13.Controls.Add(this.lv_User);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1018, 527);
            this.panel13.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(522, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(863, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lv_User
            // 
            this.lv_User.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader52,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader56});
            this.lv_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_User.FullRowSelect = true;
            this.lv_User.GridLines = true;
            this.lv_User.Location = new System.Drawing.Point(0, 0);
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(1018, 527);
            this.lv_User.SmallImageList = this.LineHeight;
            this.lv_User.TabIndex = 1;
            this.lv_User.Tag = "Users_list";
            this.lv_User.UseCompatibleStateImageBehavior = false;
            this.lv_User.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "序号";
            this.columnHeader46.Width = 100;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "角色名称";
            this.columnHeader47.Width = 87;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "用户名";
            this.columnHeader48.Width = 83;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "密码";
            this.columnHeader49.Width = 104;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "描述";
            this.columnHeader52.Width = 128;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "权限等级";
            this.columnHeader50.Width = 124;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "创建时间";
            this.columnHeader51.Width = 127;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "修改时间";
            this.columnHeader56.Width = 137;
            // 
            // Page_System
            // 
            this.Page_System.Controls.Add(this.btn_System_Set);
            this.Page_System.Location = new System.Drawing.Point(4, 34);
            this.Page_System.Name = "Page_System";
            this.Page_System.Padding = new System.Windows.Forms.Padding(3);
            this.Page_System.Size = new System.Drawing.Size(1018, 617);
            this.Page_System.TabIndex = 5;
            this.Page_System.Text = "系统设置";
            this.Page_System.UseVisualStyleBackColor = true;
            // 
            // btn_System_Set
            // 
            this.btn_System_Set.Location = new System.Drawing.Point(81, 53);
            this.btn_System_Set.Name = "btn_System_Set";
            this.btn_System_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_System_Set.TabIndex = 0;
            this.btn_System_Set.Text = "通用设置";
            this.btn_System_Set.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 617);
            this.tabPage1.TabIndex = 11;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1012, 611);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.TagPicture2);
            this.tabPage2.Controls.Add(this.TagPicture1);
            this.tabPage2.Controls.Add(this.xy_mouse);
            this.tabPage2.Controls.Add(this.Z_Tag2);
            this.tabPage2.Controls.Add(this.X_mouse);
            this.tabPage2.Controls.Add(this.Y_mouse);
            this.tabPage2.Controls.Add(this.Y_Tag2);
            this.tabPage2.Controls.Add(this.label_Mouse);
            this.tabPage2.Controls.Add(this.Xbox_mouse);
            this.tabPage2.Controls.Add(this.Z_Tag1);
            this.tabPage2.Controls.Add(this.ybox_local);
            this.tabPage2.Controls.Add(this.xbox_local);
            this.tabPage2.Controls.Add(this.X_Tag2);
            this.tabPage2.Controls.Add(this.Ybox_mouse);
            this.tabPage2.Controls.Add(this.Y_Tag1);
            this.tabPage2.Controls.Add(this.label_Tag1);
            this.tabPage2.Controls.Add(this.label_Tag2);
            this.tabPage2.Controls.Add(this.X_Tag1);
            this.tabPage2.Controls.Add(this.ID_Tag2);
            this.tabPage2.Controls.Add(this.btn_SM);
            this.tabPage2.Controls.Add(this.ID_Tag1);
            this.tabPage2.Controls.Add(this.btn_SZ);
            this.tabPage2.Controls.Add(this.mapbox);
            this.tabPage2.Controls.Add(this.panel_tag);
            this.tabPage2.Controls.Add(this.textBox_msg);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.lsvReceviedMsg);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 617);
            this.tabPage2.TabIndex = 12;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TagPicture2
            // 
            this.TagPicture2.BackColor = System.Drawing.Color.Transparent;
            this.TagPicture2.Image = global::UWBclient_demo.Properties.Resources.tag3;
            this.TagPicture2.Location = new System.Drawing.Point(771, 210);
            this.TagPicture2.Margin = new System.Windows.Forms.Padding(0);
            this.TagPicture2.Name = "TagPicture2";
            this.TagPicture2.Size = new System.Drawing.Size(20, 27);
            this.TagPicture2.TabIndex = 58;
            this.TagPicture2.TabStop = false;
            // 
            // TagPicture1
            // 
            this.TagPicture1.BackColor = System.Drawing.Color.Transparent;
            this.TagPicture1.Image = global::UWBclient_demo.Properties.Resources.tag1;
            this.TagPicture1.Location = new System.Drawing.Point(710, 190);
            this.TagPicture1.Margin = new System.Windows.Forms.Padding(0);
            this.TagPicture1.Name = "TagPicture1";
            this.TagPicture1.Size = new System.Drawing.Size(20, 27);
            this.TagPicture1.TabIndex = 57;
            this.TagPicture1.TabStop = false;
            // 
            // xy_mouse
            // 
            this.xy_mouse.AutoSize = true;
            this.xy_mouse.Location = new System.Drawing.Point(692, 487);
            this.xy_mouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xy_mouse.Name = "xy_mouse";
            this.xy_mouse.Size = new System.Drawing.Size(17, 12);
            this.xy_mouse.TabIndex = 48;
            this.xy_mouse.Text = "xy";
            // 
            // Z_Tag2
            // 
            this.Z_Tag2.AutoSize = true;
            this.Z_Tag2.Location = new System.Drawing.Point(881, 512);
            this.Z_Tag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Z_Tag2.Name = "Z_Tag2";
            this.Z_Tag2.Size = new System.Drawing.Size(11, 12);
            this.Z_Tag2.TabIndex = 64;
            this.Z_Tag2.Text = "Z";
            // 
            // X_mouse
            // 
            this.X_mouse.AutoSize = true;
            this.X_mouse.Location = new System.Drawing.Point(696, 437);
            this.X_mouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X_mouse.Name = "X_mouse";
            this.X_mouse.Size = new System.Drawing.Size(11, 12);
            this.X_mouse.TabIndex = 44;
            this.X_mouse.Text = "X";
            // 
            // Y_mouse
            // 
            this.Y_mouse.AutoSize = true;
            this.Y_mouse.Location = new System.Drawing.Point(696, 462);
            this.Y_mouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y_mouse.Name = "Y_mouse";
            this.Y_mouse.Size = new System.Drawing.Size(11, 12);
            this.Y_mouse.TabIndex = 46;
            this.Y_mouse.Text = "Y";
            // 
            // Y_Tag2
            // 
            this.Y_Tag2.AutoSize = true;
            this.Y_Tag2.Location = new System.Drawing.Point(881, 487);
            this.Y_Tag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y_Tag2.Name = "Y_Tag2";
            this.Y_Tag2.Size = new System.Drawing.Size(11, 12);
            this.Y_Tag2.TabIndex = 63;
            this.Y_Tag2.Text = "Y";
            // 
            // label_Mouse
            // 
            this.label_Mouse.AutoSize = true;
            this.label_Mouse.Location = new System.Drawing.Point(708, 420);
            this.label_Mouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Mouse.Name = "label_Mouse";
            this.label_Mouse.Size = new System.Drawing.Size(41, 12);
            this.label_Mouse.TabIndex = 43;
            this.label_Mouse.Text = "Mouse:";
            // 
            // Xbox_mouse
            // 
            this.Xbox_mouse.Location = new System.Drawing.Point(710, 435);
            this.Xbox_mouse.Margin = new System.Windows.Forms.Padding(2);
            this.Xbox_mouse.Name = "Xbox_mouse";
            this.Xbox_mouse.ReadOnly = true;
            this.Xbox_mouse.Size = new System.Drawing.Size(60, 21);
            this.Xbox_mouse.TabIndex = 45;
            this.Xbox_mouse.Text = "0";
            // 
            // Z_Tag1
            // 
            this.Z_Tag1.AutoSize = true;
            this.Z_Tag1.Location = new System.Drawing.Point(798, 512);
            this.Z_Tag1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Z_Tag1.Name = "Z_Tag1";
            this.Z_Tag1.Size = new System.Drawing.Size(11, 12);
            this.Z_Tag1.TabIndex = 59;
            this.Z_Tag1.Text = "Z";
            // 
            // ybox_local
            // 
            this.ybox_local.Location = new System.Drawing.Point(741, 484);
            this.ybox_local.Margin = new System.Windows.Forms.Padding(2);
            this.ybox_local.Name = "ybox_local";
            this.ybox_local.ReadOnly = true;
            this.ybox_local.Size = new System.Drawing.Size(30, 21);
            this.ybox_local.TabIndex = 50;
            this.ybox_local.Text = "0";
            // 
            // xbox_local
            // 
            this.xbox_local.Location = new System.Drawing.Point(710, 484);
            this.xbox_local.Margin = new System.Windows.Forms.Padding(2);
            this.xbox_local.Name = "xbox_local";
            this.xbox_local.ReadOnly = true;
            this.xbox_local.Size = new System.Drawing.Size(30, 21);
            this.xbox_local.TabIndex = 49;
            this.xbox_local.Text = "0";
            // 
            // X_Tag2
            // 
            this.X_Tag2.AutoSize = true;
            this.X_Tag2.Location = new System.Drawing.Point(881, 462);
            this.X_Tag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X_Tag2.Name = "X_Tag2";
            this.X_Tag2.Size = new System.Drawing.Size(11, 12);
            this.X_Tag2.TabIndex = 62;
            this.X_Tag2.Text = "X";
            // 
            // Ybox_mouse
            // 
            this.Ybox_mouse.Location = new System.Drawing.Point(710, 460);
            this.Ybox_mouse.Margin = new System.Windows.Forms.Padding(2);
            this.Ybox_mouse.Name = "Ybox_mouse";
            this.Ybox_mouse.ReadOnly = true;
            this.Ybox_mouse.Size = new System.Drawing.Size(60, 21);
            this.Ybox_mouse.TabIndex = 47;
            this.Ybox_mouse.Text = "0";
            // 
            // Y_Tag1
            // 
            this.Y_Tag1.AutoSize = true;
            this.Y_Tag1.Location = new System.Drawing.Point(798, 487);
            this.Y_Tag1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y_Tag1.Name = "Y_Tag1";
            this.Y_Tag1.Size = new System.Drawing.Size(11, 12);
            this.Y_Tag1.TabIndex = 56;
            this.Y_Tag1.Text = "Y";
            // 
            // label_Tag1
            // 
            this.label_Tag1.AutoSize = true;
            this.label_Tag1.Location = new System.Drawing.Point(813, 420);
            this.label_Tag1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tag1.Name = "label_Tag1";
            this.label_Tag1.Size = new System.Drawing.Size(35, 12);
            this.label_Tag1.TabIndex = 53;
            this.label_Tag1.Text = "Tag1:";
            // 
            // label_Tag2
            // 
            this.label_Tag2.AutoSize = true;
            this.label_Tag2.Location = new System.Drawing.Point(897, 420);
            this.label_Tag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Tag2.Name = "label_Tag2";
            this.label_Tag2.Size = new System.Drawing.Size(35, 12);
            this.label_Tag2.TabIndex = 60;
            this.label_Tag2.Text = "Tag2:";
            // 
            // X_Tag1
            // 
            this.X_Tag1.AutoSize = true;
            this.X_Tag1.Location = new System.Drawing.Point(798, 462);
            this.X_Tag1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X_Tag1.Name = "X_Tag1";
            this.X_Tag1.Size = new System.Drawing.Size(11, 12);
            this.X_Tag1.TabIndex = 55;
            this.X_Tag1.Text = "X";
            // 
            // ID_Tag2
            // 
            this.ID_Tag2.AutoSize = true;
            this.ID_Tag2.Location = new System.Drawing.Point(878, 437);
            this.ID_Tag2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_Tag2.Name = "ID_Tag2";
            this.ID_Tag2.Size = new System.Drawing.Size(17, 12);
            this.ID_Tag2.TabIndex = 61;
            this.ID_Tag2.Text = "ID";
            // 
            // btn_SM
            // 
            this.btn_SM.Location = new System.Drawing.Point(737, 513);
            this.btn_SM.Name = "btn_SM";
            this.btn_SM.Size = new System.Drawing.Size(54, 20);
            this.btn_SM.TabIndex = 52;
            this.btn_SM.Text = "SetMax";
            this.btn_SM.UseVisualStyleBackColor = true;
            this.btn_SM.Click += new System.EventHandler(this.btn_SM_Click);
            // 
            // ID_Tag1
            // 
            this.ID_Tag1.AutoSize = true;
            this.ID_Tag1.Location = new System.Drawing.Point(793, 437);
            this.ID_Tag1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_Tag1.Name = "ID_Tag1";
            this.ID_Tag1.Size = new System.Drawing.Size(17, 12);
            this.ID_Tag1.TabIndex = 54;
            this.ID_Tag1.Text = "ID";
            // 
            // btn_SZ
            // 
            this.btn_SZ.Location = new System.Drawing.Point(671, 513);
            this.btn_SZ.Name = "btn_SZ";
            this.btn_SZ.Size = new System.Drawing.Size(60, 20);
            this.btn_SZ.TabIndex = 51;
            this.btn_SZ.Text = "SetZero";
            this.btn_SZ.UseVisualStyleBackColor = true;
            this.btn_SZ.Click += new System.EventHandler(this.btn_SZ_Click);
            // 
            // mapbox
            // 
            this.mapbox.Image = ((System.Drawing.Image)(resources.GetObject("mapbox.Image")));
            this.mapbox.Location = new System.Drawing.Point(668, 54);
            this.mapbox.Margin = new System.Windows.Forms.Padding(2);
            this.mapbox.Name = "mapbox";
            this.mapbox.Size = new System.Drawing.Size(301, 336);
            this.mapbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mapbox.TabIndex = 42;
            this.mapbox.TabStop = false;
            this.mapbox.Click += new System.EventHandler(this.mapbox_Click);
            // 
            // panel_tag
            // 
            this.panel_tag.Controls.Add(this.IDbox_Tag1);
            this.panel_tag.Controls.Add(this.Xbox_Tag1);
            this.panel_tag.Controls.Add(this.Ybox_Tag1);
            this.panel_tag.Controls.Add(this.Zbox_Tag1);
            this.panel_tag.Controls.Add(this.IDbox_Tag2);
            this.panel_tag.Controls.Add(this.Xbox_Tag2);
            this.panel_tag.Controls.Add(this.Ybox_Tag2);
            this.panel_tag.Controls.Add(this.Zbox_Tag2);
            this.panel_tag.Location = new System.Drawing.Point(811, 432);
            this.panel_tag.Name = "panel_tag";
            this.panel_tag.Size = new System.Drawing.Size(147, 101);
            this.panel_tag.TabIndex = 65;
            // 
            // IDbox_Tag1
            // 
            this.IDbox_Tag1.Location = new System.Drawing.Point(3, 2);
            this.IDbox_Tag1.Margin = new System.Windows.Forms.Padding(2);
            this.IDbox_Tag1.Name = "IDbox_Tag1";
            this.IDbox_Tag1.ReadOnly = true;
            this.IDbox_Tag1.Size = new System.Drawing.Size(60, 21);
            this.IDbox_Tag1.TabIndex = 24;
            this.IDbox_Tag1.Tag = "1";
            this.IDbox_Tag1.Text = "0000";
            // 
            // Xbox_Tag1
            // 
            this.Xbox_Tag1.Location = new System.Drawing.Point(2, 27);
            this.Xbox_Tag1.Margin = new System.Windows.Forms.Padding(2);
            this.Xbox_Tag1.Name = "Xbox_Tag1";
            this.Xbox_Tag1.ReadOnly = true;
            this.Xbox_Tag1.Size = new System.Drawing.Size(60, 21);
            this.Xbox_Tag1.TabIndex = 26;
            this.Xbox_Tag1.Tag = "2";
            this.Xbox_Tag1.Text = "0";
            // 
            // Ybox_Tag1
            // 
            this.Ybox_Tag1.Location = new System.Drawing.Point(2, 51);
            this.Ybox_Tag1.Margin = new System.Windows.Forms.Padding(2);
            this.Ybox_Tag1.Name = "Ybox_Tag1";
            this.Ybox_Tag1.ReadOnly = true;
            this.Ybox_Tag1.Size = new System.Drawing.Size(60, 21);
            this.Ybox_Tag1.TabIndex = 28;
            this.Ybox_Tag1.Tag = "3";
            this.Ybox_Tag1.Text = "0";
            // 
            // Zbox_Tag1
            // 
            this.Zbox_Tag1.Location = new System.Drawing.Point(2, 76);
            this.Zbox_Tag1.Margin = new System.Windows.Forms.Padding(2);
            this.Zbox_Tag1.Name = "Zbox_Tag1";
            this.Zbox_Tag1.ReadOnly = true;
            this.Zbox_Tag1.Size = new System.Drawing.Size(60, 21);
            this.Zbox_Tag1.TabIndex = 30;
            this.Zbox_Tag1.Tag = "4";
            this.Zbox_Tag1.Text = "0";
            // 
            // IDbox_Tag2
            // 
            this.IDbox_Tag2.Location = new System.Drawing.Point(84, 2);
            this.IDbox_Tag2.Margin = new System.Windows.Forms.Padding(2);
            this.IDbox_Tag2.Name = "IDbox_Tag2";
            this.IDbox_Tag2.ReadOnly = true;
            this.IDbox_Tag2.Size = new System.Drawing.Size(60, 21);
            this.IDbox_Tag2.TabIndex = 33;
            this.IDbox_Tag2.Tag = "5";
            this.IDbox_Tag2.Text = "0000";
            // 
            // Xbox_Tag2
            // 
            this.Xbox_Tag2.Location = new System.Drawing.Point(84, 26);
            this.Xbox_Tag2.Margin = new System.Windows.Forms.Padding(2);
            this.Xbox_Tag2.Name = "Xbox_Tag2";
            this.Xbox_Tag2.ReadOnly = true;
            this.Xbox_Tag2.Size = new System.Drawing.Size(60, 21);
            this.Xbox_Tag2.TabIndex = 35;
            this.Xbox_Tag2.Tag = "6";
            this.Xbox_Tag2.Text = "0";
            // 
            // Ybox_Tag2
            // 
            this.Ybox_Tag2.Location = new System.Drawing.Point(84, 51);
            this.Ybox_Tag2.Margin = new System.Windows.Forms.Padding(2);
            this.Ybox_Tag2.Name = "Ybox_Tag2";
            this.Ybox_Tag2.ReadOnly = true;
            this.Ybox_Tag2.Size = new System.Drawing.Size(60, 21);
            this.Ybox_Tag2.TabIndex = 37;
            this.Ybox_Tag2.Tag = "7";
            this.Ybox_Tag2.Text = "0";
            // 
            // Zbox_Tag2
            // 
            this.Zbox_Tag2.Location = new System.Drawing.Point(84, 75);
            this.Zbox_Tag2.Margin = new System.Windows.Forms.Padding(2);
            this.Zbox_Tag2.Name = "Zbox_Tag2";
            this.Zbox_Tag2.ReadOnly = true;
            this.Zbox_Tag2.Size = new System.Drawing.Size(60, 21);
            this.Zbox_Tag2.TabIndex = 39;
            this.Zbox_Tag2.Tag = "8";
            this.Zbox_Tag2.Text = "0";
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(313, 578);
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(408, 21);
            this.textBox_msg.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "发送的文本：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(740, 578);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsvReceviedMsg
            // 
            this.lsvReceviedMsg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55});
            this.lsvReceviedMsg.FullRowSelect = true;
            this.lsvReceviedMsg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvReceviedMsg.Location = new System.Drawing.Point(3, 17);
            this.lsvReceviedMsg.Name = "lsvReceviedMsg";
            this.lsvReceviedMsg.ShowItemToolTips = true;
            this.lsvReceviedMsg.Size = new System.Drawing.Size(632, 552);
            this.lsvReceviedMsg.TabIndex = 12;
            this.lsvReceviedMsg.UseCompatibleStateImageBehavior = false;
            this.lsvReceviedMsg.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "时间";
            this.columnHeader53.Width = 160;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "数据类型";
            this.columnHeader54.Width = 80;
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "消息内容";
            this.columnHeader55.Width = 800;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxPassword);
            this.tabPage3.Controls.Add(this.textBoxUserName);
            this.tabPage3.Controls.Add(this.textBoxPort);
            this.tabPage3.Controls.Add(this.textBoxIP);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1018, 617);
            this.tabPage3.TabIndex = 13;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(298, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 24;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(76, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "用户名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(296, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 22;
            this.label6.Text = "设备端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(74, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "设备IP";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPassword.Location = new System.Drawing.Point(370, 108);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(112, 23);
            this.textBoxPassword.TabIndex = 20;
            this.textBoxPassword.Text = "www123456";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUserName.Location = new System.Drawing.Point(140, 108);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(114, 23);
            this.textBoxUserName.TabIndex = 19;
            this.textBoxUserName.Text = "admin";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPort.Location = new System.Drawing.Point(370, 62);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(112, 23);
            this.textBoxPort.TabIndex = 18;
            this.textBoxPort.Text = "8000";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIP.Location = new System.Drawing.Point(140, 62);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(114, 23);
            this.textBoxIP.TabIndex = 17;
            this.textBoxIP.Text = "192.168.1.121";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(74, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Device IP";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(74, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "User Name";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(296, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(296, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Device Port";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1018, 617);
            this.tabPage4.TabIndex = 14;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(113, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 314);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "地图0";
            treeNode2.Name = "节点1";
            treeNode2.Text = "地图1";
            treeNode3.Name = "节点2";
            treeNode3.Text = "地图2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(137, 353);
            this.treeView1.TabIndex = 3;
            // 
            // panel_Log
            // 
            this.panel_Log.Controls.Add(this.tb_Password);
            this.panel_Log.Controls.Add(this.btn_Login);
            this.panel_Log.Controls.Add(this.tb_ServerPort);
            this.panel_Log.Controls.Add(this.lab_Username);
            this.panel_Log.Controls.Add(this.tb_ServerIP);
            this.panel_Log.Controls.Add(this.lab_Password);
            this.panel_Log.Controls.Add(this.tb_Username);
            this.panel_Log.Controls.Add(this.lab_Camera);
            this.panel_Log.Controls.Add(this.lab_ServerIP);
            this.panel_Log.Controls.Add(this.btn_LinkDisconnect);
            this.panel_Log.Controls.Add(this.btn_LinkConnect);
            this.panel_Log.Controls.Add(this.btn_Logout);
            this.panel_Log.Location = new System.Drawing.Point(13, 13);
            this.panel_Log.Name = "panel_Log";
            this.panel_Log.Size = new System.Drawing.Size(136, 271);
            this.panel_Log.TabIndex = 4;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(9, 74);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(100, 21);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(5, 101);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(55, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_ServerPort
            // 
            this.tb_ServerPort.Location = new System.Drawing.Point(5, 206);
            this.tb_ServerPort.Name = "tb_ServerPort";
            this.tb_ServerPort.Size = new System.Drawing.Size(100, 21);
            this.tb_ServerPort.TabIndex = 2;
            this.tb_ServerPort.Text = "2000";
            // 
            // lab_Username
            // 
            this.lab_Username.AutoSize = true;
            this.lab_Username.Location = new System.Drawing.Point(7, 11);
            this.lab_Username.Name = "lab_Username";
            this.lab_Username.Size = new System.Drawing.Size(41, 12);
            this.lab_Username.TabIndex = 1;
            this.lab_Username.Text = "用户名";
            // 
            // tb_ServerIP
            // 
            this.tb_ServerIP.Location = new System.Drawing.Point(5, 158);
            this.tb_ServerIP.Name = "tb_ServerIP";
            this.tb_ServerIP.Size = new System.Drawing.Size(100, 21);
            this.tb_ServerIP.TabIndex = 2;
            this.tb_ServerIP.Text = "192.168.1.10";
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(3, 59);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(29, 12);
            this.lab_Password.TabIndex = 1;
            this.lab_Password.Text = "密码";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(9, 26);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(100, 21);
            this.tb_Username.TabIndex = 2;
            // 
            // lab_Camera
            // 
            this.lab_Camera.AutoSize = true;
            this.lab_Camera.Location = new System.Drawing.Point(3, 191);
            this.lab_Camera.Name = "lab_Camera";
            this.lab_Camera.Size = new System.Drawing.Size(65, 12);
            this.lab_Camera.TabIndex = 1;
            this.lab_Camera.Text = "服务器端口";
            // 
            // lab_ServerIP
            // 
            this.lab_ServerIP.AutoSize = true;
            this.lab_ServerIP.Location = new System.Drawing.Point(3, 142);
            this.lab_ServerIP.Name = "lab_ServerIP";
            this.lab_ServerIP.Size = new System.Drawing.Size(53, 12);
            this.lab_ServerIP.TabIndex = 1;
            this.lab_ServerIP.Text = "服务器IP";
            // 
            // btn_LinkDisconnect
            // 
            this.btn_LinkDisconnect.Location = new System.Drawing.Point(68, 238);
            this.btn_LinkDisconnect.Name = "btn_LinkDisconnect";
            this.btn_LinkDisconnect.Size = new System.Drawing.Size(55, 23);
            this.btn_LinkDisconnect.TabIndex = 0;
            this.btn_LinkDisconnect.Text = "断开";
            this.btn_LinkDisconnect.UseVisualStyleBackColor = true;
            this.btn_LinkDisconnect.Click += new System.EventHandler(this.btn_LinkDisconnect_Click);
            // 
            // btn_LinkConnect
            // 
            this.btn_LinkConnect.Location = new System.Drawing.Point(5, 238);
            this.btn_LinkConnect.Name = "btn_LinkConnect";
            this.btn_LinkConnect.Size = new System.Drawing.Size(55, 23);
            this.btn_LinkConnect.TabIndex = 0;
            this.btn_LinkConnect.Text = "连接";
            this.btn_LinkConnect.UseVisualStyleBackColor = true;
            this.btn_LinkConnect.Click += new System.EventHandler(this.btn_LinkConnect_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(68, 101);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(55, 23);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "注销";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // UWBclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 706);
            this.Controls.Add(this.panel_Log);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.treeView1);
            this.Name = "UWBclient";
            this.Text = "UWBclient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UWBclient_FormClosing);
            this.Load += new System.EventHandler(this.UWBclient_Load);
            this.TabControl1.ResumeLayout(false);
            this.Page_Map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Tag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Tag1)).EndInit();
            this.panel_Map_Assist.ResumeLayout(false);
            this.panel_Map_Assist.PerformLayout();
            this.panel_Map_Zoom.ResumeLayout(false);
            this.panel_Map_Zoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Map_Grid)).EndInit();
            this.Page_Monitor.ResumeLayout(false);
            this.Page_Monitor.PerformLayout();
            this.TabControl_PTZ.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Tag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Tag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Monitor_View)).EndInit();
            this.Page_Alarm.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.Page_Fence.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel_Fence_List.ResumeLayout(false);
            this.Page_Tag.ResumeLayout(false);
            this.panel_People_btn.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Page_Anchor.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Anchor_btn.ResumeLayout(false);
            this.Page_Camera.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Page_Map_M.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.Page_History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Tag2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Tag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Map)).EndInit();
            this.panel_Map_Zoom_History.ResumeLayout(false);
            this.panel_Map_Zoom_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_H_Map)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar_H_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_History_Grid)).EndInit();
            this.Page_User.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.Page_System.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TagPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapbox)).EndInit();
            this.panel_tag.ResumeLayout(false);
            this.panel_tag.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_Log.ResumeLayout(false);
            this.panel_Log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Map_Map;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Page_Map;
        private System.Windows.Forms.TabPage Page_Monitor;
        private System.Windows.Forms.TabPage Page_Tag;
        private System.Windows.Forms.TabPage Page_Camera;
        private System.Windows.Forms.TabPage Page_History;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel_Log;
        private System.Windows.Forms.Button btn_LinkConnect;
        private System.Windows.Forms.Button btn_Cloud_FocusAuto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Cloud_FocusFar;
        private System.Windows.Forms.Button btn_Cloud_FocusNear;
        private System.Windows.Forms.Button btn_Cloud_ZoomOut;
        private System.Windows.Forms.Button btn_Cloud_ZoomIn;
        private System.Windows.Forms.Button btn_Cloud_Down;
        private System.Windows.Forms.Button btn_Cloud_Right;
        private System.Windows.Forms.Button btn_Cloud_Left;
        private System.Windows.Forms.Button btn_Cloud_Up;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pb_Monitor_Map;
        private System.Windows.Forms.PictureBox pb_Monitor_View;
        private System.Windows.Forms.TrackBar Trackbar_Map;
        private System.Windows.Forms.PictureBox pb_Map_Grid;
        private System.Windows.Forms.Panel panel_Map_Zoom;
        private System.Windows.Forms.Button btn_Map_ZoomFull;
        private System.Windows.Forms.Button btn_Map_ZoomOut;
        private System.Windows.Forms.Button btn_Map_ZoomIn;
        private System.Windows.Forms.Button btn_LinkDisconnect;
        private System.Windows.Forms.TextBox tb_ServerPort;
        private System.Windows.Forms.TextBox tb_ServerIP;
        private System.Windows.Forms.Label lab_Camera;
        private System.Windows.Forms.Label lab_ServerIP;
        private System.Windows.Forms.TabPage Page_System;
        private System.Windows.Forms.Button btn_Monitor_Record;
        private System.Windows.Forms.Button btn_Monitor_JPEG;
        private System.Windows.Forms.Button btn_Monitor_BMP;
        private System.Windows.Forms.Button btn_Monitor_Preview;
        private System.Windows.Forms.TabPage Page_Fence;
        private System.Windows.Forms.PictureBox pb_Monitor_Tag2;
        private System.Windows.Forms.PictureBox pb_Monitor_Tag1;
        private System.Windows.Forms.Label lab_Monitor_State;
        private System.Windows.Forms.TabPage Page_Alarm;
        private System.Windows.Forms.TabControl TabControl_PTZ;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.CheckBox checkBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button btn_Cloud_Match;
        private System.Windows.Forms.TextBox ZPosition;
        private System.Windows.Forms.TextBox YPosition;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Find;
        private System.Windows.Forms.TextBox XPosition;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_Cloud_PtzGet;
        private System.Windows.Forms.TextBox tb_Cloud_PanPos;
        private System.Windows.Forms.Button btn_Cloud_PtzSet;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_Cloud_TiltPos;
        private System.Windows.Forms.TextBox tb_Cloud_ZoomPos;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_Cloud_PreZoomPos;
        private System.Windows.Forms.Label lab_Preset_name;
        private System.Windows.Forms.TextBox tb_Cloud_PreTiltPos;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tb_Cloud_PrePanPos;
        private System.Windows.Forms.TextBox tb_Cloud_PreSetName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Name;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Inf;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Go;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Delete;
        private System.Windows.Forms.Button btn_Cloud_PreSet_Set;
        private System.Windows.Forms.Button btn_Map_ZoomNormal;
        private System.Windows.Forms.Label lab_Monitor_Record;
        private System.Windows.Forms.Label lab_Monitor_JPEG;
        private System.Windows.Forms.Label lab_Monitor_BMP;
        private System.Windows.Forms.Label lab_Monitor_Preview;
        private System.Windows.Forms.Panel panel_Map_Assist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_Map_Tag2;
        private System.Windows.Forms.PictureBox pb_Map_Tag1;
        private System.Windows.Forms.Button btn_Map_ShowAnchor;
        private System.Windows.Forms.Button btn_Map_Rotate2;
        private System.Windows.Forms.Button btn_Map_Rotate1;
        private System.Windows.Forms.Button btn_Fence_Draw;
        private System.Windows.Forms.TabPage Page_Anchor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_Fence_Modify;
        private System.Windows.Forms.Button btn_Fence_Delete;
        private System.Windows.Forms.Button btn_Fence_Add;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lv_People;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox Page_Search;
        private System.Windows.Forms.Button btn_Map_Search;
        private System.Windows.Forms.Button btn_Map_Fence_ShowFence;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel_Fence_List;
        private System.Windows.Forms.Panel panel_People_btn;
        private System.Windows.Forms.Button btn_Tag_Add;
        private System.Windows.Forms.Button btn_Tag_Modify;
        private System.Windows.Forms.Button btn_Tag_Delete;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_Alarm_Deal;
        private System.Windows.Forms.Button btn_Alarm_Correct;
        private System.Windows.Forms.Button btn_Alarm_Delete;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView lv_Alarm;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lv_Anchor;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Panel panel_Anchor_btn;
        private System.Windows.Forms.Button btn_Anchor_Add;
        private System.Windows.Forms.Button btn_Anchor_Modify;
        private System.Windows.Forms.Button btn_Anchor_Delete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Camera_Add;
        private System.Windows.Forms.Button btn_Camera_Modify;
        private System.Windows.Forms.Button btn_Camera_Delete;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.PictureBox pb_History_Tag2;
        private System.Windows.Forms.PictureBox pb_History_Tag1;
        private System.Windows.Forms.PictureBox pb_History_Map;
        private System.Windows.Forms.Panel panel_Map_Zoom_History;
        private System.Windows.Forms.Button btn_History_ZoomNormal;
        private System.Windows.Forms.Button btn_History_ZoomFull;
        private System.Windows.Forms.Button btn_History_ZoomOut;
        private System.Windows.Forms.Button btn_History_ZoomIn;
        private System.Windows.Forms.TrackBar Trackbar_H_Map;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_History_Stop;
        private System.Windows.Forms.Button btn_History_ShowFence;
        private System.Windows.Forms.Button btn_History_DrawFence;
        private System.Windows.Forms.Button btn_History_ShowAnchor;
        private System.Windows.Forms.Button btn_History_Rotate2;
        private System.Windows.Forms.Button btn_History_Rotate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_History_Grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Page_Map_M;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ListView lv_Map_M;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_Map_Add;
        private System.Windows.Forms.Button btn_Map_Modify;
        private System.Windows.Forms.Button btn_Map_Delete;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.Button btn_System_Set;
        private System.Windows.Forms.TrackBar Trackbar_H_Play;
        private System.Windows.Forms.ComboBox cb_SelectTag;
        private System.Windows.Forms.TabPage Page_User;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btn_User_Add;
        private System.Windows.Forms.Button btn_User_Modify;
        private System.Windows.Forms.Button btn_User_Delete;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lab_Username;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DateTimePicker dtp_History_Start;
        private System.Windows.Forms.DateTimePicker dtp_History_Stop;
        private System.Windows.Forms.Button btn_History_Start;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lsvReceviedMsg;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.ColumnHeader columnHeader55;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox TagPicture2;
        private System.Windows.Forms.PictureBox TagPicture1;
        private System.Windows.Forms.Label xy_mouse;
        private System.Windows.Forms.Label Z_Tag2;
        private System.Windows.Forms.Label X_mouse;
        private System.Windows.Forms.Label Y_mouse;
        private System.Windows.Forms.Label Y_Tag2;
        private System.Windows.Forms.Label label_Mouse;
        private System.Windows.Forms.TextBox Xbox_mouse;
        private System.Windows.Forms.Label Z_Tag1;
        private System.Windows.Forms.TextBox ybox_local;
        private System.Windows.Forms.TextBox xbox_local;
        private System.Windows.Forms.Label X_Tag2;
        private System.Windows.Forms.TextBox Ybox_mouse;
        private System.Windows.Forms.Label Y_Tag1;
        private System.Windows.Forms.Label label_Tag1;
        private System.Windows.Forms.Label label_Tag2;
        private System.Windows.Forms.Label X_Tag1;
        private System.Windows.Forms.Label ID_Tag2;
        private System.Windows.Forms.Button btn_SM;
        private System.Windows.Forms.Label ID_Tag1;
        private System.Windows.Forms.Button btn_SZ;
        private System.Windows.Forms.PictureBox mapbox;
        private System.Windows.Forms.Panel panel_tag;
        private System.Windows.Forms.TextBox IDbox_Tag1;
        private System.Windows.Forms.TextBox Xbox_Tag1;
        private System.Windows.Forms.TextBox Ybox_Tag1;
        private System.Windows.Forms.TextBox Zbox_Tag1;
        private System.Windows.Forms.TextBox IDbox_Tag2;
        private System.Windows.Forms.TextBox Xbox_Tag2;
        private System.Windows.Forms.TextBox Ybox_Tag2;
        private System.Windows.Forms.TextBox Zbox_Tag2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Monitor_Select;
        private System.Windows.Forms.ComboBox cb_Monitor_Camera;
        private System.Windows.Forms.TextBox tb_Monitor_Channel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Monitor_ID;
        private System.Windows.Forms.Label lab_Monitor_ID;
        private System.Windows.Forms.Button btn_Cloud_IrisAuto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_Cloud_IrisDown;
        private System.Windows.Forms.Button btn_Cloud_IrisOpen;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList LineHeight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private System.Windows.Forms.ColumnHeader columnHeader57;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

