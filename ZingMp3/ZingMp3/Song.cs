﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3
{
    internal class Song
    {
        private string songName;
        private string singerName;
        private string songURL;
        private int sTT;

        public string SongName { get => songName; set => songName = value; }
        public string SingerName { get => singerName; set => singerName = value; }
        public string SongURL { get => songURL; set => songURL = value; }
        public int STT { get => sTT; set => sTT = value; }
    }
}
