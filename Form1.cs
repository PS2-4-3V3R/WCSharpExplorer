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
        //#######################################################
        public static bool console;
        public static string regionColor = "\u001b[48;2;0;128;128m";
        struct FileFolder
        {
            public string entries;
            public int type;
        }
        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
            //system("");

            ShowDir(GetDirs(Directory.GetCurrentDirectory()), Directory.GetCurrentDirectory());
        }

        void ChangeDirectory(string path_new)
        {
            Directory.SetCurrentDirectory(path_new);
            listView1.Clear();
            ShowDir(GetDirs(Directory.GetCurrentDirectory()), Directory.GetCurrentDirectory());
        }

        List<FileFolder> GetDirs(string path_folder)
        {
            List<FileFolder> FF = new List<FileFolder>();
            FileFolder FF_temp;
            foreach (string item in GetDirsOnly("D")) //Directories or folders
            {
                FF_temp.entries = item;
                FF_temp.type = 0;
                FF.Add(FF_temp);
            }
            foreach (string item in GetDirsOnly("A")) //Files
            {
                FF_temp.entries = item;
                FF_temp.type = 1;
                FF.Add(FF_temp);
            }
            //FUNCTION
            string[] GetDirsOnly(string arg)
            {
                if (console) Console.WriteLine(regionColor+"\u001b[2K====== GetDirsOnly " + arg+ " ======\u001b[0m");
                List<string> file_PnE;
                switch (arg)
                {
                    case "A":
                        file_PnE = Directory.GetFiles(path_folder).ToList(); //file_PnE = file path and extension
                        break;
                    case "D":
                        file_PnE = Directory.GetDirectories(path_folder).ToList(); //file_PnE = file path and extension
                        break;
                    default:
                        if (console) Console.WriteLine("[ERROR]: in dir function");
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
            return FF;
        }

        void ShowDir(List<FileFolder> FF, string path_current)
        {
            TXTB_Path.Text = path_current;
            if (console) Console.WriteLine(regionColor+"\u001b[2K====== OUTPUT =======\u001b[0m");
            for (int i = 0; i < FF.Count(); i++)
            {
                if (console) Console.WriteLine(FF[i].entries);
                listView1.Items.Add(FF[i].entries, FF[i].type);
                listView1.LargeImageList = listView1.LargeImageList;
            }
        }

        private void BTN_GotoPath_Click(object sender, EventArgs e)
        {
            ChangeDirectory(TXTB_Path.Text);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string FFS = listView1.SelectedItems[0].Text.ToString(); //File Folder Selected
            if (console) Console.WriteLine(FFS);
            ChangeDirectory(FFS);
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            if (console) Console.WriteLine(regionColor+"\x1b[2K====== BACK =======\x1b[0m");
            string path_back = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - Directory.GetCurrentDirectory().Split('\\').Last().Length, Directory.GetCurrentDirectory().Split('\\').Last().Length);
            if (console) Console.WriteLine("path_back = "+path_back);
            ChangeDirectory(path_back);
            if (console) Console.WriteLine("Currentdirectory = "+Directory.GetCurrentDirectory());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            listView1.Size = this.Size - new Size(40,107);
            BTN_GotoPath.Location = ((Point)this.Size) - new Size(103,this.Size.Height-27);
            TXTB_Path.Size = this.Size - new Size(177,this.Size.Height);
        }

        private void consolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllocConsole();
            system("");
            console = true;
        }
    }
}
