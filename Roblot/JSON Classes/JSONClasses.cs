﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Roblot.JSON_Classes
{
    public class OwesMe
    {
        public string id { get; set; }
        public double amount { get; set; }
    }

    public class IOwe
    {
        public string id { get; set; }
        public double amount { get; set; }
    }

    // We don't need personalized playlists for now

    //public class Playlists
    //{
    //    public string PlaylistName { get; set; }
    //    public string PlaylistUrl { get; set; }
    //}

    public class User //this is the user that called the command
    {
        //public string name { get; set; }
        public string id { get; set; }
        public List<OwesMe> owesMe { get; set; }
        public List<IOwe> IOwe { get; set; }
        //public List<Playlists> playlists { get; set; }

        public User()
        {
            owesMe = new List<OwesMe>();
            IOwe = new List<IOwe>();
            //playlists = new List<Playlists>();
        }
    }
}
