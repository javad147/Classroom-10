using ClassRoom_10.Models;
using ClassRoom_10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom_10.Controllers
{
    internal class StudentController
    {
        public void GetFiltredStudents()
        {

            DateTime startDate = new(1995, 01, 22);
            DateTime endDate = new(2000, 01, 01);
            StudentService studentService = new StudentService();
            Student[] students = studentService.ShowAllStudents(startDate, endDate);

            foreach (var student in students)
            {
                var result = $"{student.name} {student.birthday.ToString("MM/dd/yyyy")}";
                Console.WriteLine(result);
            }



        }

        public void StudenAge()
        {
            StudentService service = new StudentService();
            Console.WriteLine(service.GetStundentAgeById(2));
        }
    }
}
