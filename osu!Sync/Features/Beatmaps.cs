using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_Sync.Features
{
    internal class Beatmaps
    {

        public static readonly string url_supporter = "osu://b/";
        public static readonly string url_normal = "https://osu.ppy.sh/beatmapsets/"; // id/download?noVideo=1/0

        public static bool video = false;

        string path;

        String[] folders;

        ArrayList maps = new ArrayList();

        public Beatmaps(string path)
        {
            this.path = path;
            folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
        }

        public void ScanBeatmaps()
        {

            foreach(var dir in folders)
            {
                string map = dir.Substring(path.Length);
                map = map.Split(" ")[0];
                maps.Add(map);
            }

            Console.WriteLine(maps);
            Console.WriteLine(folders);

            WriteFile();

            Console.WriteLine("Total maps found: " + maps.Count);
        }

        private void WriteFile()
        {
            string save = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\osu_Sync_" + Utils.Time.GetCurrentTime();
            save.Replace(":", "_");

            if(File.Exists(save)) File.Delete(save);

            using (FileStream fs = File.Create(save))
            {
                foreach(string beatmap in maps)
                {
                    Byte[] data = new UTF8Encoding(true).GetBytes(beatmap);
                    fs.Write(data);
                }
                
            }
        }

        public void DownloadBeatmaps()
        {

            foreach(string map in maps)
            {
                System.Diagnostics.Process.Start(url_supporter + map);
            }
 
        }

        private void SupporterDownload()
        {

        }

        private void CasualDownload()
        {

        }

    }
}
