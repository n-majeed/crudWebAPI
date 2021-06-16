using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Student
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public int rollNo { get; set; } = 0;
        public int marks { get; set; } = 0;

        internal IActionResult editStudent(int id, Student stdnt)
        {
            throw new NotImplementedException();
        }
    }
}
