using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyQuanCafe
{
    public class MaHoaPassword
    {
        private const string PUBLIC_KEY = "02PTPM";

        public MaHoaPassword()
        { 
        }

        public string Encrypt(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            byte[] bytesIn = Encoding.UTF8.GetBytes(value);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(PUBLIC_KEY);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desencrypt = des.CreateEncryptor();
            CryptoStream cryptStream = new CryptoStream(msOut, desencrypt, CryptoStreamMode.Write);
            cryptStream.Write(bytesIn, 0, bytesIn.Length);
            cryptStream.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();

            cryptStream.Close();
            msOut.Close();
            return Convert.ToBase64String(bytesOut);
        }

        public string Decrypt(string encryptedValue)
        {
            if (string.IsNullOrEmpty(encryptedValue))
            {
                return string.Empty;
            }

            byte[] bytesIn = Convert.FromBase64String(encryptedValue);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] bytesKey = Encoding.UTF8.GetBytes(PUBLIC_KEY);
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);
            des.Key = bytesKey;
            des.IV = bytesKey;
            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateDecryptor();
            CryptoStream cryptStream = new CryptoStream(msOut, desdecrypt, CryptoStreamMode.Write);
            cryptStream.Write(bytesIn, 0, bytesIn.Length);
            cryptStream.FlushFinalBlock();
            byte[] bytesOut = msOut.ToArray();

            cryptStream.Close();
            msOut.Close();
            return Encoding.UTF8.GetString(bytesOut);
        }
    }
}
