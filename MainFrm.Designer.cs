
namespace JS_Code_Editor
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tv_Files = new System.Windows.Forms.TreeView();
            this.tb_Code = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel_File = new System.Windows.Forms.Panel();
            this.btn_ExportAsZip = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.btn_File = new System.Windows.Forms.Button();
            this.timer_File = new System.Windows.Forms.Timer(this.components);
            this.pb_Rename = new System.Windows.Forms.PictureBox();
            this.tb_CurrentNode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ZoomValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddZoom = new System.Windows.Forms.Button();
            this.btn_MinusZoom = new System.Windows.Forms.Button();
            this.tb_Opacity = new System.Windows.Forms.TextBox();
            this.btn_AddOpacity = new System.Windows.Forms.Button();
            this.btn_MinusOpacity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Code)).BeginInit();
            this.panel_File.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rename)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.panel_Menu.Controls.Add(this.label1);
            this.panel_Menu.Controls.Add(this.btn_Minimize);
            this.panel_Menu.Controls.Add(this.btn_Exit);
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(942, 30);
            this.panel_Menu.TabIndex = 0;
            this.panel_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseDown);
            this.panel_Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "JS Code Editor";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Minimize.Location = new System.Drawing.Point(881, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(26, 23);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.Text = "__";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_Exit.Location = new System.Drawing.Point(913, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(26, 23);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tv_Files
            // 
            this.tv_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tv_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tv_Files.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tv_Files.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.tv_Files.Location = new System.Drawing.Point(12, 116);
            this.tv_Files.Name = "tv_Files";
            this.tv_Files.Size = new System.Drawing.Size(144, 433);
            this.tv_Files.TabIndex = 1;
            // 
            // tb_Code
            // 
            this.tb_Code.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tb_Code.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.tb_Code.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.tb_Code.BackBrush = null;
            this.tb_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tb_Code.CharHeight = 14;
            this.tb_Code.CharWidth = 8;
            this.tb_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Code.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tb_Code.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_Code.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tb_Code.IsReplaceMode = false;
            this.tb_Code.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.tb_Code.Location = new System.Drawing.Point(177, 116);
            this.tb_Code.Name = "tb_Code";
            this.tb_Code.Paddings = new System.Windows.Forms.Padding(0);
            this.tb_Code.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tb_Code.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tb_Code.ServiceColors")));
            this.tb_Code.Size = new System.Drawing.Size(753, 433);
            this.tb_Code.TabIndex = 2;
            this.tb_Code.Zoom = 100;
            this.tb_Code.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.tb_Code_TextChanged);
            this.tb_Code.ZoomChanged += new System.EventHandler(this.tb_Code_ZoomChanged);
            // 
            // panel_File
            // 
            this.panel_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel_File.Controls.Add(this.btn_ExportAsZip);
            this.panel_File.Controls.Add(this.btn_Export);
            this.panel_File.Controls.Add(this.btn_SaveFile);
            this.panel_File.Controls.Add(this.btn_OpenFolder);
            this.panel_File.Controls.Add(this.btn_File);
            this.panel_File.Location = new System.Drawing.Point(12, 36);
            this.panel_File.MaximumSize = new System.Drawing.Size(90, 165);
            this.panel_File.MinimumSize = new System.Drawing.Size(90, 26);
            this.panel_File.Name = "panel_File";
            this.panel_File.Size = new System.Drawing.Size(90, 26);
            this.panel_File.TabIndex = 4;
            // 
            // btn_ExportAsZip
            // 
            this.btn_ExportAsZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_ExportAsZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExportAsZip.FlatAppearance.BorderSize = 0;
            this.btn_ExportAsZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportAsZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_ExportAsZip.Location = new System.Drawing.Point(3, 118);
            this.btn_ExportAsZip.Name = "btn_ExportAsZip";
            this.btn_ExportAsZip.Size = new System.Drawing.Size(84, 41);
            this.btn_ExportAsZip.TabIndex = 9;
            this.btn_ExportAsZip.Text = "Export As ZIP";
            this.btn_ExportAsZip.UseVisualStyleBackColor = false;
            this.btn_ExportAsZip.Click += new System.EventHandler(this.btn_ExportAsZip_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_Export.Location = new System.Drawing.Point(3, 89);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(84, 23);
            this.btn_Export.TabIndex = 8;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_SaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveFile.FlatAppearance.BorderSize = 0;
            this.btn_SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_SaveFile.Location = new System.Drawing.Point(3, 60);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(84, 23);
            this.btn_SaveFile.TabIndex = 7;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_OpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenFolder.FlatAppearance.BorderSize = 0;
            this.btn_OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_OpenFolder.Location = new System.Drawing.Point(3, 31);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(84, 23);
            this.btn_OpenFolder.TabIndex = 6;
            this.btn_OpenFolder.Text = "Open Folder";
            this.btn_OpenFolder.UseVisualStyleBackColor = false;
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_File
            // 
            this.btn_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_File.FlatAppearance.BorderSize = 0;
            this.btn_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_File.Location = new System.Drawing.Point(3, 2);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(84, 23);
            this.btn_File.TabIndex = 4;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = false;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // timer_File
            // 
            this.timer_File.Interval = 4;
            this.timer_File.Tick += new System.EventHandler(this.timer_File_Tick);
            // 
            // pb_Rename
            // 
            this.pb_Rename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Rename.Image = ((System.Drawing.Image)(resources.GetObject("pb_Rename.Image")));
            this.pb_Rename.Location = new System.Drawing.Point(314, 85);
            this.pb_Rename.Name = "pb_Rename";
            this.pb_Rename.Size = new System.Drawing.Size(25, 25);
            this.pb_Rename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Rename.TabIndex = 6;
            this.pb_Rename.TabStop = false;
            this.pb_Rename.Click += new System.EventHandler(this.pb_Rename_Click);
            // 
            // tb_CurrentNode
            // 
            this.tb_CurrentNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tb_CurrentNode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CurrentNode.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_CurrentNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.tb_CurrentNode.Location = new System.Drawing.Point(177, 85);
            this.tb_CurrentNode.Multiline = true;
            this.tb_CurrentNode.Name = "tb_CurrentNode";
            this.tb_CurrentNode.Size = new System.Drawing.Size(131, 25);
            this.tb_CurrentNode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(177, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Name:";
            // 
            // tb_ZoomValue
            // 
            this.tb_ZoomValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tb_ZoomValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ZoomValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.tb_ZoomValue.Location = new System.Drawing.Point(355, 85);
            this.tb_ZoomValue.Multiline = true;
            this.tb_ZoomValue.Name = "tb_ZoomValue";
            this.tb_ZoomValue.Size = new System.Drawing.Size(69, 25);
            this.tb_ZoomValue.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(355, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zoom:";
            // 
            // btn_AddZoom
            // 
            this.btn_AddZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_AddZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddZoom.FlatAppearance.BorderSize = 0;
            this.btn_AddZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddZoom.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_AddZoom.Location = new System.Drawing.Point(430, 85);
            this.btn_AddZoom.Name = "btn_AddZoom";
            this.btn_AddZoom.Size = new System.Drawing.Size(25, 25);
            this.btn_AddZoom.TabIndex = 12;
            this.btn_AddZoom.Text = "+";
            this.btn_AddZoom.UseVisualStyleBackColor = false;
            this.btn_AddZoom.Click += new System.EventHandler(this.btn_AddZoom_Click);
            // 
            // btn_MinusZoom
            // 
            this.btn_MinusZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_MinusZoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinusZoom.FlatAppearance.BorderSize = 0;
            this.btn_MinusZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinusZoom.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MinusZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_MinusZoom.Location = new System.Drawing.Point(461, 85);
            this.btn_MinusZoom.Name = "btn_MinusZoom";
            this.btn_MinusZoom.Size = new System.Drawing.Size(25, 25);
            this.btn_MinusZoom.TabIndex = 13;
            this.btn_MinusZoom.Text = "-";
            this.btn_MinusZoom.UseVisualStyleBackColor = false;
            this.btn_MinusZoom.Click += new System.EventHandler(this.btn_MinusZoom_Click);
            // 
            // tb_Opacity
            // 
            this.tb_Opacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tb_Opacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Opacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.tb_Opacity.Location = new System.Drawing.Point(492, 85);
            this.tb_Opacity.Multiline = true;
            this.tb_Opacity.Name = "tb_Opacity";
            this.tb_Opacity.Size = new System.Drawing.Size(64, 25);
            this.tb_Opacity.TabIndex = 14;
            // 
            // btn_AddOpacity
            // 
            this.btn_AddOpacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_AddOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddOpacity.FlatAppearance.BorderSize = 0;
            this.btn_AddOpacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddOpacity.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddOpacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_AddOpacity.Location = new System.Drawing.Point(562, 85);
            this.btn_AddOpacity.Name = "btn_AddOpacity";
            this.btn_AddOpacity.Size = new System.Drawing.Size(25, 25);
            this.btn_AddOpacity.TabIndex = 15;
            this.btn_AddOpacity.Text = "+";
            this.btn_AddOpacity.UseVisualStyleBackColor = false;
            this.btn_AddOpacity.Click += new System.EventHandler(this.btn_AddOpacity_Click);
            // 
            // btn_MinusOpacity
            // 
            this.btn_MinusOpacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btn_MinusOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinusOpacity.FlatAppearance.BorderSize = 0;
            this.btn_MinusOpacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinusOpacity.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MinusOpacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.btn_MinusOpacity.Location = new System.Drawing.Point(593, 85);
            this.btn_MinusOpacity.Name = "btn_MinusOpacity";
            this.btn_MinusOpacity.Size = new System.Drawing.Size(25, 25);
            this.btn_MinusOpacity.TabIndex = 16;
            this.btn_MinusOpacity.Text = "-";
            this.btn_MinusOpacity.UseVisualStyleBackColor = false;
            this.btn_MinusOpacity.Click += new System.EventHandler(this.btn_MinusOpacity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(248)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(492, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Opacity:";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_MinusOpacity);
            this.Controls.Add(this.btn_AddOpacity);
            this.Controls.Add(this.tb_Opacity);
            this.Controls.Add(this.btn_MinusZoom);
            this.Controls.Add(this.btn_AddZoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ZoomValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_CurrentNode);
            this.Controls.Add(this.pb_Rename);
            this.Controls.Add(this.panel_File);
            this.Controls.Add(this.tb_Code);
            this.Controls.Add(this.tv_Files);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Code)).EndInit();
            this.panel_File.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Rename)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.TreeView tv_Files;
        private FastColoredTextBoxNS.FastColoredTextBox tb_Code;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_File;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Timer timer_File;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.PictureBox pb_Rename;
        private System.Windows.Forms.TextBox tb_CurrentNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ZoomValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddZoom;
        private System.Windows.Forms.Button btn_MinusZoom;
        private System.Windows.Forms.TextBox tb_Opacity;
        private System.Windows.Forms.Button btn_AddOpacity;
        private System.Windows.Forms.Button btn_MinusOpacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_ExportAsZip;
    }
}

