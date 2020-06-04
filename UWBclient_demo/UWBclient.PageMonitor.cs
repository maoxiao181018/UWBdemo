using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace UWBclient_demo
{
    public partial class UWBclient : Form
    {

        #region ——————————————————————————UI_Monitor————————————————————————
        private void btn_Monitor_Select_Click(object sender, EventArgs e)
        {

            if (textBoxIP.Text == "" || textBoxPort.Text == "" ||
                textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please input IP, Port, User name and Password!");
                return;
            }
            if (m_lUserID < 0)
            {
                /*string DVRIPAddress = textBoxIP.Text; //设备IP地址或者域名
                Int16 DVRPortNumber = Int16.Parse(textBoxPort.Text);//设备服务端口号
                string DVRUserName = textBoxUserName.Text;//设备登录用户名
                string DVRPassword = textBoxPassword.Text;//设备登录密码

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //登录设备 Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                */

                struLogInfo = new CHCNetSDK.NET_DVR_USER_LOGIN_INFO();

                //设备IP地址或者域名
                byte[] byIP = System.Text.Encoding.Default.GetBytes(textBoxIP.Text);
                struLogInfo.sDeviceAddress = new byte[129];
                byIP.CopyTo(struLogInfo.sDeviceAddress, 0);

                //设备用户名
                byte[] byUserName = System.Text.Encoding.Default.GetBytes(textBoxUserName.Text);
                struLogInfo.sUserName = new byte[64];
                byUserName.CopyTo(struLogInfo.sUserName, 0);

                //设备密码
                byte[] byPassword = System.Text.Encoding.Default.GetBytes(textBoxPassword.Text);
                struLogInfo.sPassword = new byte[64];
                byPassword.CopyTo(struLogInfo.sPassword, 0);

                struLogInfo.wPort = ushort.Parse(textBoxPort.Text);//设备服务端口号

                if (LoginCallBack == null)
                {
                    LoginCallBack = new CHCNetSDK.LOGINRESULTCALLBACK(cbLoginCallBack);//注册回调函数                    
                }
                struLogInfo.cbLoginResult = LoginCallBack;

                struLogInfo.bUseAsynLogin = false; //是否异步登录：0- 否，1- 是 

                DeviceInfoV40 = new CHCNetSDK.NET_DVR_DEVICEINFO_V40();

                //登录设备 Login the device
                m_lUserID = CHCNetSDK.NET_DVR_Login_V40(ref struLogInfo, ref DeviceInfoV40);


                if (m_lUserID < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V40 failed, error code= " + iLastErr; //登录失败，输出错误号
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                else
                {
                    //登录成功
                    MessageBox.Show("Camera Select Success!");

                    lab_Monitor_State.Text = "状态提示：" + "已连接";
                    btn_Monitor_Select.Text = "Logout";

                    LoadFocusAuto();//读取参数
                    LoadCameraPa();
                    LoadPreSet();
                    LoadRange();
                    btn_Monitor_Preview.PerformClick();//++
                    //heartbeat.Enabled = true;
                    Camera_HeartBeat.Change(CHeartBeatInterval, CHeartBeatInterval);//启动timer

                }
            }
            else
            {
                //停止预览 Stop live view 
                if (m_lRealHandle >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                    m_lRealHandle = -1;
                    ifPreview(m_lRealHandle);//++
                }

                /*
                
                if (m_lRealHandle >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }
                */

                //注销登录 Logout the device
                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                m_lUserID = -1;
                //heartbeat.Enabled = false;
                Camera_HeartBeat.Change(Timeout.Infinite, Timeout.Infinite);//停止timer

                lab_Monitor_State.Text = "状态提示：" + "未连接";
                btn_Monitor_Select.Text = "Select";
            }
            return;
        }

        private void btn_Monitor_Preview_Click(object sender, System.EventArgs e)//预览
        {
            if (m_lUserID < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = pb_Monitor_View.Handle;//预览窗口
                lpPreviewInfo.lChannel = Int16.Parse(tb_Monitor_Channel.Text);//预览的设备通道
                lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                lpPreviewInfo.dwDisplayBufNum = 1; //播放库播放缓冲区最大缓冲帧数
                lpPreviewInfo.byProtoType = 0;
                lpPreviewInfo.byPreviewMode = 0;


                if (tb_Monitor_ID.Text != "")
                {
                    lpPreviewInfo.lChannel = -1;
                    byte[] byStreamID = System.Text.Encoding.Default.GetBytes(tb_Monitor_ID.Text);
                    lpPreviewInfo.byStreamID = new byte[32];
                    byStreamID.CopyTo(lpPreviewInfo.byStreamID, 0);
                }


                if (RealData == null)
                {
                    RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数
                }

                IntPtr pUser = new IntPtr();//用户数据
                //???

                //打开预览 Start live view 
                m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
                ifPreview(m_lRealHandle);//++
                if (m_lRealHandle < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //预览失败，输出错误号
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                else
                {
                    //预览成功
                    btn_Monitor_Preview.Text = "Stop Live View";
                }
            }
            else
            {
                //停止预览 Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                m_lRealHandle = -1;
                ifPreview(m_lRealHandle);//++
                btn_Monitor_Preview.Text = "Live View";

            }
            return;
        }

        private void btn_Monitor_BMP_Click(object sender, EventArgs e)
        {
            string sBmpPicFileName;
            //图片保存路径和文件名 the path and file name to save[链接]
            sBmpPicFileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".bmp";


            //BMP抓图 Capture a BMP picture
            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle, sBmpPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CapturePicture failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the BMP file and the saved file is " + sBmpPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btn_Monitor_JPEG_Click(object sender, EventArgs e)
        {
            string sJpegPicFileName;
            //图片保存路径和文件名 the path and file name to save
            sJpegPicFileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";

            int lChannel = Int16.Parse(tb_Monitor_Channel.Text); //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 2- 4CIF，0xff- Auto(使用当前码流分辨率)，抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图 Capture a JPEG picture
            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btn_Monitor_Record_Click(object sender, EventArgs e)
        {
            //录像保存路径和文件名 the path and file name to save
            string sVideoFileName;
            sVideoFileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".mp4";

            if (m_bRecord == false)
            {
                //强制I帧 Make a I frame
                int lChannel = Int16.Parse(tb_Monitor_Channel.Text); //通道号 Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);

                //开始录像 Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                else
                {
                    btn_Monitor_Record.Text = "Stop Record";
                    m_bRecord = true;
                }
            }
            else
            {
                //停止录像 Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                else
                {
                    str = "Successful to stop recording and the saved file is " + sVideoFileName;
                    MessageBox.Show(str);
                    btn_Monitor_Record.Text = "Start Record";
                    m_bRecord = false;
                }
            }

            return;
        }

        private void btn_Cloud_Up_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.TILT_UP, false);
        }

        private void btn_Cloud_Up_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.TILT_UP, true);
        }

        private void btn_Cloud_Left_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.PAN_LEFT, false);
        }

        private void btn_Cloud_Left_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.PAN_LEFT, true);
        }

        private void btn_Cloud_Right_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.PAN_RIGHT, false);
        }

        private void btn_Cloud_Right_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.PAN_RIGHT, true);
        }

        private void btn_Cloud_Down_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.TILT_DOWN, false);
        }

        private void btn_Cloud_Down_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.TILT_DOWN, true);
        }

        private void btn_Cloud_ZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.ZOOM_IN, false);
        }

        private void btn_Cloud_ZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.ZOOM_IN, true);
        }

        private void btn_Cloud_ZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.ZOOM_OUT, false);
        }

        private void btn_Cloud_ZoomOut_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.ZOOM_OUT, true);
        }

        private void btn_Cloud_FocusNear_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.FOCUS_NEAR, false);
        }

        private void btn_Cloud_FocusNear_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.FOCUS_NEAR, true);
        }

        private void btn_Cloud_FocusFar_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.FOCUS_FAR, false);
        }

        private void btn_Cloud_FocusFar_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.FOCUS_FAR, true);
        }

        private void btn_Cloud_IrisOpen_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.IRIS_OPEN, false);
        }

        private void btn_Cloud_IrisOpen_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.IRIS_OPEN, true);
        }

        private void btn_Cloud_IrisClose_MouseDown(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.IRIS_CLOSE, false);
        }

        private void btn_Cloud_IrisClose_MouseUp(object sender, MouseEventArgs e)
        {
            PTZControl(CHCNetSDK.IRIS_CLOSE, true);
        }

        private void btn_Cloud_FocusAuto_Click(object sender, EventArgs e)
        {
            SetFocusAuto();
        }

        private void btn_Cloud_IrisAuto_Click(object sender, EventArgs e)//自动/手动光圈
        {
            switch (btn_Cloud_IrisAuto.Text)
            {
                case "Auto":
                    m_struCameraPa.byIrisMode = 1;
                    break;
                case "Manual":
                    m_struCameraPa.byIrisMode = 0;
                    break;
            }

            Int32 nSize = Marshal.SizeOf(m_struCameraPa);
            IntPtr ptrCameraPa = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struCameraPa, ptrCameraPa, false);
            //设置参数失败
            if (!CHCNetSDK.NET_DVR_SetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_SET_CCDPARAMCFG, -1, ptrCameraPa, (UInt32)nSize))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_SetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struCameraPa = (CHCNetSDK.NET_DVR_CAMERAPARAMCFG)Marshal.PtrToStructure(ptrCameraPa, typeof(CHCNetSDK.NET_DVR_CAMERAPARAMCFG));

                switch (m_struCameraPa.byIrisMode)
                {
                    case 0:
                        btn_Cloud_IrisAuto.Text = "Auto";
                        break;
                    case 1:
                        btn_Cloud_IrisAuto.Text = "Manual";
                        break;
                }

            }
            Marshal.FreeHGlobal(ptrCameraPa);
            return;
        }


        private void btn_Cloud_PtzSet_Click(object sender, EventArgs e)
        {
            int flag = 1;
            float wPanPos, wTiltPos, wZoomPos;
            String str1, str2, str3;
            if (comboBoxAction.Text == "")
            {
                MessageBox.Show("Please input the operation type  ");
            }
            /* wPanPos = ushort.Parse(textBoxPanPos.Text);
             wTiltPos = ushort.Parse(textBoxTiltPos.Text);
             wZoomPos = ushort.Parse(textBoxZoomPos.Text);*/
            switch (comboBoxAction.Items.IndexOf(comboBoxAction.Text))//下拉框中的数据
            {
                case 0:

                    if (tb_Cloud_PanPos.Text == "" || tb_Cloud_TiltPos.Text == "" ||
                        tb_Cloud_ZoomPos.Text == "")
                    {

                        MessageBox.Show("Please input prarameters of P,T,Z: ");
                        return;
                    }
                    else
                    {
                        flag = 0;
                        m_struPtzCfg.wAction = 1;

                        str1 = Convert.ToString(float.Parse(tb_Cloud_PanPos.Text) * 10);
                        m_struPtzCfg.wPanPos = (ushort)(Convert.ToUInt16(str1, 16));
                        str2 = Convert.ToString(float.Parse(tb_Cloud_TiltPos.Text) * 10);
                        m_struPtzCfg.wTiltPos = (ushort)(Convert.ToUInt16(str2, 16));
                        str3 = Convert.ToString(float.Parse(tb_Cloud_ZoomPos.Text) * 10);
                        m_struPtzCfg.wZoomPos = (ushort)(Convert.ToUInt16(str3, 16));
                    }
                    break;
                case 1:
                    if (tb_Cloud_PanPos.Text == "")
                    {
                        MessageBox.Show("Please input prarameters of P: ");
                        return;
                    }
                    else
                    {
                        flag = 0;
                        m_struPtzCfg.wAction = 2;

                        str1 = Convert.ToString(float.Parse(tb_Cloud_PanPos.Text) * 10);
                        m_struPtzCfg.wPanPos = (ushort)(Convert.ToUInt16(str1, 16));

                    }
                    break;
                case 2:
                    if (tb_Cloud_TiltPos.Text == "")
                    {
                        MessageBox.Show("Please input prarameters of T: ");
                        return;
                    }
                    else
                    {
                        flag = 0;
                        m_struPtzCfg.wAction = 3;
                        m_struPtzCfg.wTiltPos = ushort.Parse(tb_Cloud_TiltPos.Text);

                        str2 = Convert.ToString(float.Parse(tb_Cloud_TiltPos.Text) * 10);
                        m_struPtzCfg.wTiltPos = (ushort)(Convert.ToUInt16(str2, 16));

                    }
                    break;
                case 3:
                    if (tb_Cloud_ZoomPos.Text == "")
                    {
                        MessageBox.Show("Please input prarameters of Z: ");
                        return;
                    }
                    else
                    {
                        flag = 0;
                        m_struPtzCfg.wAction = 4;
                        m_struPtzCfg.wZoomPos = ushort.Parse(tb_Cloud_ZoomPos.Text);

                        str3 = Convert.ToString(float.Parse(tb_Cloud_ZoomPos.Text) * 10);
                        m_struPtzCfg.wZoomPos = (ushort)(Convert.ToUInt16(str3, 16));
                    }
                    break;
                case 4:
                    if (tb_Cloud_TiltPos.Text == "" || tb_Cloud_PanPos.Text == "")
                    {
                        MessageBox.Show("Please input prarameters of P,T: ");
                        return;
                    }
                    else
                    {
                        flag = 0;
                        m_struPtzCfg.wAction = 5;
                        m_struPtzCfg.wPanPos = ushort.Parse(tb_Cloud_PanPos.Text);
                        m_struPtzCfg.wTiltPos = ushort.Parse(tb_Cloud_TiltPos.Text);

                        str1 = Convert.ToString(float.Parse(tb_Cloud_PanPos.Text) * 10);
                        m_struPtzCfg.wPanPos = (ushort)(Convert.ToUInt16(str1, 16));
                        str2 = Convert.ToString(float.Parse(tb_Cloud_TiltPos.Text) * 10);
                        m_struPtzCfg.wTiltPos = (ushort)(Convert.ToUInt16(str2, 16));

                    }
                    break;


            }


            while (flag == 0)
            {

                Int32 nSize = Marshal.SizeOf(m_struPtzCfg);
                IntPtr ptrPtzCfg = Marshal.AllocHGlobal(nSize);
                Marshal.StructureToPtr(m_struPtzCfg, ptrPtzCfg, false);

                if (!CHCNetSDK.NET_DVR_SetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_SET_PTZPOS, 1, ptrPtzCfg, (UInt32)nSize))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SetDVRConfig failed, error code= " + iLastErr;
                    //设置POS参数失败
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    Marshal.FreeHGlobal(ptrPtzCfg);//??
                    return;
                }
                else
                {
                    MessageBox.Show("设置成功!");
                    Marshal.FreeHGlobal(ptrPtzCfg);//??
                    break;
                }
            }

            return;
        }

        private void btn_Cloud_PtzGet_Click(object sender, EventArgs e)
        {
            UInt32 dwReturn = 0;
            Int32 nSize = Marshal.SizeOf(m_struPtzCfg);
            IntPtr ptrPtzCfg = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struPtzCfg, ptrPtzCfg, false);
            //获取参数失败
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_PTZPOS, -1, ptrPtzCfg, (UInt32)nSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struPtzCfg = (CHCNetSDK.NET_DVR_PTZPOS)Marshal.PtrToStructure(ptrPtzCfg, typeof(CHCNetSDK.NET_DVR_PTZPOS));
                //成功获取显示ptz参数
                ushort wPanPos = Convert.ToUInt16(Convert.ToString(m_struPtzCfg.wPanPos, 16));
                float WPanPos = wPanPos * 0.1f;
                tb_Cloud_PanPos.Text = Convert.ToString(WPanPos);
                ushort wTiltPos = Convert.ToUInt16(Convert.ToString(m_struPtzCfg.wTiltPos, 16));
                float WTiltPos = wTiltPos * 0.1f;
                tb_Cloud_TiltPos.Text = Convert.ToString(WTiltPos);
                ushort wZoomPos = Convert.ToUInt16(Convert.ToString(m_struPtzCfg.wZoomPos, 16));
                float WZoomPos = wZoomPos * 0.1f;
                tb_Cloud_ZoomPos.Text = Convert.ToString(WZoomPos);
            }
            Marshal.FreeHGlobal(ptrPtzCfg);
            return;
        }

        private void btn_Cloud_PreSet_Set_Click(object sender, EventArgs e)
        {
            while (comboBox1.Text != "")
            {
                DialogResult dr;
                dr = MessageBox.Show("确认将当前点设置为预置点" + comboBox1.Text, "设置", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    PreSetNo = comboBox1.Items.IndexOf(comboBox1.Text);
                    if (!CHCNetSDK.NET_DVR_PTZPreset_Other(m_lUserID, 1, CHCNetSDK.SET_PRESET, (UInt32)(PreSetNo + 1)))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_PTZPreset_Other failed, error code= " + iLastErr;
                        MessageBox.Show(Errors[iLastErr]);
                        //MessageBox.Show(str);
                        return;
                    }
                    else
                    {
                        LoadPreSet();
                        tb_Cloud_PrePanPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wPanPos);
                        tb_Cloud_PreTiltPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wTiltPos);
                        tb_Cloud_PreZoomPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wZoomPos);
                        if (m_struPreSetCfg[PreSetNo].byName != null)
                        {
                            str = System.Text.Encoding.Default.GetString(m_struPreSetCfg[PreSetNo].byName);
                        }

                        tb_Cloud_PreSetName.Text = str;
                        MessageBox.Show("设置成功");
                    }
                    return;
                }
                else return;
            }
            MessageBox.Show("please input the PtrPreSetNo");
        }

        private void btn_Cloud_PreSet_Go_Click(object sender, EventArgs e)
        {
            while (comboBox1.Text != "")
            {
                PreSetNo = comboBox1.Items.IndexOf(comboBox1.Text);
                if (!CHCNetSDK.NET_DVR_PTZPreset_Other(m_lUserID, 1, CHCNetSDK.GOTO_PRESET, (UInt32)(PreSetNo + 1)))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_PTZPreset_Other failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                    return;
                }
                else
                {
                    /*if (m_struPreSetCfg[PreSetNo].wPanPos == 0)
                    {
                        MessageBox.Show("该预置点还没有设置");
                        return;
                    }*/
                    tb_Cloud_PrePanPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wPanPos);
                    tb_Cloud_PreTiltPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wTiltPos);
                    tb_Cloud_PreZoomPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wZoomPos);
                    if (m_struPreSetCfg[PreSetNo].byName != null)
                    {
                        tb_Cloud_PreSetName.Text = System.Text.Encoding.Default.GetString(m_struPreSetCfg[PreSetNo].byName);
                    }
                    MessageBox.Show("调用成功");
                }
                return;
            }
            MessageBox.Show("please input the PtrPreSetNo");
        }

        private void btn_Cloud_PreSet_Delete_Click(object sender, EventArgs e)
        {
            while (comboBox1.Text != "")
            {
                DialogResult dr;
                dr = MessageBox.Show("确认删除预置点" + comboBox1.Text, "删除", MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    PreSetNo = comboBox1.Items.IndexOf(comboBox1.Text);
                    if (!CHCNetSDK.NET_DVR_PTZPreset_Other(m_lUserID, 1, CHCNetSDK.CLE_PRESET, (UInt32)(PreSetNo + 1)))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_PTZPreset_Other failed, error code= " + iLastErr;
                        MessageBox.Show(Errors[iLastErr]);
                        //MessageBox.Show(str);
                        return;
                    }
                    else
                    {
                        LoadPreSet();
                        tb_Cloud_PrePanPos.Text = "";
                        tb_Cloud_PreTiltPos.Text = "";
                        tb_Cloud_PreZoomPos.Text = "";
                        if (m_struPreSetCfg[PreSetNo].byName != null)
                        {
                            tb_Cloud_PreSetName.Text = System.Text.Encoding.Default.GetString(m_struPreSetCfg[PreSetNo].byName);
                        }
                        MessageBox.Show("删除成功");
                    }
                    return;
                }
                else return;
            }
            MessageBox.Show("please input the PtrPreSetNo");
        }

        private void btn_Cloud_PreSet_Name_Click(object sender, EventArgs e)
        {
            while (comboBox1.Text != "")
            {
                if (tb_Cloud_PrePanPos.Text == "" || tb_Cloud_PreTiltPos.Text == "" || tb_Cloud_PreZoomPos.Text == "" || tb_Cloud_PreSetName.Text == "")
                {
                    MessageBox.Show("please input the Parameters");
                    return;
                }
                else
                {
                    PreSetNo = comboBox1.Items.IndexOf(comboBox1.Text);
                    m_struPreSetCfg[PreSetNo].byRes = new byte[58];
                    m_struPreSetCfg[PreSetNo].byRes1 = new byte[2];
                    Int32 nSize = Marshal.SizeOf(m_struPreSetCfg[PreSetNo]);
                    IntPtr ptrPreSetCfg = Marshal.AllocHGlobal(nSize);


                    m_struPreSetCfg[PreSetNo].dwSize = (uint)nSize;

                    byte[] byName = System.Text.Encoding.Default.GetBytes(tb_Cloud_PreSetName.Text);
                    m_struPreSetCfg[PreSetNo].byName = new byte[32];
                    byName.CopyTo(m_struPreSetCfg[PreSetNo].byName, 0);

                    Marshal.StructureToPtr(m_struPreSetCfg[PreSetNo], ptrPreSetCfg, false);

                    //设置参数失败
                    if (!CHCNetSDK.NET_DVR_SetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_SET_PRESET_NAME, 1, ptrPreSetCfg, (UInt32)nSize))
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_SetDVRConfig failed, error code= " + iLastErr;
                        MessageBox.Show(Errors[iLastErr]);
                        //MessageBox.Show(str);
                    }
                    else
                    {
                        m_struPreSetCfg[PreSetNo] = (CHCNetSDK.NET_DVR_PRESET_NAME)Marshal.PtrToStructure(ptrPreSetCfg, typeof(CHCNetSDK.NET_DVR_PRESET_NAME));
                        MessageBox.Show("设置成功");
                    }
                    Marshal.FreeHGlobal(ptrPreSetCfg);
                    return;
                }
            }
            MessageBox.Show("please input the PtrPreSetNo");
        }

        private void btn_Cloud_PreSet_Inf_Click(object sender, EventArgs e)
        {
            while (comboBox1.Text != "")
            {
                PreSetNo = comboBox1.Items.IndexOf(comboBox1.Text);
                UInt32 dwReturn = 0;
                Int32 nSize = Marshal.SizeOf(m_struPreSetCfg[PreSetNo]);
                Int32 nOutBufSize = nSize * 300;
                IntPtr ptrPreSetCfg = Marshal.AllocHGlobal(nOutBufSize);
                int i;
                for (i = 0; i < 300; i++)
                {
                    Marshal.StructureToPtr(m_struPreSetCfg[i], (IntPtr)((Int32)(ptrPreSetCfg) + i * nSize), false);
                }
                //获取参数失败
                if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_PRESET_NAME, 1, ptrPreSetCfg, (UInt32)nOutBufSize, ref dwReturn))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                    MessageBox.Show(Errors[iLastErr]);
                    //MessageBox.Show(str);
                }
                else
                {
                    for (i = 0; i < 300; i++)
                    {
                        m_struPreSetCfg[i] = (CHCNetSDK.NET_DVR_PRESET_NAME)Marshal.PtrToStructure((IntPtr)((Int32)(ptrPreSetCfg) + i * nSize), typeof(CHCNetSDK.NET_DVR_PRESET_NAME));
                    }
                    tb_Cloud_PrePanPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wPanPos);
                    tb_Cloud_PreTiltPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wTiltPos);
                    tb_Cloud_PreZoomPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wZoomPos);
                    if (m_struPreSetCfg[PreSetNo].byName != null)
                    {
                        str = System.Text.Encoding.Default.GetString(m_struPreSetCfg[PreSetNo].byName);
                    }

                    tb_Cloud_PreSetName.Text = str;
                    MessageBox.Show("获取成功");
                }
                Marshal.FreeHGlobal(ptrPreSetCfg);
                return;
            }
            MessageBox.Show("please input the PtrPreSetNo");
        }

        private void btn_Cloud_PreSet_Find_Click(object sender, EventArgs e)
        {

            int toSetNo;
            toSetNo = XYZtoSetNo();
            if (toSetNo == 0 || toSetNo == -1)
            {
                return;
            }
            PreSetNo = toSetNo;//第一个点是边缘点 所以不用-1
            if (!CHCNetSDK.NET_DVR_PTZPreset_Other(m_lUserID, 1, CHCNetSDK.GOTO_PRESET, (UInt32)(PreSetNo + 1)))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_PTZPreset_Other failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
                return;
            }
            else
            {
                /*if (m_struPreSetCfg[PreSetNo].wPanPos == 0)
                {
                 MessageBox.Show("该预置点还没有设置");
                 return;
                 }*/
                tb_Cloud_PrePanPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wPanPos);
                tb_Cloud_PreTiltPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wTiltPos);
                tb_Cloud_PreZoomPos.Text = Convert.ToString(0.1 * m_struPreSetCfg[PreSetNo].wZoomPos);
                if (m_struPreSetCfg[PreSetNo].byName != null)
                {
                    tb_Cloud_PreSetName.Text = System.Text.Encoding.Default.GetString(m_struPreSetCfg[PreSetNo].byName);
                }
                MessageBox.Show("调用成功");
            }
            return;

        }

        private void btn_Cloud_Match_Click(object sender, EventArgs e)
        {
            int[] PTZ = XYZtoPTZ();
            CoSetPTZ(PTZ[0], PTZ[1], PTZ[2]);
        }

        #endregion

        #region Camera_fun //Camera函数

        private void g_ExceptionCallBack(uint dwType, int lUserID, int lHandle, IntPtr pUser)
        {
            Console.WriteLine("************************触发回调异常");
            Console.WriteLine("{0:T}", System.DateTime.Now);
            switch (dwType)
            {
                case CHCNetSDK.EXCEPTION_EXCHANGE:       //用户交互时异常
                    Console.WriteLine("****用户交互时异常!!!****");
                    Console.WriteLine("——————————————————————————————————————————");
                    //TODO: 关闭
                    break;
                case CHCNetSDK.EXCEPTION_AUDIOEXCHANGE:       //语音对讲时网络异常
                    Console.WriteLine("****语音对讲时网络异常!!!****");
                    //TODO: 关闭语音对讲
                    break;
                case CHCNetSDK.EXCEPTION_ALARM:           //报警上传时网络异常
                    Console.WriteLine("****报警上传时网络异常!!!****");
                    //TODO: 关闭报警上传
                    break;
                case CHCNetSDK.EXCEPTION_PREVIEW:         //网络预览时异常
                    Console.WriteLine("****网络预览异常****");
                    //TODO: 关闭网络预览
                    break;
                case CHCNetSDK.EXCEPTION_SERIAL:          //透明通道传输时异常
                    Console.WriteLine("****透明通道传输时异常****");
                    //TODO: 关闭透明通道
                    break;
                case CHCNetSDK.EXCEPTION_RECONNECT:           //预览时重连
                    Console.WriteLine("****重连异常*******");
                    break;
                default:
                    Console.WriteLine("****其他异常：{0}****", dwType);
                    break;
            }
        }

        public void cbLoginCallBack(int lUserID, int dwResult, IntPtr lpDeviceInfo, IntPtr pUser)
        {
            string strLoginCallBack = "登录设备，lUserID：" + lUserID + "，dwResult：" + dwResult;

            if (dwResult == 0)
            {
                uint iErrCode = CHCNetSDK.NET_DVR_GetLastError();
                strLoginCallBack = strLoginCallBack + "，错误号:" + iErrCode;
            }

            //下面代码注释掉也会崩溃
            if (InvokeRequired)
            {
                object[] paras = new object[2];
                paras[0] = strLoginCallBack;
                paras[1] = lpDeviceInfo;
                //labelLogin.BeginInvoke(new UpdateTextStatusCallback(UpdateClientList), paras);
            }
            else
            {
                //创建该控件的主线程直接更新信息列表 
                UpdateClientList(strLoginCallBack, lpDeviceInfo);
            }

        }

        public void UpdateClientList(string strLogStatus, IntPtr lpDeviceInfo)
        {
            //列表新增报警信息
            //labelLogin.Text = "登录状态（异步）：" + strLogStatus;
        }

        private void ifPreview(Int32 ifPre)//是否预览
        {
            if (ifPre > -1)
            {
                checkBoxPreview.Checked = true;
            }
            else
            {
                checkBoxPreview.Checked = false;
            }
        }

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
            if (dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "实时流数据.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();
            }
        }

        private void PTZControl(uint Command, bool ud)
        {
            if (ud == true)
            {
                if (bRet)
                {
                    if (checkBoxPreview.Checked)
                    {
                        bRet = CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, Command, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                    }
                    else
                    {
                        bRet = CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, Command, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                    }
                }

            }
            else
            {
                if (checkBoxPreview.Checked)
                {
                    bRet = CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, Command, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                }
                else
                {
                    bRet = CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, Command, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                }
                if (!bRet)
                {
                    MessageBox.Show("云台控制失败");
                }

            }

        }

        private void LoadRange()//获取ptz范围 新版SDK有bug
        {
            UInt32 dwReturn = 0;
            Int32 nSize = Marshal.SizeOf(m_struPtzCfg1);
            IntPtr ptrPtzCfg = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struPtzCfg1, ptrPtzCfg, false);

            //获取参数失败
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_PTZSCOPE, -1, ptrPtzCfg, (UInt32)nSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struPtzCfg1 = (CHCNetSDK.NET_DVR_PTZSCOPE)Marshal.PtrToStructure(ptrPtzCfg, typeof(CHCNetSDK.NET_DVR_PTZSCOPE));
                //成功获取显示ptz参数范围
                ushort wPanPosMax = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wPanPosMax, 16));
                float WPanPosMax = wPanPosMax * 0.1f;
                ushort wTiltPosMax = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wTiltPosMax, 16));
                float WTiltPosMax = wTiltPosMax * 0.1f;
                ushort wZoomPosMax = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wZoomPosMax, 16));
                float WZoomPosMax = wZoomPosMax * 0.1f;
                ushort wPanPosMin = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wPanPosMin, 16));
                float WPanPosMin = wPanPosMin * 0.1f;
                ushort wTiltPosMin = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wTiltPosMin, 16));
                float WTiltPosMin = wTiltPosMin * 0.1f;
                ushort wZoomPosMin = Convert.ToUInt16(Convert.ToString(m_struPtzCfg1.wZoomPosMin, 16));
                float WZoomPosMin = wZoomPosMin * 0.1f;

                str = "范围：P∈(" + WPanPosMin + "," + WPanPosMax + ")  T∈(" + WTiltPosMin + "," + WTiltPosMax + ")  Z∈(" + WZoomPosMin + "," + WZoomPosMax + ")";
                label33.Text = str;

            }
            Marshal.FreeHGlobal(ptrPtzCfg);
            return;
        }

        private void LoadErrors()
        {
            try
            {
                StreamReader rd = new StreamReader("errors.txt", System.Text.Encoding.Default);
                string content = rd.ReadToEnd();
                Errors = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            }
            catch
            {
                MessageBox.Show("找不到error.txt文件或文件损坏");
            }
        }

        private void LoadFocusAuto()
        {

            UInt32 dwReturn = 0;
            Int32 nSize = Marshal.SizeOf(m_struFocusmode);
            IntPtr ptrFocusMode = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struFocusmode, ptrFocusMode, false);
            //获取参数失败
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_FOCUSMODECFG, 1, ptrFocusMode, (UInt32)nSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struFocusmode = (CHCNetSDK.NET_DVR_FOCUSMODE_CFG)Marshal.PtrToStructure(ptrFocusMode, typeof(CHCNetSDK.NET_DVR_FOCUSMODE_CFG));

                switch (m_struFocusmode.byFocusMode)
                {
                    case 0:
                        btn_Cloud_FocusAuto.Text = "Auto";
                        break;
                    case 1:
                        btn_Cloud_FocusAuto.Text = "Manual";
                        break;
                    case 2:
                        btn_Cloud_FocusAuto.Text = "Semi";
                        break;
                }

            }
            Marshal.FreeHGlobal(ptrFocusMode);
            return;
        }

        private void SetFocusAuto()
        {

            switch (btn_Cloud_FocusAuto.Text)
            {
                case "Auto":
                    m_struFocusmode.byFocusMode = 1;
                    break;
                case "Manual":
                    m_struFocusmode.byFocusMode = 2;
                    break;
                case "Semi":
                    m_struFocusmode.byFocusMode = 0;
                    break;
            }

            Int32 nSize = Marshal.SizeOf(m_struFocusmode);
            IntPtr ptrFocusMode = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struFocusmode, ptrFocusMode, false);
            //设置参数失败
            if (!CHCNetSDK.NET_DVR_SetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_SET_FOCUSMODECFG, 1, ptrFocusMode, (UInt32)nSize))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_SetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struFocusmode = (CHCNetSDK.NET_DVR_FOCUSMODE_CFG)Marshal.PtrToStructure(ptrFocusMode, typeof(CHCNetSDK.NET_DVR_FOCUSMODE_CFG));

                switch (m_struFocusmode.byFocusMode)
                {
                    case 0:
                        btn_Cloud_FocusAuto.Text = "Auto";
                        break;
                    case 1:
                        btn_Cloud_FocusAuto.Text = "Manual";
                        break;
                    case 2:
                        btn_Cloud_FocusAuto.Text = "Semi";
                        break;
                }

            }
            Marshal.FreeHGlobal(ptrFocusMode);
            return;
        }

        private void LoadCameraPa()
        {
            UInt32 dwReturn = 0;
            Int32 nSize = Marshal.SizeOf(m_struCameraPa);
            IntPtr ptrCameraPa = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struCameraPa, ptrCameraPa, false);
            //获取参数失败
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_CCDPARAMCFG, -1, ptrCameraPa, (UInt32)nSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                m_struCameraPa = (CHCNetSDK.NET_DVR_CAMERAPARAMCFG)Marshal.PtrToStructure(ptrCameraPa, typeof(CHCNetSDK.NET_DVR_CAMERAPARAMCFG));

                switch (m_struCameraPa.byIrisMode)
                {
                    case 0:
                        //IRIS_AUTO.Text = "Auto";
                        break;
                    case 1:
                        //IRIS_AUTO.Text = "Manual";
                        break;
                }

            }
            Marshal.FreeHGlobal(ptrCameraPa);
            return;
        }

        private int XYZtoSetNo()
        {
            int x, y, z, SN = 0;
            x = int.Parse(XPosition.Text);
            y = int.Parse(YPosition.Text);
            z = int.Parse(ZPosition.Text);
            if (x == 0 && y == 0 && z == 0)
            {
                SN = -1;
            }
            else if (x >= 0 && x < 100 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 1;
            }
            else if (x >= 100 && x < 200 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 2;
            }
            else if (x >= 100 && x < 200 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 2;
            }
            else if (x >= 200 && x < 300 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 3;
            }
            else if (x >= 300 && x < 400 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 4;
            }
            else if (x >= 400 && x < 500 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 5;
            }
            else if (x >= 500 && x < 600 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 6;

            }
            else if (x >= 600 && x < 700 && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                SN = 7;

            }
            return SN;
        }

        private int[] XYZtoPTZ()
        {
            int x, y, z;
            int P = 0, T = 0, Z = 0;
            int Loc = -10;

            if (!(int.TryParse(XPosition.Text, out x) && int.TryParse(YPosition.Text, out y) && int.TryParse(ZPosition.Text, out z)))
            {
                MessageBox.Show("xyz输入错误");
                return null;
            }

            if (x == 0 && y == 0 && z == 0)
            {
                P = -1;
            }
            else if (x >= 0 && x < XYZ[1, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 0;
            }
            else if (x >= XYZ[1, 0] && x < XYZ[2, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 1;
            }
            else if (x >= XYZ[2, 0] && x < XYZ[3, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 2;
            }
            else if (x >= XYZ[3, 0] && x < XYZ[4, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 3;
            }
            else if (x >= XYZ[4, 0] && x < XYZ[5, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 4;
            }
            else if (x >= XYZ[5, 0] && x < XYZ[6, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 5;
            }
            else if (x >= XYZ[6, 0] && x < XYZ[7, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 6;
            }
            else if (x >= XYZ[7, 0] && x < XYZ[8, 0] && y >= 0 && y < 1000 && z >= 0 && z < 1000)
            {
                Loc = 7;
            }
            else
            {
                P = -9;
            }

            if (Loc >= 0)
            {
                P = (int)((x - XYZ[Loc, 0]) / (XYZ[Loc + 1, 0] - XYZ[Loc, 0] + 0.0001) * (m_struPreSetCfg[Loc + 1].wPanPos - m_struPreSetCfg[Loc].wPanPos) + m_struPreSetCfg[Loc].wPanPos);
                T = (int)((y - XYZ[Loc, 1]) / (XYZ[Loc + 1, 1] - XYZ[Loc, 1] + 0.0001) * (m_struPreSetCfg[Loc + 1].wTiltPos - m_struPreSetCfg[Loc].wTiltPos) + m_struPreSetCfg[Loc].wTiltPos);
                Z = (int)((z - XYZ[Loc, 2]) / (XYZ[Loc + 1, 2] - XYZ[Loc, 2] + 0.0001) * (m_struPreSetCfg[Loc + 1].wZoomPos - m_struPreSetCfg[Loc].wZoomPos) + m_struPreSetCfg[Loc].wZoomPos);
            }

            int[] PTZ = { P, T, Z };
            return PTZ;

        }

        private void CoSetPTZ(int P, int T, int Z)
        {

            if (P < 0)
            {
                return;
            }

            m_struPtzCfg.wAction = 1;
            m_struPtzCfg.wPanPos = (ushort)P;
            m_struPtzCfg.wTiltPos = (ushort)T;
            m_struPtzCfg.wZoomPos = (ushort)Z;

            Int32 nSize = Marshal.SizeOf(m_struPtzCfg);
            IntPtr ptrPtzCfg = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(m_struPtzCfg, ptrPtzCfg, false);

            if (!CHCNetSDK.NET_DVR_SetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_SET_PTZPOS, 1, ptrPtzCfg, (UInt32)nSize))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_SetDVRConfig failed, error code= " + iLastErr;
                //设置POS参数失败
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("设置PTZ参数成功!");
            }

            Marshal.FreeHGlobal(ptrPtzCfg);//??
            return;
        }

        private void LoadPreSet()
        {
            UInt32 dwReturn = 0;
            Int32 nSize = Marshal.SizeOf(m_struPreSetCfg[0]);
            Int32 nOutBufSize = nSize * 300;
            IntPtr ptrPreSetCfg = Marshal.AllocHGlobal(nOutBufSize);
            int i;

            for (i = 0; i < 300; i++)
            {
                Marshal.StructureToPtr(m_struPreSetCfg[i], (IntPtr)((ptrPreSetCfg) + i * nSize), false);
                //Marshal.StructureToPtr(m_struPreSetCfg[i], (IntPtr)((Int32)(ptrPreSetCfg) + i * nSize), false); //ptrPreSetCfg溢出
            }
            //获取参数失败
            if (!CHCNetSDK.NET_DVR_GetDVRConfig(m_lUserID, CHCNetSDK.NET_DVR_GET_PRESET_NAME, 1, ptrPreSetCfg, (UInt32)nOutBufSize, ref dwReturn))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                MessageBox.Show(Errors[iLastErr]);
                //MessageBox.Show(str);
            }
            else
            {
                for (i = 0; i < 300; i++)
                {
                    m_struPreSetCfg[i] = (CHCNetSDK.NET_DVR_PRESET_NAME)Marshal.PtrToStructure((IntPtr)((ptrPreSetCfg) + i * nSize), typeof(CHCNetSDK.NET_DVR_PRESET_NAME));
                }
            }
            Marshal.FreeHGlobal(ptrPreSetCfg);
            return;

        }


        private void Camera_HeartBeatCallBack(object state)
        {
            Camera_HeartBeat.Change(Timeout.Infinite, Timeout.Infinite);
            lock (this)
            {
                if (!CHCNetSDK.NET_DVR_RemoteControl(m_lUserID, CHCNetSDK.NET_DVR_CHECK_USER_STATUS, IntPtr.Zero, 0))//检测设备是否在线
                {

                    Console.WriteLine("****心跳检测异常!!!****");
                    Console.WriteLine("{0:T}", System.DateTime.Now);
                    heart = heart + 1;
                    if (heart > 3)
                    {
                        heart = 0;
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_GetDVRConfig failed, error code= " + iLastErr;
                        //heartbeat.Stop();
                        string title = "Error  " + iLastErr;
                        //Message.KillMessageBox(title);
                        IntPtr ptr = MessageControl.FindWindow(null, "Error  " + iLastErr);
                        if (ptr == IntPtr.Zero)
                        {
                            MessageBox.Show(Errors[iLastErr], "Error  " + iLastErr);
                        }

                        //MessageBox.Show(str);
                        //heartbeat.Start();
                    }
                }
                else
                {
                    heart = 0;
                }
            }

            Camera_HeartBeat.Change(CHeartBeatInterval, CHeartBeatInterval);
        }
        #endregion
    }
}
