﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NotesRework
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}