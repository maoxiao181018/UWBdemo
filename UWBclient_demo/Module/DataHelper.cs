using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWBclient_demo
{
    public class DataHelper
    {
        public static string ByteToHex(byte comByte)//byte转16进制
        {
            return comByte.ToString("X2") + " ";
        }
        public static string ByteToHex(byte[] comByte, int len)//byte数组转16进制
        {
            string returnStr = "";
            if (comByte != null)
            {
                for (int i = 0; i < len; i++)
                {
                    returnStr += comByte[i].ToString("X2") + " ";
                }
            }
            return returnStr;
        }
        public static byte[] HexToByte(string msg)//16进制转byte数组
        {
            msg = msg.Replace(" ", "");

            byte[] comBuffer = new byte[msg.Length / 2];
            for (int i = 0; i < msg.Length; i += 2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            }

            return comBuffer;
        }
        public static string HEXToASCII(string data)//16进制转ASCII
        {
            data = data.Replace(" ", "");
            byte[] comBuffer = new byte[data.Length / 2];
            for (int i = 0; i < data.Length; i += 2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(data.Substring(i, 2), 16);
            }
            string result = Encoding.Default.GetString(comBuffer);
            return result;
        }
        public static string ASCIIToHEX(string data)//ASCII转16进制
        {
            StringBuilder result = new StringBuilder(data.Length * 2);
            for (int i = 0; i < data.Length; i++)
            {
                result.Append(((int)data[i]).ToString("X2") + " ");
            }
            return Convert.ToString(result);
        }
        /// <summary>
        /// 设备号进制转换：10进制转16进制
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static string DecToHex(int dec)
        {
            string result = dec.ToString("X2");
            return result;
            //while (result.Length < 4)
            //{
            //    result = "0" + result;
            //}
            //return result.Substring(0, 2) + " " + result.Substring(2, 2);
        }
        public static string DevHexToDec(string hex)
        {
            hex = hex.Replace(" ", "");
            int temp = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                temp += Convert.ToInt32(hex.Substring(i, 1)) * Convert.ToInt32(Math.Pow(16, 3 - i));//0001
            }
            return temp.ToString();
        }
        public static int HexToDec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        public static double[] xytoXY(int x, int y, int x_ld, int x_ru, double Xmax, int y_ld, int y_ru, double Ymax)//窗口坐标变实际坐标
        {
            double[] XY = new double[2];
            XY[0] = (double)(x - x_ld) / (x_ru - x_ld) * Xmax;
            XY[1] = (double)(y - y_ru) / (y_ru - y_ld) * Ymax + Ymax;
            return XY;
        }

        public static int[] XYtoxy(string[] XY, int x_ld, int x_ru, double Xmax, int y_ld, int y_ru, double Ymax)//实际坐标变窗口坐标
        {
            int[] xy = new int[2];
            double X = double.Parse(XY[0]);
            double x = X / Xmax * (x_ru - x_ld) + x_ld;
            if (x >= 0)
            {
                x = x + 0.5;
            }
            else
            {
                x = x - 0.5;
            }
            xy[0] = (int)(x);

            double Y = double.Parse(XY[1]);
            double y = ((Y - Ymax) / Ymax * (y_ru - y_ld) + y_ru);
            if (y >= 0)
            {
                y = y + 0.5;
            }
            else
            {
                y = y - 0.5;
            }
            xy[1] = (int)(y);
            return xy;
        }


    }
}
