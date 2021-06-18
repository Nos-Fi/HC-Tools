using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLScriptMerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchPathButton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && this.openFileDialog.FileNames.Count() == 1)
            {
                this.pfadTextBox.Text = this.openFileDialog.FileName;
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            var ansi = Encoding.GetEncoding(1252);
            var path = this.pfadTextBox.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("Script.xml nicht gefunden.");
                return;
            }

            var content = File.ReadAllText(path, ansi);

            if (!content.Contains("</script>"))
            {
                MessageBox.Show("Kein </script> Tag in Script.xml gefunden.");
                return;
            }

            content = content.Replace("</script>", String.Empty);

            var filePaths = Directory.GetFiles(Path.GetDirectoryName(path), "*.xml");

            foreach (var filePath in filePaths)
            {
                if (Path.GetFileName(filePath).ToLower() == "script.xml")
                {
                    continue;
                }

                var fileContent = File.ReadAllText(filePath, ansi);

                if (!fileContent.Contains("<script>") || !fileContent.Contains("</script>"))
                {
                    MessageBox.Show(String.Format("Kein <script> oder </script> Tag in {0} gefunden."), Path.GetFileName(filePath));
                    return;
                }

                fileContent = fileContent.Replace("<script>", String.Empty);
                fileContent = fileContent.Replace("</script>", String.Empty);

                content = String.Format("{0}{1}{1}{2}", content, Environment.NewLine, fileContent);

                if (!noDeleteCheckBox.Checked)
                {
                    File.Delete(filePath);
                }
            }

            content = String.Format("{0}{1}{1}{2}", content, Environment.NewLine, "</script>");
            File.WriteAllText(path, content, ansi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pfadTextBox.Text = Properties.Settings.Default["Pfad"].ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["Pfad"] = this.pfadTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
