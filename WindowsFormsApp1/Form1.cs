using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;
//using System.Reflection.Metadata;
//using Document = iTextSharp.text.Document;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public long size;
        public Form1()
        {
            InitializeComponent();
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            //size = Convert.ToInt64(textBox1.Text);
            PdfCreation();
        }
        internal void PdfCreation()
        {
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(@"C:\Users\Public\WriteLines2.txt", text);
            do
            {
                File.AppendAllText(@"C:\Users\Public\hello.pdf", text + Environment.NewLine);
                FileInfo info = new FileInfo(@"C:\Users\Public\hello.pdf");
                size = Convert.ToInt64(textBox1.Text);
            } while (size < 1048576);
        }
        internal string IsFolderExist(string folderName)
        {
            string subPath = new FileInfo(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + "\\" + folderName;

            bool isExists = System.IO.Directory.Exists(subPath);
            if (!isExists)
                System.IO.Directory.CreateDirectory(subPath);
            return subPath;
        }
       
    }
}
