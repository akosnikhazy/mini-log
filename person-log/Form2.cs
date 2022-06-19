using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace person_log
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Directory.CreateDirectory("log");
            FillList();

        }

        private void FillList() {
            loglist.Items.Clear();
            reader.Text = "";
            string[] files = Directory.GetFiles("log", "*.log");
            foreach (var file in files)
            {
                loglist.Items.Add(file.Split('\\')[1]);
            }
        }

        private void post_Click(object sender, EventArgs e)
        {

            String file = "";
            String name = nameText.Text;
            String text = textText.Text;

            String[] nameParts = name.Split(" ".ToCharArray());

            /* KEEPING GATES */
            if (name == "" || text == "")
            {
                MessageBox.Show("You have to fill everything!");
                return;
            }

            foreach (String namePart in nameParts)
            {
                if (namePart.Any(ch => !Char.IsLetterOrDigit(ch)))
                {
                    MessageBox.Show("The name can be only letters and digits!");
                    return;
                }
            }

            /* START THE WORK */
            file = "log/" + name.Replace(' ', '-') + ".log";

            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine(Encryption.EncryptString(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ";" + text));
            }
            FillList();
            nameText.Text = "";
            textText.Text = "";
        }

        private void loglist_DoubleClick(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the ToolStripItem.DoubleClick event.");
        }

        private void openSelectedLog_Click(object sender, EventArgs e)
        {


            if(loglist.SelectedIndex > -1) {
                string fileName = loglist.SelectedItem.ToString();
                reader.Text = "[-----" + fileName + "-----]" + Environment.NewLine + Environment.NewLine;
                string[] lines;
                using (StreamReader reader = new StreamReader("log/" + fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        lines = Encryption.DecryptString(line).Split(';');
                        this.reader.Text += "[" + lines[0] + "] " + lines[1] + Environment.NewLine + Environment.NewLine;

                    }

                }

            }
        }

    }
    
}
