using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class Sql
    {
        public Table<Student> Students { get; set; } = new();
        public Table<Teacher> Teachers { get; set; } = new();
        public Table<Lesson> Lessons { get; set; } = new();
        public bool Query(string query)
        {
            return SqlHelper.Exec(query);
        }
    }
}
