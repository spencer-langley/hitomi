using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hitomi.Models
{
    public class VideoSession
    {
        public string VideoName { get; set; }
        public string VideoURL { get; set; }
        public Keystroke[] Keystrokes { get; set; }
    }

    public class Keystroke
    {
        public decimal Time { get; set; }
        public string Vote { get; set; }
    }
}