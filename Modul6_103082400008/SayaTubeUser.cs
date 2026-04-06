using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Modul6_103082400008

{
    public class SayaTubeUser
    {
        public string Username { get; set; }
        private List<sayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            this.uploadedVideos = new List<sayaTubeVideo>();
             }
        public int getTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;
        }
        public void addVideo(sayaTubeVideo video)
        {
            this.uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"\nUser : {this.Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                {
                    Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].getJudul()}");
                }
            }

        }
    }
}

