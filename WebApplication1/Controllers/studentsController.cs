using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentsController : ControllerBase
    {
        List<Student> students = new List<Student>() {
        new Student(){id=1, name="Hiba", rollNo=21, marks=85 },
        new Student(){id=2, name="Ahmed", rollNo=22, marks=65 },
        new Student(){id=3, name= "Fahad", rollNo= 23, marks=80 },
        };


        [HttpGet]
        public IActionResult Gets()
        {
            if (students.Count == 0)
            {
                return NotFound("No list Found.");
            }
            return Ok(students);
        }
        [HttpGet("GetStudent")]
        public IActionResult Get(int id) {
            var student = students.SingleOrDefault(x => x.id == id);
            if (student == null) {
                return NotFound("No student found");
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult Save(Student student) {
            students.Add(student);
            if (students.Count == 0) {
                return NotFound("No list Found");
            }
            return Ok(students);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var stud = students.SingleOrDefault(x => x.id == id);
            if (stud == null)
            {
                return NotFound("No Student Found");
            }
            students.Remove(stud);
            if (students.Count == 0) {
                return NotFound("No list Found");
            }
            return Ok(students);
        }

      [HttpPut]
        public IActionResult EditStudent(int id, Student stdnt)
        {
            var existingStudent = students.SingleOrDefault(x => x.id == id);
            if (existingStudent == null)
            {
                return NotFound("No Student with this id found");
            }
            else {
                students.Remove(existingStudent);
                //existingStudent = students.SingleOrDefault(x => x.id == id);
                existingStudent.id = stdnt.id;
                existingStudent.name = stdnt.name;
                existingStudent.rollNo = stdnt.rollNo;
                existingStudent.marks = stdnt.marks;
                students.Add(existingStudent);
               
            }
            return Ok(students);
        }

    }
  }

