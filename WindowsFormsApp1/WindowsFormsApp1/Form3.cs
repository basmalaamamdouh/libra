using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projectfile
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        FileStream myfile;
        StreamReader sr;
        StreamWriter sw;
        string filename;

        private void search_Click(object sender, EventArgs e)
        {
            int book_id = int.Parse(bookid.Text);            //id the user enter
            string record;
            string[] fields;
            while ((record = sr.ReadLine()) != null)
            {
                fields = record.Split(',');
                if (book_id == int.Parse(fields[0]))
                {
                    bookname.Text = fields[1];
                    author.Text = fields[2];
                    price.Text = fields[3];
                    MessageBox.Show("found");
                    return;
                }

            }

            MessageBox.Show("Not found");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.Cancel) { return; }
            filename = fd.FileName;
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(myfile);
            sr = new StreamReader(myfile);
            MessageBox.Show("File is opened");
            search.Enabled = true;
            add.Enabled = true;
            delete.Enabled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bookname.Text =  price.Text = author.Text = null;
            myfile.Seek(0, SeekOrigin.Begin);
            myfile.Flush();
            sw.Flush();

            string record;
            string[] fields;
            int steps = 0;

            while ((record = sr.ReadLine()) != null)
            {
                fields = record.Split(',');
                int BookID = int.Parse(bookid.Text);
                if (BookID == int.Parse(fields[0]))
                {
                    myfile.Seek(steps, SeekOrigin.Begin);
                    sw.Write("*");
                    sw.Flush();

                    MessageBox.Show("Book Deleted!!");
                }
                steps += record.Length + 2;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string record = bookid.Text + "," + bookname.Text + "," + author.Text + "," + price.Text;
            sw.WriteLine(record);
            sw.Flush();
            MessageBox.Show("Record saved");
        }

        private void seeall_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\mamdo\\Downloads\\books file.txt";
            var bookNames = File.ReadAllLines(filePath)
                                .Select(line => line.Split(',')[1].Trim())
                                .Distinct()
                                .ToArray();

            string allBookNames = string.Join("\n", bookNames);
            MessageBox.Show(allBookNames, "Book Names", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }
