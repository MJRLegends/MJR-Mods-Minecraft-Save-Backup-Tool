namespace MJR_Mods_Minecraft_Save_Backup_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBackup = new DevComponents.DotNetBar.ButtonX();
            this.txtFolderPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFolderExplorer = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFindSaves = new DevComponents.DotNetBar.ButtonX();
            this.listSaveResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackup.Enabled = false;
            this.btnBackup.Location = new System.Drawing.Point(297, 289);
            this.btnBackup.Name = "buttonX1";
            this.btnBackup.Size = new System.Drawing.Size(279, 26);
            this.btnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtFolderPath.Border.BackColor = System.Drawing.Color.White;
            this.txtFolderPath.Border.BackColor2 = System.Drawing.Color.White;
            this.txtFolderPath.Border.Class = "TextBoxBorder";
            this.txtFolderPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFolderPath.ForeColor = System.Drawing.Color.Black;
            this.txtFolderPath.Location = new System.Drawing.Point(12, 12);
            this.txtFolderPath.Name = "textBoxX1";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(250, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnFolderExplorer
            // 
            this.btnFolderExplorer.Location = new System.Drawing.Point(261, 12);
            this.btnFolderExplorer.Name = "btnFolderExplorer";
            this.btnFolderExplorer.Size = new System.Drawing.Size(25, 20);
            this.btnFolderExplorer.TabIndex = 2;
            this.btnFolderExplorer.Text = "...";
            this.btnFolderExplorer.UseVisualStyleBackColor = true;
            this.btnFolderExplorer.Click += new System.EventHandler(this.btnFolderExplorer_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOutput.Border.BackColor = System.Drawing.Color.White;
            this.txtOutput.Border.BackColor2 = System.Drawing.Color.White;
            this.txtOutput.Border.Class = "TextBoxBorder";
            this.txtOutput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtSavesResults";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(279, 277);
            this.txtOutput.TabIndex = 3;
            // 
            // btnFindSaves
            // 
            this.btnFindSaves.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFindSaves.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFindSaves.Enabled = false;
            this.btnFindSaves.Location = new System.Drawing.Point(297, 12);
            this.btnFindSaves.Name = "buttonX2";
            this.btnFindSaves.Size = new System.Drawing.Size(279, 29);
            this.btnFindSaves.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFindSaves.TabIndex = 4;
            this.btnFindSaves.Text = "Find Saves";
            this.btnFindSaves.Click += new System.EventHandler(this.btnFindSaves_Click);
            // 
            // listSaveResults
            // 
            this.listSaveResults.CheckBoxes = true;
            this.listSaveResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listSaveResults.Location = new System.Drawing.Point(298, 47);
            this.listSaveResults.Name = "listSaveResults";
            this.listSaveResults.Size = new System.Drawing.Size(278, 236);
            this.listSaveResults.TabIndex = 5;
            this.listSaveResults.UseCompatibleStateImageBehavior = false;
            this.listSaveResults.View = System.Windows.Forms.View.SmallIcon;
            this.listSaveResults.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Save Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 327);
            this.Controls.Add(this.listSaveResults);
            this.Controls.Add(this.btnFindSaves);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnFolderExplorer);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnBackup);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(595, 366);
            this.MinimumSize = new System.Drawing.Size(595, 366);
            this.Name = "Form1";
            this.Text = "MJR Mods - Minecraft Save Backup Tool v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnBackup;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFolderPath;
        private System.Windows.Forms.Button btnFolderExplorer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOutput;
        private DevComponents.DotNetBar.ButtonX btnFindSaves;
        private System.Windows.Forms.ListView listSaveResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

