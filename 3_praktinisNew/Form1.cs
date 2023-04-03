using System;
using System.Numerics;
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

namespace _3_prakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CrptEngine.CheckStringFormat(PubKeyBox.Text))
            {
                string[] splitInput = PubKeyBox.Text.Split(',');

                resultBox.Text = CrptEngine.encryptorEngine(textBox.Text, BigInteger.Parse(splitInput[0]), BigInteger.Parse(splitInput[1]));
            } else
                System.Windows.Forms.MessageBox.Show("Wrong public key format");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CrptEngine.CheckStringFormat(PrivKeyBox.Text))
            {
                string[] splitInput = PrivKeyBox.Text.Split(',');
                resultBox.Text = CrptEngine.decryptorEngine(textBox.Text, BigInteger.Parse(splitInput[0]), BigInteger.Parse(splitInput[1]));
            }
            else
                System.Windows.Forms.MessageBox.Show("Wrong private key format");
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
            PBox.Text = "";
            QBox.Text = "";
            PubKeyBox.Text = "";
            PrivKeyBox.Text = "";
            textBox.Text = "";
            resultBox.Text = "";
        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFile(resultBox.Text);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox.Text = openFile();
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

        private void encryptionModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public String openFile()
        {
            String text = "";
            Stream stream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(fileName))
                    text = reader.ReadToEnd();
            }
            return text;
        }

        public void saveFile(String text)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                    writer.Write(text);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            saveFile(PubKeyBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFile(PrivKeyBox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PubKeyBox.Text = openFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrivKeyBox.Text = openFile();
        }

        private void PubKeyGenButton_Click(object sender, EventArgs e)
        {
            if(PQCheck())
            {
                PubKeyBox.Text = CrptEngine.keyGen(BigInteger.Parse(PBox.Text), BigInteger.Parse(QBox.Text), true);
            }
        }

        private bool PQCheck()
        {
            string pText = PBox.Text, qText = QBox.Text;
            if (pText == "" || qText == "")
                System.Windows.Forms.MessageBox.Show("P or Q text box is empty!");
            else if (!CrptEngine.checkIfNumOnly(pText) || !CrptEngine.checkIfNumOnly(qText))
                System.Windows.Forms.MessageBox.Show("P or Q must be numbers only!");
            else
            {
                BigInteger p = BigInteger.Parse(pText);
                BigInteger q = BigInteger.Parse(qText);

                if (CrptEngine.IsPrime(p) && CrptEngine.IsPrime(q))
                {
                    return true;
                }
                else
                    System.Windows.Forms.MessageBox.Show("P or Q must be prime numbers!");
            }
            return false;
        }

        private void PrivKeyGenButton_Click(object sender, EventArgs e)
        {
            if (PQCheck())
            {
                PrivKeyBox.Text = CrptEngine.keyGen(BigInteger.Parse(PBox.Text), BigInteger.Parse(QBox.Text), false);
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CrptEngine.CheckStringFormat(PubKeyBox.Text))
            {
                string[] splitInput = PubKeyBox.Text.Split(',');
                BigInteger[] arr = CrptEngine.PQfinder(BigInteger.Parse(splitInput[1]));
                if (arr[0] == 0 && arr[1] == 0)
                    System.Windows.Forms.MessageBox.Show("Impossible to find prime p and q");
                else
                    PBox.Text = arr[0].ToString();
                    QBox.Text = arr[1].ToString();
            }
            else
                System.Windows.Forms.MessageBox.Show("Wrong public key format");


        }
    }
            
}

