using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
            if (path == null) return;
            this.path = path;
            folders = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
        }

        public void ScanBeatmaps()
        {

            foreach(var dir in folders)
            {
                string map = dir.Substring(path.Length);

                if (!dir.StartsWith("beatmap"))
                {
                    map = map.Split(" ")[0];
                    maps.Add(map + ",");
                }
  
            }

            Console.WriteLine(maps);
            Console.WriteLine(folders);

            WriteFile();

            Console.WriteLine("Total maps found: " + maps.Count);
        }

        private void WriteFile()
        {
            string save = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\osu_Sync.osusync";
            //save.Replace(":", "_");

            if(File.Exists(save)) File.Delete(save);

            using (FileStream fs = File.Create(save))
            {
                foreach(string beatmap in maps)
                {
                    Byte[] data = new UTF8Encoding(true).GetBytes(beatmap.Substring(1));
                    fs.Write(data);
                }
                
            }

            MessageBox.Show("File saved to the Documents folder", "Songs scanned! (" + maps.Count + ")", MessageBoxButtons.OK);
        }

        public void DownloadBeatmaps(string[] beatmapIDs)
        {

            foreach(string map in beatmapIDs)
            {
                //System.Diagnostics.Process.Start();
                var url = url_supporter + map;
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(2000);
            }
 
        }

        

    }
}
