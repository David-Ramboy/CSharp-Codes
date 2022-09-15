using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        // static attribute means in permanent to the class, or properties with values in the class
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration) 
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
            
        
        }
        public int getSongCount() {
            return songCount;
        }
    }
}
