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
using static projectfile.Class1;

namespace projectfile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }
        FileStream signupfile;
        // StreamWriter sw;
        string filename, record;
        StreamReader sr;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filename = "C:\\Users\\mamdo\\Downloads\\Users.txt";        
            signupfile = new FileStream(filename, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(signupfile);
            record = sr.ReadLine();
            string[] check;
            while (record != null)
            {
                check = record.Split(',');
                if (textBox1.Text == check[0] && textBox2.Text == check[1])
                {

                    MessageBox.Show("found");
                    this.Hide();
                   Form3 form3 = new Form3();
                    form3.Show();
                    return;

                }
                record = sr.ReadLine(); // Advance to the next line
            }
            MessageBox.Show("not found");


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
