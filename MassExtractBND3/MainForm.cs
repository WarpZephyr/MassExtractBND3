using SoulsFormats;

namespace MassExtractBND3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtFolder_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txtFolder.Text = files[0];
            }
        }

        private void txtFolder_DragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data;
            if (data == null)
                return;

            if (data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtFolder.Text = Util.GetFolder();
        }

        private async void btnExtract_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = string.Empty;
            if (!Directory.Exists(txtFolder.Text))
            {
                txtCurrent.Text = $"Path is not a folder.";
                return;
            }

            string outDir = Path.Combine(txtFolder.Text, "mass-extracted");

#if !DEBUG
            try
            {
#endif
            string[] paths = Directory.GetFiles(txtFolder.Text, "*", SearchOption.AllDirectories);

            pbrExtract.Maximum = paths.Length;
            pbrExtract.Value = 0;

            await Task.Run(() =>
            {
                for (int i = 0; i < paths.Length; i++)
                {
                    string path = paths[i];
                    if (BND3.Is(path))
                    {
                        var bnd = BND3.Read(path);
                        for (int j = 0; j < bnd.Files.Count; j++)
                        {
                            var file = bnd.Files[j];
                            string outPath = Path.Combine(outDir, file.Name ?? file.ID.ToString());
                            Invoke(new Action(() => txtCurrent.Text = $"BND {i + 1} of {paths.Length} BNDs; File {j + 1} of {bnd.Files.Count} Files; BND Name: {Path.GetFileName(path)}; File Name: {file.Name ?? file.ID.ToString()}"));

                            if (!chxOverwriteExistingFiles.Checked)
                            {
                                int copyI = 1;
                                string? copyDir = Path.GetDirectoryName(outPath);
                                string copyName = Path.GetFileNameWithoutExtension(outPath);
                                string copyExtension = Path.GetExtension(outPath);
                                if (copyDir == null)
                                {
                                    Invoke(new Action(() => txtCurrent.Text = $"Error on getting folder name for file: {Path.GetFileName(outPath)}"));
                                    continue;
                                }

                                string copyPathExtensionless = Path.Combine(copyDir, copyName);
                                while (File.Exists(outPath))
                                {
                                    outPath = $"{copyPathExtensionless} ({copyI}){copyExtension}";
                                    copyI++;
                                }
                            }

                            string? dir = Path.GetDirectoryName(outPath);
                            if (dir != null)
                            {
                                Directory.CreateDirectory(dir);
                            }
                            else
                            {
                                Invoke(new Action(() => txtCurrent.Text = $"Error on getting folder name for file: {Path.GetFileName(outPath)}"));
                                continue;
                            }
                            File.WriteAllBytes(outPath, file.Bytes);
                        }
                    }
                    else
                    {
                        Invoke(new Action(() => txtCurrent.Text = $"File is not a BND3: {Path.GetFileName(path)}"));
                    }
                    Invoke(new Action(() => pbrExtract.Value++));
                }
            });
#if !DEBUG
            }
            catch (Exception)
            {
                txtCurrent.Text = "An unknown error occurred.";
            }
#endif
        }
    }
}