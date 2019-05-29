using MetroFramework;
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
                JunctionPoint.Create(txtFolder.Text, txtTargetFolder.Text);
                success = true;
            }
            catch (IOException ex)
            {
                if (toggleOverwrite.Checked)
                {
                    DialogResult dRes = MetroMessageBox.Show(this, "Cannot create the symbolic link. Force create? This is danger", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                    if (dRes == DialogResult.OK)
                    {
                        Directory.Delete(txtTargetFolder.Text);
                        JunctionPoint.Create(txtFolder.Text, txtTargetFolder.Text);
                        success = true;
                    }
                } else
                {
                    if (Directory.Exists(txtTargetFolder.Text) && Directory.GetFiles(txtTargetFolder.Text).Length <= 0)
                    {
                        JunctionPoint.Create(txtFolder.Text, txtTargetFolder.Text, true);
                        success = true;
                    } else
                    {
                        MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (success)
            {
                MetroMessageBox.Show(this, "Created succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            DialogResult d = folderSource.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtFolder.Text = folderSource.SelectedPath;
            }
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            DialogResult d = folderTarget.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtTargetFolder.Text = folderTarget.SelectedPath;
            }
        }
    }
}
