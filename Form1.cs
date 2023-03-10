using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_prakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (!CrptEngine.Is8Bytes(keyBox.Text))
            {
                check = false;
                keyWarningLabel.Show();
            }
            else
                keyWarningLabel.Hide();
            if (!CrptEngine.Is8Bytes(IVBox.Text))
            {
                check = false;
                IVWarningLabel.Show();
            }
            else
                IVWarningLabel.Hide();

            if (check)
            {
                resultBox.Text = CrptEngine.Encryption(textBox.Text, keyBox.Text, IVBox.Text);
                wrongFormatLabel.Hide();
                decryptionComplete.Hide();
                encryptionComplete.Show();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool check = true;
            if (!CrptEngine.Is8Bytes(keyBox.Text))
            {
                check = false;
                keyWarningLabel.Show();
            }
            else
                keyWarningLabel.Hide();
            if (!CrptEngine.Is8Bytes(IVBox.Text))
            {
                check = false;
                IVWarningLabel.Show();
            }
            else
                IVWarningLabel.Hide();

            if (check)
            {
                try
                {
                    resultBox.Text = CrptEngine.Decryption(textBox.Text, keyBox.Text, IVBox.Text);
                    encryptionComplete.Hide();
                    decryptionComplete.Show();
                    wrongFormatLabel.Hide();
                }
                catch (CryptographicException a)
                {
                    wrongFormatLabel.Show();
                    encryptionComplete.Hide();
                    decryptionComplete.Hide();
                    resultBox.Text = "";
                }
                catch (FormatException a)
                {
                    wrongFormatLabel.Show();
                    encryptionComplete.Hide();
                    decryptionComplete.Hide();
                    resultBox.Text = "";
                }
            }
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            keyWarningLabel.Hide();
            IVWarningLabel.Hide();
            encryptionComplete.Hide();
            decryptionComplete.Hide();
            wrongFormatLabel.Hide();
            textBox.Text = "";
            keyBox.Text = "";
            IVBox.Text = "";
            resultBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             saveFileDialog1.FileName = "";
             saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
             saveFileDialog1.FilterIndex = 2 ;
             saveFileDialog1.RestoreDirectory = true;
 
             if(saveFileDialog1.ShowDialog() == DialogResult.OK)
             {
                string fileName = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                    writer.Write(resultBox.Text);
             }


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(fileName))
                    textBox.Text = reader.ReadToEnd();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void keyWarningLabel_Click(object sender, EventArgs e)
        {

        }
    }
            
}

