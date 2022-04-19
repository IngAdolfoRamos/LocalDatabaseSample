using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalDatabaseSample.Models
{
    public class Stall
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int phone { get; set; }
    }
}
