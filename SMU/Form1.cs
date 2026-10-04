using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
namespace SMU
{
    public partial class Form1 : Form
    {
        private string userbilde;
        private string configFilePath = "userbilde.txt";
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            userbilde_Load();
            LoadUserBilde();
            

        }


        private void userbilde_Load()
        {
            if (File.Exists(configFilePath))
            {
                userbilde = File.ReadAllText(configFilePath);

            }
            else
            {
                userbilde = "default_value"; // Set a default value if the file doesn't exist}
            }
        }

        private void SaveUserBilde(string value)
        {
            File.WriteAllText(configFilePath, userbilde);
        }


        private void LoadUserBilde()
        {
            if (File.Exists(userbilde))
            {
                pic1.ImageLocation = userbilde;
            }
            else
            {
                pic1.Image = null; // Set a default image or handle the case when the file doesn't exist
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            string jautajums = txbjautajums.Text;
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    userbilde = openFileDialog.FileName;
                    LoadUserBilde();
                    SaveUserBilde(userbilde);
                }
                

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image: " + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}