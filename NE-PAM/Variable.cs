using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;

namespace NE_PAM
{
    public class Variable
    {
        //-----------------------------------------------------------
        // 프로그램 빌드 시간
        //-----------------------------------------------------------
        public static String getBuildDateTime()
        {
            DateTime datetime = new DateTime(2000, 1, 1);
            datetime = datetime.AddDays(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build);
            datetime = datetime.AddSeconds(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision * 2);

            return datetime.ToString("yyyyMMdd.HHmmss");
        }
    }

    public class IniFile
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        // INI 값 읽기 
        public static String GetIniValue(String Section, String Key, String iniPath)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, iniPath);
            return temp.ToString();
        }

        // INI 값 설정 
        public static void SetIniValue(String Section, String Key, String Value, String iniPath)
        {
            WritePrivateProfileString(Section, Key, Value, iniPath);
        }

        public static void GetVmsConfig(out String VmsIP, out uint VmsPort, out String VmsID, out String VmsPasswd)
        {
            String iniPath = Application.StartupPath + "\\" + "config.ini";

            VmsIP = GetIniValue("VMS", "IP", iniPath);
            VmsPort = UInt32.Parse(GetIniValue("VMS", "PORT", iniPath));
            VmsID = GetIniValue("VMS", "ID", iniPath);
            VmsPasswd = EncyptUtil.DecryptString(GetIniValue("VMS", "PASSWD", iniPath));
        }

        public static void GetOraConfig(ref String IP, ref String PORT, ref String Path, ref String ID, ref String Passwd)
        {
            String iniPath = Application.StartupPath + "\\" + "config.ini";

            IP = GetIniValue("DB", "IP", iniPath);
            PORT = GetIniValue("DB", "PORT", iniPath);
            Path = GetIniValue("DB", "SID", iniPath);
            ID = GetIniValue("DB", "ID", iniPath);
            Passwd = GetIniValue("DB", "PASSWD", iniPath);
        }

        public static int GetSaveTermMin()
        {
            String iniPath = Application.StartupPath + "\\" + "config.ini";

            String sValue = GetIniValue("OPERATION", "TERM", iniPath);
            return sValue == "" ? 10 : Int32.Parse(sValue);
        }

        public static String GetHomePath()
        {
            String iniPath = Application.StartupPath + "\\" + "config.ini";
            return GetIniValue("OPERATION", "HOME", iniPath);
        }

        public static String GetAutoStartYn()
        {
            String iniPath = Application.StartupPath + "\\" + "config.ini";
            String sYN = GetIniValue("OPERATION", "AUTO-START", iniPath);

            return sYN == "예" ? "Y" : "N";
        }
    }

    //-----------------------------------------------------
    // 암호화 / 복호화
    //-----------------------------------------------------
    public class EncyptUtil
    {
        public static string PasswordKey = "sdfj32kh%$ &aKh45gLdf 234^@#@ Jf%^412Jf6@#H";
        /// <summary>
        /// AES to Base64 암호화
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>

        public static string EncryptString(string text)
        {
            byte[] inputText = System.Text.Encoding.Unicode.GetBytes(text);
            byte[] passwordSalt = Encoding.ASCII.GetBytes(PasswordKey.Length.ToString());
            PasswordDeriveBytes secretKey = new PasswordDeriveBytes(PasswordKey, passwordSalt);

            Rijndael rijAlg = Rijndael.Create();
            rijAlg.Key = secretKey.GetBytes(32);
            rijAlg.IV = secretKey.GetBytes(16);

            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            csEncrypt.Write(inputText, 0, inputText.Length);
            csEncrypt.FlushFinalBlock();
            byte[] encryptBytes = msEncrypt.ToArray();
            msEncrypt.Close();
            csEncrypt.Close();

            // Base64 
            string encryptedData = Convert.ToBase64String(encryptBytes);
            return encryptedData;
        }

        /// <summary>
        /// AES to Base64 복호화
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string DecryptString(string text)
        {
            byte[] encryptedData = Convert.FromBase64String(text);
            byte[] passwordSalt = Encoding.ASCII.GetBytes(PasswordKey.Length.ToString());
            PasswordDeriveBytes secretKey = new PasswordDeriveBytes(PasswordKey, passwordSalt);

            Rijndael rijAlg = Rijndael.Create();
            rijAlg.Key = secretKey.GetBytes(32);
            rijAlg.IV = secretKey.GetBytes(16);

            ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
            MemoryStream msDecrypt = new MemoryStream(encryptedData);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            int decryptedCount = csDecrypt.Read(encryptedData, 0, encryptedData.Length);

            msDecrypt.Close();
            csDecrypt.Close();

            // Base64 
            string decryptedData = Encoding.Unicode.GetString(encryptedData, 0, decryptedCount);
            return decryptedData;
        }

        public static string SHA256(string text)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] hashValue = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(text));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashValue)
                sb.AppendFormat("{0:X2}", b);

            return sb.ToString();
        }        
    }
}
