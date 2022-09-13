using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute
{
    [Disc(SongName = "Suryaveer 3", Language = "Hindi", Lyrics = "Muthabr Ghyetly Mavle Sobti......")]
    internal class Song

    {
        [Disc(SongName = "Barishein", Language = "Hindi", Lyrics = "JB Barsihein barsati hai...")]
        public int SongId { get; set; }

        [Disc(SongName = "Kesariya", Language = "HINDI", Lyrics = "Kesariya tera Ishq h.....")]
        public int ReleaseYear { get; set; }

    }
}
