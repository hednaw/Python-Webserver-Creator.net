using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Python_Webserver_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SendPort(int PortNum, String Path)
        {
            Directory.SetCurrentDirectory(Path);
            string CreateServerCMD = "/C python -m SimpleHTTPServer " + PortNum;
            System.Diagnostics.Process.Start("CMD.exe", CreateServerCMD);
            System.Diagnostics.Process.Start("http://localhost:" + PortNum + "/");
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String PortString = PortTextbox.Text;
            bool isPortNumeric = Regex.IsMatch(PortString, @"^\d+$");
            String ServerPath = PathTextBox.Text;
            //if (isPortNumeric == true) { Console.WriteLine("Port is numeric"); } else { Console.WriteLine("Port is not numeric "); }
            //ErrorLabel.Text = PortString;


            if (ServerPath == null)
            {
                ErrorLabel.Text = "Path is null";
            }

            if (PortString == null || PortString == "Port" || isPortNumeric == false)
            {
                ErrorLabel.Text = "Wrong port format";
            }

            if (isPortNumeric == true && ServerPath != null)
            {
                int PortInt = Convert.ToInt32(PortString);
                SendPort(PortInt, ServerPath);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                PathTextBox.Text = folderPath;
            }
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
