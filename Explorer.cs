using Eksamensprojekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofuasofhuoashhd
{
    public partial class Explorer : Form
    {
        string directory = "";
        private string path = "";

        public Explorer()
        {
            InitializeComponent();
            path_bar.Text = "C:\\";
            file_view.Items.AddRange(GetContents(path_bar.Text));
            directory = path_bar.Text;
        }

        void file_view_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = file_view.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                path_bar.Text = directory + file_view.Items[index].ToString();
            }
            file_view.Items.Clear();
            file_view.Items.AddRange(GetContents(path_bar.Text));
            directory = path_bar.Text;
        }

        string[] GetContents(string current)
        {
            List<string> contents = new List<string>();

            string[] dirs = Directory.GetDirectories(current);
            foreach (string dir in dirs)
            {
                contents.Add(dir.Substring(current.Length));
            }

            string[] files = Directory.GetFiles(current);
            foreach (string file in files)
            {
                if (file_endings_view.Items.Contains(file.Split('.').Last()))
                    contents.Add(file.Substring(current.Length));
            }

            return [.. contents];
        }

        private void add_file_ending_button_Click(object sender, EventArgs e)
        {
            file_endings_view.Items.Add(add_file_ending_box.Text);
            add_file_ending_box.Text = "";
            file_view.Items.Clear();
            file_view.Items.AddRange(GetContents(directory));
        }

        private void file_view_MouseClick(object sender, MouseEventArgs e)
        {
            int index = file_view.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                path_bar.Text = directory + file_view.Items[index].ToString();
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            BL.data_sti = path_bar.Text;
            Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            int last_slash = directory.LastIndexOf('\\');
            if (last_slash > 2)
                directory = directory.Substring(0, last_slash);
            else if (last_slash > 0)
                directory = directory.Substring(0, last_slash + 1);

            path_bar.Text = directory;
            file_view.Items.Clear();
            file_view.Items.AddRange(GetContents(directory));
        }
    
        public string ReturnerFilSti()
        {
            return path;
        }
    }
}
