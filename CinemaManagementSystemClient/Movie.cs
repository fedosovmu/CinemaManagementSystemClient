﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementSystemClient
{
    public class Movie
    {
        public int ID;
        public string Name;
        public string Description;

        public Movie(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
