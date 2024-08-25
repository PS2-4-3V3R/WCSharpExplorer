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
        struct FileFolder
        {
            public string entries;
            public int type;
        }
        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            system("");

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
                //Console.WriteLine("====== getFileNames =======");
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
            return FF;
        }

        void ShowDir(List<FileFolder> FF, string path_current)
        {
            TXTB_Path.Text = path_current;
            Console.WriteLine("====== OUTPUT =======");
            for (int i = 0; i < FF.Count(); i++)
            {
                Console.WriteLine(FF[i].entries);
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
            Console.WriteLine(FFS);
            ChangeDirectory(FFS);
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            Console.WriteLine("====== BACK =======");
            string path_back = Directory.GetCurrentDirectory().Remove(Directory.GetCurrentDirectory().Length - Directory.GetCurrentDirectory().Split('\\').Last().Length, Directory.GetCurrentDirectory().Split('\\').Last().Length);
            Console.WriteLine("path_back"+path_back);
            ChangeDirectory(path_back);
            Console.WriteLine("Currentdirectory"+Directory.GetCurrentDirectory());
        }
    }
}
