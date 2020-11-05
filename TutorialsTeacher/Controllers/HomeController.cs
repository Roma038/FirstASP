using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorialsTeacher.Models;

namespace TutorialsTeacher.Controllers
{
    public class HomeController : Controller
    {
        IList<Student> studentList = new List<Student>{
                            new Student() { StudentId = 1, StudentName = "John", Age = 18, Gender = "Male" } ,
                            new Student() { StudentId = 2, StudentName = "Sophiya", Age = 21, Gender = "Female" } ,
                            new Student() { StudentId = 3, StudentName = "Bill", Age = 25, Gender = "Male"} ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20, Gender = "Male"} ,
                            new Student() { StudentId = 5, StudentName = "Alice" , Age = 31 ,Gender = "Female"} ,
                            new Student() { StudentId = 4, StudentName = "Christine" , Age = 17, Gender = "Female" } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19, Gender = "Male" } };


        public ActionResult Index()
        {
            
            return View(studentList);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student stud)
        {
            if (ModelState.IsValid)
            {
                var student = studentList.Where(s => s.StudentId == stud.StudentId).FirstOrDefault();
                studentList.Remove(student);
                studentList.Add(stud);
                return RedirectToAction("Index");
            }
            return View(stud);
        }

    }
}