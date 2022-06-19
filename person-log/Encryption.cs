using System;
using System.Text;

/* 
  I use here childish ways of encription, you should implement your own. I just put this here as a
  possibility to make this app more secure if you want to use it seriously. Base64 is good against
  complete laymen finding your logs. Modify this class so you can use some big boy encryption.
*/

namespace person_log
{
    class Encryption
    {
        public static string EncryptString(string plainText, string key = "if you change this class, you'll have a key for sure")
        { 
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
        }

        public static string DecryptString(string cipherText, string key = "if you do normal encryption you will need this too")
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(cipherText));
        }
    }
}
