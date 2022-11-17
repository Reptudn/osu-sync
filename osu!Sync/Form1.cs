namespace osu_Sync
{
    public partial class mainWindow : Form
    {

        public string osuFolderPath = "C:\\Users\\Jonas\\AppData\\Local\\osu!";

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
            Console.WriteLine("Scanning Beatmaps");
            Features.Beatmaps beatmaps = new Features.Beatmaps(osuFolderPath + "\\Songs");
            beatmaps.ScanBeatmaps();
        }
    }
}