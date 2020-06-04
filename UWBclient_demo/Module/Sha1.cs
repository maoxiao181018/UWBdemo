using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace UWBclient_demo
{
    class Sha1
    {

        public static string secret_key = "7cdc5ef8ata3bd8754a572de958b7e06";
        
        public static string encrypt(string account, string password)
        {
            string cipher = SHA1(account + password + secret_key);
            return cipher;
        }

        public string[] Sign_Gen()
        {
            string[] signature = new string[3];
            string TimeStamp = GetTimeStamp();
            string RandomNumber = GetRandom();
            signature[0] = TimeStamp;
            signature[1] = RandomNumber;
            signature[2] = SHA1(secret_key + TimeStamp + RandomNumber);
            return signature;
        }

        /// <summary>  
        /// SHA1 加密，返回大写字符串  
        /// </summary>  
        /// <param name="content">需要加密字符串</param>  
        /// <returns>返回40位UTF8 大写</returns>  
        public static string SHA1(string content)
        {
            return SHA1(content, Encoding.UTF8);
        }
        /// <summary>  
        /// SHA1 加密，返回大写字符串  
        /// </summary>  
        /// <param name="content">需要加密字符串</param>  
        /// <param name="encode">指定加密编码</param>  
        /// <returns>返回40位大写字符串</returns>  
        public static string SHA1(string content, Encoding encode)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] bytes_in = encode.GetBytes(content);
                byte[] bytes_out = sha1.ComputeHash(bytes_in);
                sha1.Dispose();
                string result = BitConverter.ToString(bytes_out);
                result = result.Replace("-", "");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }


        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        //获取随机数
        public static string GetRandom()
        {
            Random rad = new Random();//实例化随机数产生器rad；
            int value = rad.Next(1000, 10000);//用rad生成大于等于1000，小于等于9999的随机数；
            string suijishu = value.ToString(); //转化为字符串；
            return suijishu;
        }


    }
}
