using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.db.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public String? Firestname { get; set; }
        public string? Lastname { get; set; }
        public double Average { get; set; }
    }
}