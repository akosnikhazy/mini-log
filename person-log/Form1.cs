using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace person_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory("ini");

            if (!File.Exists("ini/user.txt")) {
                MessageBox.Show("Please create an user.txt file in the ini folder. The file should contain one line: username;passwordsha256(salt.password.salt);salt");
            }
            /* user file is:
             * File name: user.txt
             * Content is one line
             * username;passwordhash;salt
             * Make a password hash like this:
             * sha256('salt.password.salt')
             *
             * change the password class's hashing mechanism for your own password protection
             */

       
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string[] userData = File.ReadLines("ini/user.txt").First().Split(';');


            if (userData[0] != userName.Text || !Password.checkPassword(password.Text, userData[1], userData[2])) {

                MessageBox.Show("invalid username or password");
                return;
            }

            Form2 mainform = new Form2();
            mainform.Show();

            userName.Text = password.Text = "";
            
        }

        
    }
}
