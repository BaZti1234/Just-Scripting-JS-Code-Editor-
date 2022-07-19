using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using JS_Code_Editor.Class;

namespace JS_Code_Editor
{
    public partial class MainFrm : Form
    {
        //Colors ->:
        public static Brush cyanBrush = new SolidBrush(Color.FromArgb(37, 192, 255));
        public static Brush yellowBrush = new SolidBrush(Color.FromArgb(215,255,37));
        public static Brush redBrush = new SolidBrush(Color.FromArgb(255,0,0));
        public static Brush orangeBrush = new SolidBrush(Color.FromArgb(255, 124, 0));
        public static Brush purpleBrush = new SolidBrush(Color.FromArgb(151, 0, 255));
        public static Brush magentaBrush = new SolidBrush(Color.FromArgb(255, 38, 212));
        public static Brush grayBrush = new SolidBrush(Color.FromArgb(80,80,80));
        public TextStyle cyan = new TextStyle(cyanBrush, null, FontStyle.Regular);
        public TextStyle yellow = new TextStyle(yellowBrush, null, FontStyle.Regular);
        public TextStyle red = new TextStyle(redBrush, null, FontStyle.Regular);
        public TextStyle orange = new TextStyle(orangeBrush, null, FontStyle.Regular);
        public TextStyle purple = new TextStyle(purpleBrush, null, FontStyle.Regular);
        public TextStyle magenta = new TextStyle(magentaBrush, null, FontStyle.Regular);
        public TextStyle gray = new TextStyle(grayBrush, null, FontStyle.Regular);

        public Point mouseLocation;
        public bool isCollapsed;
        private GraphicUserInterface gui;
        private Config config;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public MainFrm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            gui = new GraphicUserInterface();
            config = new Config();

            tb_Code.Language = FastColoredTextBoxNS.Language.JS;
            tb_ZoomValue.Text = tb_Code.Zoom.ToString() + "%";
            this.Opacity = 1;
            tb_Opacity.Text = this.Opacity.ToString();
        }

        private void panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            gui.exitApplication();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            gui.minimizeForm();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            timer_File.Start();
        }

        private void timer_File_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                if (isCollapsed)
                {
                    panel_File.Height += 4;
                    if (panel_File.Size == panel_File.MaximumSize)
                    {
                        timer_File.Stop();
                        isCollapsed = false;
                    }
                }
            }
            else
            {
                panel_File.Height -= 4;
                if (panel_File.Size == panel_File.MinimumSize)
                {
                    timer_File.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            openFolder();
        }

        private void pb_Rename_Click(object sender, EventArgs e)
        {
            renameFile();
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            exportFile();
        }

        private void btn_ExportAsZip_Click(object sender, EventArgs e)
        {
            exportAsZIP();
        }

        private void btn_AddZoom_Click(object sender, EventArgs e)
        {
            addValueToZoom();
        }

        private void btn_MinusZoom_Click(object sender, EventArgs e)
        {
            subtractValueFromZoom();
        }

        private void btn_AddOpacity_Click(object sender, EventArgs e)
        {
            addValueToOpacity();
        }

        private void btn_MinusOpacity_Click(object sender, EventArgs e)
        {
            subtractValueFromOpacity();
        }

        public void openFolder() 
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo($"{fbd.SelectedPath}");

                    if (directoryInfo.Exists)
                    {
                        tv_Files.AfterSelect += Tv_Files_AfterSelect1;
                        buildTree(directoryInfo, tv_Files.Nodes);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void renameFile() 
        {
            try
            {
                string filePath = tv_Files.SelectedNode.Name;

                FileInfo fileInfo = new FileInfo(filePath);
                fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + tb_CurrentNode.Text);

                tv_Files.SelectedNode.Name = fileInfo.Directory.FullName + "\\" + tb_CurrentNode.Text;
                tv_Files.SelectedNode.Text = tb_CurrentNode.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong, try agagin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void saveFile() 
        {
            try
            {
                string filePath = tv_Files.SelectedNode.Name;

                StreamWriter sw = new StreamWriter(filePath);

                sw.Write(tb_Code.Text);

                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("You doesn't selected file or your file tree is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void exportFile()
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = tv_Files.SelectedNode.Text;
                    string sourcePath = tv_Files.SelectedNode.Name;
                    File.Copy(sourcePath, fbd.SelectedPath + "\\" + fileName, true);
                    MessageBox.Show("File exported", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void exportAsZIP() 
        {
            try
            {
                string output = config.defPathToSave + $"code-{DateTime.Now.Millisecond}.zip";
                string fileToZip = tv_Files.SelectedNode.Name;

                using (var archive = ZipFile.Open(output, ZipArchiveMode.Create)) 
                {
                    archive.CreateEntryFromFile(fileToZip, Path.GetFileName(fileToZip));
                }

                MessageBox.Show("File exported as zip", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addValueToZoom() 
        {
            tb_Code.Zoom += 15;
        }

        public void subtractValueFromZoom() 
        {
            tb_Code.Zoom -= 15;
        }

        public void addValueToOpacity() 
        {
            this.Opacity += .20;
            tb_Opacity.Text = this.Opacity.ToString();
        }

        public void subtractValueFromOpacity() 
        {
            if(this.Opacity > .80) 
            {
                this.Opacity -= .20;
            }
            tb_Opacity.Text = this.Opacity.ToString();
        }

        private void Tv_Files_AfterSelect1(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Text.Contains(".js"))
                {
                    StreamReader reader = new StreamReader(e.Node.Name);
                    this.tb_Code.Text = reader.ReadToEnd();
                    reader.Close();
                }

                tb_CurrentNode.Text = e.Node.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe) 
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                buildTree(subdir, curNode.Nodes);
            }
        }

        private void tb_Code_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearStyle(cyan, yellow, red, orange, purple, magenta, gray);
            e.ChangedRange.SetStyle(cyan, "(import)|(document)|(toString)|(length)|(call)|(bind)|(append)|(from)");
            e.ChangedRange.SetStyle(yellow, "(var)|(parentElement)|(parentNode)|(title)");
            e.ChangedRange.SetStyle(red, "(getElementById)|(getElementByClassName)|(getElementByName)|(innerHTML)");
            e.ChangedRange.SetStyle(orange, "(function)");
            e.ChangedRange.SetStyle(purple, "({)|(})|([)|(])|(===)|(=>)");
            e.ChangedRange.SetStyle(magenta, "(cookie)|(if)|(else)|(while)|(do)|(null)|(for)|(switch)|(case)|(break)|(default)");
            e.ChangedRange.SetStyle(gray, "(;)|(:)|(>)|(<)");
        }

        private void tb_Code_ZoomChanged(object sender, EventArgs e)
        {
            tb_ZoomValue.Text = tb_Code.Zoom.ToString() + "%";
        }
    }
}
