using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace Securely
{
    public partial class Form1 : Form
    {
        private string this_pc = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        private string folder = null;

        private void PickFolder()
        {
            CommonOpenFileDialog browser = new CommonOpenFileDialog();

            browser.InitialDirectory = this_pc;
            browser.IsFolderPicker = true;

            if (browser.ShowDialog() == CommonFileDialogResult.Ok)
                folder = browser.FileName;

            Textbox_Folder_Path.Text = folder;
            Textbox_Folder_Path.SelectionStart = Textbox_Folder_Path.Text.Length;
        }
    }

}
