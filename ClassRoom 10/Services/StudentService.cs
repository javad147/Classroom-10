using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoom_10.Models;

namespace ClassRoom_10.Services
{
    internal class StudentService
    {
        private Student[] GetAll()
        {
            Student stu1 = new()
            {
                id = 1,
                name = "Semed",
                surname = "Huseynov",
                email = "semed@gmail.com",
                birthday = new(1996, 04, 20)
            };

            Student stu2 = new()
            {
                id = 2,
                name = "Tunzale",
                surname = "Memmedova",
                email = "tunzala@gmail.com",
                birthday = new(1998, 08, 08)
            };

            Student stu3 = new()
            {
                id = 3,
                name = "Ilham",
                surname = "Abbasli",
                email = "ilham@gmail.com",
                birthday = new(2003, 12, 05)
            };


            return new Student[] { stu1, stu2, stu3 };


        }
        public Student[] ShowAllStudents(DateTime startDate, DateTime endDate)
        {
            Student[] students = GetAll();
            var result = students.Where(x => x.birthday > startDate && x.birthday < endDate).ToArray();
            return result;

        }

        public int GetStundentAgeById(int id)
        {
            Student[] students = GetAll();
            Student student = students.FirstOrDefault(x => x.id == id);
            int result = DateTime.Now.Year - student.birthday.Year;
            return result;


        }
    }
}
