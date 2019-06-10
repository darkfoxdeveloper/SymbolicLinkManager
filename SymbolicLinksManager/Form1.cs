using MetroFramework;
using MetroFramework.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace SymbolicLinksManager
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateSymbolicLink_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                if (toggleLinkFileMode.Checked)
                {
                    if (!toggleOverwrite.Checked)
                    {
                        if (File.Exists(txtTargetFolder.Text))
                        {
                            MetroMessageBox.Show(this, "This file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } else
                        {
                            success = SLCore.CreateSymbolicFileLink(txtTargetFolder.Text, txtFolder.Text);
                        }
                    } else
                    {
                        success = SLCore.CreateSymbolicFileLink(txtTargetFolder.Text, txtFolder.Text);
                    }
                } else
                {
                    SLCore.CreateSymbolicFolderLink(txtFolder.Text, txtTargetFolder.Text, toggleOverwrite.Checked);
                    success = true;
                }
            }
            catch (IOException ex)
            {
                MetroMessageBox.Show(this, "Cannot create the symbolic link. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (success)
            {
                MetroMessageBox.Show(this, "Created succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            bool fileMode = toggleLinkFileMode.Checked;
            if (fileMode)
            {
                DialogResult d = fileSource.ShowDialog();
                if (d == DialogResult.OK)
                {
                    txtFolder.Text = fileSource.FileName;
                }
            } else
            {
                DialogResult d = folderSource.ShowDialog();
                if (d == DialogResult.OK)
                {
                    txtFolder.Text = folderSource.SelectedPath;
                }
            }
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            bool fileMode = toggleLinkFileMode.Checked;
            if (fileMode)
            {
                fileTarget.Filter = "Same source format file|*" + Path.GetExtension(fileSource.FileName);
                DialogResult d = fileTarget.ShowDialog();
                if (d == DialogResult.OK)
                {
                    txtTargetFolder.Text = fileTarget.FileName;
                }
            } else
            {
                DialogResult d = folderTarget.ShowDialog();
                if (d == DialogResult.OK)
                {
                    txtTargetFolder.Text = folderTarget.SelectedPath;
                }
            }
        }

        private void toggleLinkFileMode_CheckedChanged(object sender, EventArgs e)
        {
            bool fileMode = ((MetroToggle)sender).Checked;
            if (fileMode)
            {
                lblFolder.Text = "Source File";
                lblTargetFolder.Text = "Target File";
            } else
            {
                lblFolder.Text = "Source Folder";
                lblTargetFolder.Text = "Target Folder";
            }
        }
    }
}
