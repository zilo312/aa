using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Wrox.ProCSharp.Security
{
   class Program
   {
      static void Main()
      {
         string text = "secret message";
         string encryptedString = EncryptString(text, "password");

         Console.WriteLine(" original string: {0}", text);
         Console.WriteLine("encrypted string: {0}", encryptedString);

         string decryptedString = DecryptString(encryptedString, "password");

         Console.WriteLine("decrypted string: {0}", decryptedString);
      }

      private static string DecryptString(string encryptedText, string password)
      {
         byte[] rawData = Convert.FromBase64String(encryptedText);
         Aes aes = AesManaged.Create();

         // setup the decryption algorithm
         int nBytes = aes.BlockSize >> 3;
         byte[] salt = new byte[nBytes];
         for (int i = 0; i < salt.Length; i++)
            salt[i] = rawData[i];

         Rfc2898DeriveBytes generateKeys = new Rfc2898DeriveBytes("password", salt);

         aes.Key = generateKeys.GetBytes(aes.BlockSize >> 3);
         aes.IV = salt;

         using (MemoryStream stream = new MemoryStream())
         using (ICryptoTransform decryptor = aes.CreateDecryptor())
         {
            CryptoStream cryptoStream = new CryptoStream(stream, decryptor, CryptoStreamMode.Write);

            cryptoStream.Write(rawData, nBytes, rawData.Length - nBytes);
            cryptoStream.Close();

            byte[] decryptedData = stream.ToArray();

            return Encoding.UTF8.GetString(decryptedData);
          }

      }



      private static string EncryptString(string text, string password)
      {
         byte[] rawData = Encoding.UTF8.GetBytes(text);

         Aes aes = AesManaged.Create();
         int nBytes = aes.BlockSize >> 3;
         Rfc2898DeriveBytes generateKeys = new Rfc2898DeriveBytes(password, nBytes);
         aes.Key = generateKeys.GetBytes(nBytes);
         aes.IV = generateKeys.Salt;

         using (MemoryStream memoryStream = new MemoryStream())
         using (ICryptoTransform encryptor = aes.CreateEncryptor())
         {
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            memoryStream.Write(generateKeys.Salt, 0, generateKeys.Salt.Length);
            cryptoStream.Write(rawData, 0, rawData.Length);
            cryptoStream.Close();

            byte[] encrytedData = memoryStream.ToArray();

            return Convert.ToBase64String(encrytedData);
         }
      }
   }
}
