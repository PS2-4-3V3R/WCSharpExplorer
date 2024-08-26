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

        string GetExtension(string file)
        {
            if (console) Console.WriteLine("\u001b[38;2;255;0;0m" + file.Split('.').Last() + "\u001b[0m");
            return file.Split('.').Last();
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
                if (console) Console.WriteLine("[Info]: Item = "+item);
                string extension = GetExtension(item);
                FF_temp.entries = item;
                switch (extension)
                {
                    case "exe":
                        FF_temp.type = 2;
                        break;
                    case "txt":
                        FF_temp.type = 3;
                        break;
                    case "rar":
                        FF_temp.type = 4;
                        break;
                    case "png":
                        FF_temp.type = 5;
                        break;
                    case "cs":
                        FF_temp.type = 6;
                        break;
                    case "resx":
                        FF_temp.type = 7;
                        break;
                    case "sln":
                        FF_temp.type = 8;
                        break;
                    default:
                        FF_temp.type = 1;
                        break;
                }
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

        void ShowDir(List<FileFolder> FF, string path_current = "► Ruta desconocida ◄")
        {
            if (console) Console.WriteLine(regionColor+"\u001b[2K====== OUTPUT =======\u001b[0m");
            TXTB_Path.Text = path_current;
            if (FF.Count() != 1) { TXT_Elements.Text = FF.Count().ToString() + " elementos"; }
            else { TXT_Elements.Text = FF.Count().ToString() + " elemento"; }
            for (int i = 0; i < FF.Count(); i++)
            {
                if (console) Console.WriteLine("Entrana nº "+i+" = "+FF[i].entries);
                listView1.Items.Add(FF[i].entries, FF[i].type);
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
            listView1.Size = this.Size - new Size(40,128);
            BTN_GotoPath.Location = ((Point)this.Size) - new Size(103,this.Size.Height-27);
            TXTB_Path.Size = this.Size - new Size(177,this.Size.Height);
            BTN_LargeIcon.Location = ((Point)this.Size) - new Size(52, 68);
            BTN_List.Location = ((Point)this.Size) - new Size(75, 68);
            BTN_Tile.Location = ((Point)this.Size) - new Size(98, 68);
        }

        private void consolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllocConsole();
            system("");
            console = true;
        }

        private void iconosGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void mosaicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void BTN_LargeIcon_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void BTN_List_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void BTN_Tile_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
