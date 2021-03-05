using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SubtitlesSync {
    public partial class Form : System.Windows.Forms.Form {
        private bool _bClick;

        public Form() {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            if (FileDialog.ShowDialog() != DialogResult.OK) return;
            FileName.Text = FileDialog.FileName.Substring(FileDialog.FileName.LastIndexOf('\\') + 1);
            _bClick = true;
        }

        private void Execute_Click(object sender, EventArgs e) {
            if (!_bClick) {
                MessageBox.Show(@"File not specified!");
                return;
            }
            var ms = long.Parse(DeltaMillis.Text);
            if (Backward.Checked) ms *= -1;

            using (var input = File.OpenText(FileDialog.FileName))
            using (var temp = new StreamWriter("temp.txt")) {
                for (var line = input.ReadLine(); line != null; line = input.ReadLine()) {

                    if (Regex.IsMatch(line, @"\d+[:,]\d+[:,]\d+[:,]\d+\D+\d+[:,]\d+[:,]\d+[:,]\d+")) {
                        var v = Regex
                            .Matches(line, @"\d+")
                            .OfType<Match>()
                            .Select(i => int.Parse(i.Value))
                            .ToArray();

                        line = $"{Parse.GetTime(Parse.GetMillis(v[0], v[1], v[2], v[3]) + ms)}" +
                               $" --> " +
                               $"{Parse.GetTime(Parse.GetMillis(v[4], v[5], v[6], v[7]) + ms)}";
                    }
                    temp.WriteLine(line);
                }
            }
            File.Delete(FileDialog.FileName);
            File.Move("temp.txt", FileDialog.FileName);

            MessageBox.Show(@"Success!");
            Application.Exit();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
