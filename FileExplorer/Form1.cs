using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class FileExplorer : Form
    {
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Odaberite putanju." })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward(); 
        }
    }
}
