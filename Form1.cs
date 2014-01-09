using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmptyMp3FolderNuker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                tbRootFolder.Text = dlgFolder.SelectedPath;
            }
        }
        
        void IsEmptyRecur(string path, ParallelQuery<string> files)
        {
            string pathToTest = path.EndsWith(@"\") ? path : path + @"\";
            if (files.Any(f => f.IndexOf(pathToTest.ToLower()) >= 0))
            {
                var dirs = Directory.EnumerateDirectories(path);
                foreach (var dir in dirs)
                {
                    IsEmptyRecur(dir, files);
                }
            }
            else
            {
                // empty
                lbFolders.Items.Add(path);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = tbRootFolder.Text;
            if (!Directory.Exists(path))
            {
                return;
            }

            var exts = tbExts.Text.ToLower().Split(',');
            if ( exts.Length == 0)
            {
                return;
            }

            lbFolders.Items.Clear();
            var extsHash = new HashSet<string>(exts.Select(ext => "." + ext.ToLower()));
            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories).Select(f => f.ToLower()).Where(f => extsHash.Contains(Path.GetExtension(f))).ToList();
            IsEmptyRecur(path, files.AsParallel());
        }

        private void btnNuke_Click(object sender, EventArgs e)
        {
            List<string> undeleted = new List<string>();
            for (int i = 0; i < lbFolders.Items.Count; ++i )
            {
                var dir = lbFolders.Items[i] as string;
                try
                {
                    Directory.Delete(dir, true);
                }
                catch (Exception)
                {
                    undeleted.Add(dir);
                }
            }

            lbFolders.Items.Clear();
            lbFolders.Items.AddRange(undeleted.ToArray());
        }
    }
}
