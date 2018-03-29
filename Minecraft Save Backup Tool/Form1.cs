using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Ionic.Zip;

namespace Minecraft_Save_Backup_Tool
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        String path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFolderExplorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            path = fbd.SelectedPath;
            txtFolderPath.Text = path;
            btnFindSaves.Enabled = true;
        }

        String[] filePaths;
        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (listSaveResults.CheckedItems.Count > 0)
            {
                foreach (String pathLoop in filePaths)
                {
                    if (!pathLoop.Contains("_mcr") && !pathLoop.Contains("_old"))
                    {
                        if (pathLoop.Contains("level.dat") && pathLoop.Contains("saves"))
                        {
                            if (!Directory.Exists(@"c:\Backups"))
                            {
                                Directory.CreateDirectory(@"c:\Backups");
                            }
                            Console.WriteLine(pathLoop);
                            try
                            {
                                using (ZipFile zip = new ZipFile())
                                {
                                    zip.ParallelDeflateThreshold = -1;
                                    zip.AddDirectory(pathLoop.Substring(0, pathLoop.LastIndexOf(@"\")));
                                    String name = "";
                                    String folderName = "";

                                    if (pathLoop.Contains(@"minecraft\saves\") && pathLoop.Contains(@"\instances\"))
                                    {
                                        name = pathLoop.ToLower().Substring(pathLoop.IndexOf("minecraft\\saves\\") + 16);
                                        folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"instances\") + 10);
                                        folderName = folderName.Substring(0, folderName.IndexOf(@"\"));
                                    }
                                    else if (pathLoop.Contains(@"\saves"))
                                    {
                                        name = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"\saves\") + 7);
                                        if (pathLoop.Contains(@"ftblauncher\"))
                                        {
                                            folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"ftblauncher\") + 12);
                                        }
                                        else if (pathLoop.Contains(@"ATLauncher\Instances\"))
                                        {
                                            folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"Instances\") + 10);
                                        }
                                        else if (pathLoop.Contains(@"Curse\Instances\") || pathLoop.Contains(@"Twitch\Instances\"))
                                        {
                                            folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"Instances\") + 10);
                                        }
                                        else
                                        {
                                            if (!pathLoop.Contains("Curse") && !pathLoop.Contains("Twitch"))
                                                folderName = folderName.Substring(0, folderName.IndexOf(@"\"));
                                        }
                                    }
                                    else
                                    {
                                        txtOutput.AppendText(Environment.NewLine + "error with " + pathLoop);
                                        return;
                                    }
                                    folderName = folderName.ToLower();
                                    name = name.Substring(0, name.IndexOf('\\'));


                                    foreach (ListViewItem item in this.listSaveResults.CheckedItems)
                                    {
                                        if (item.Text.ToLower().Equals(folderName + " - " + name))
                                        {
                                            if (!Directory.Exists(@"c:\Backups\" + folderName))
                                            {
                                                Directory.CreateDirectory(@"c:\Backups\" + folderName);
                                            }
                                            txtOutput.AppendText(Environment.NewLine + "------Saving - " + name);
                                            zip.Save(@"c:\Backups\" + folderName + @"\" + name + " " + DateTime.Now.Year.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Day.ToString() + "." + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + ".zip".Replace(@"\", ""));
                                            zip.Dispose();
                                            txtOutput.AppendText(Environment.NewLine + "------Saved - " + name);

                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("You need to select one or more saves!", "Error!");
        }

        private void btnFindSaves_Click(object sender, EventArgs e)
        {
            filePaths = Directory.GetFiles("" + path, "*.dat", SearchOption.AllDirectories);
            foreach (String pathLoop in filePaths)
            {
                if (!pathLoop.Contains("_mcr") && !pathLoop.Contains("_old"))
                {
                    if (pathLoop.Contains("level.dat") && pathLoop.Contains("saves"))
                    {
                        String name = "";
                        String folderName = "";
                        if (pathLoop.Contains(@"minecraft\saves\") && pathLoop.Contains(@"\instances\"))
                        {
                            name = pathLoop.ToLower().Substring(pathLoop.IndexOf("minecraft\\saves\\") + 16);
                            folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"instances\") + 10);
                            folderName = folderName.Substring(0, folderName.IndexOf(@"\"));
                        }
                        else if (pathLoop.Contains(@"\saves"))
                        {
                            name = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"\saves\") + 7);
                            if (pathLoop.Contains(@"ftblauncher\"))
                            {
                                folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"ftblauncher\") + 12);
                            }
                            else if (pathLoop.Contains(@"ATLauncher\Instances\"))
                            {
                                folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"Instances\") + 10);
                            }
                            else if (pathLoop.Contains(@"Curse\Instances\") || pathLoop.Contains(@"Twitch\Instances\"))
                            {
                                folderName = pathLoop.ToLower().Substring(pathLoop.IndexOf(@"Instances\") + 10);
                            }
                            else
                            {
                                if(!pathLoop.Contains("Curse") && !pathLoop.Contains("Twitch"))
                                    folderName = folderName.Substring(0, folderName.IndexOf(@"\"));
                            }
                        }
                        else
                        {
                            txtOutput.AppendText(Environment.NewLine + "error with " + pathLoop);
                            return;
                        }
                        folderName = folderName.ToLower();
                        name = name.Substring(0, name.IndexOf('\\'));
                        listSaveResults.Items.Add(folderName + " - " + name);
                    }
                }
            }
        }
        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btnBackup.Enabled = true;
        }
    }
}
