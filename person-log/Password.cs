using System.Security.Cryptography;
using System.Text;

namespace person_log
{
    class Password
    {
        public static bool checkPassword(string password,string pwhash, string salt)
        {
            string plainSaltedPW = salt + password + salt; /* change this if you want your own method of salting */

            using (SHA256 sha256Hash = SHA256.Create())
            {
                /* from https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/ */

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainSaltedPW));
                
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return pwhash == builder.ToString();
            }
        }
    }
}
