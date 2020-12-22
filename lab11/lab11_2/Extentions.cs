using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_2
{
    public static class Extensions
    {
        public static List<Student> FindStudents(this List<Student> students,
            Student.StudentPredicateDelegate studentFindPredicate)
        {
            List<Student> resultList = new List<Student>();
            foreach (var student in students)
            {
                if (studentFindPredicate(student))
                    resultList.Add(student);
            }
            return resultList;
        }
    }
}
