using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkanimeAvScriptGenerator
{
    class Episode
    {
        public string RAW { get; set; }
        public string Audio { get; set; }
        public string SubFile { get; set; }

        public Episode(string raw, string audio,string sub)
        {
            this.RAW = raw;
            this.SubFile = sub;
            this.Audio = audio;
        }

        public Episode() { }
    }
}
