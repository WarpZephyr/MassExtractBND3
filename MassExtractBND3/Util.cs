namespace MassExtractBND3
{
    public class Util
    {
        public static string GetFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return string.Empty;

            return dialog.SelectedPath;
        }
    }
}
