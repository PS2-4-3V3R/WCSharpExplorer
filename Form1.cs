#pragma warning disable IDE1006

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;

namespace WCSharpExplorer
{
    public partial class Form1 : Form
    {
        [DllImport("msvcrt.dll")]
        public static extern int system(string format);
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            system("");
        }

        string[] GetDir(string address, string arg)
        {
            //Console.WriteLine("====== getFileNames =======");
            List<string> file_PnE;
            switch (arg)
            {
                case "A":
                    file_PnE = Directory.GetFiles(address).ToList(); //file_PnE = file path and extension
                    break;
                case "D":
                    file_PnE = Directory.GetDirectories(address).ToList(); //file_PnE = file path and extension
                    break;
                default:
                    Console.WriteLine("[ERROR]: in dir function");
                    string[] err = { "ERROR" };
                    return err;
            }
            List<string> file_E = new List<string>();
            foreach (string f in file_PnE)
            {
                file_E.Add(f.Split('\\').Last());
                //System.Console.WriteLine(file_E.Last());
            }
            return file_E.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>();
            List<int> files_type = new List<int>();
            foreach (string item in GetDir("C:\\PMBM\\C#\\WCSharpExplorer", "D"))
            {
                files.Add(item);
                files_type.Add(0);
            }
            foreach (string item in GetDir("C:\\PMBM\\C#\\WCSharpExplorer", "A"))
            {
                files.Add(item);
                files_type.Add(1);
            }
            Console.WriteLine("====== OUTPUT =======");
            for (int i = 0; i < files.Count(); i++)
            {
                Console.WriteLine(files[i]);
                listView1.Items.Add(files[i], files_type[i]);
                listView1.LargeImageList = listView1.LargeImageList;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tal = listView1.SelectedItems[0].Text.ToString();
            Console.WriteLine(tal);
        }
    }
}
