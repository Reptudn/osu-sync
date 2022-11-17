namespace osu_Sync
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Features.Beatmaps.video = !Features.Beatmaps.video;
            Console.WriteLine("Changed video download to: " + Features.Beatmaps.video);
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            

        }

        private void scanBeatmaps_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Scanning Beatmaps...");
            

            string content = String.Empty;

            

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the osu! Beatmap folder";
                folderDialog.InitialDirectory = "c:\\";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Features.Beatmaps beatmaps = new Features.Beatmaps(folderDialog.SelectedPath);
                    beatmaps.ScanBeatmaps();
                }
                else return;
            }

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Importing Beatmaps...");
            Features.Beatmaps beatmaps = new Features.Beatmaps(null);

            string content = String.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select the osu Beatmap import file";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "osu!Sync files (*.osusync)|*.osusync";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        content = reader.ReadToEnd();
                    }
                }
                else return;
            }

            string[] maps = content.Split(",");

            if(MessageBox.Show("Do you want to import " + maps.Length + " beatmaps?", "File read succesful", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                beatmaps.DownloadBeatmaps(maps);
            }
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}