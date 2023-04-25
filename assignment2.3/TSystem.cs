using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._3
{
    delegate bool IsCanAddTeacher (string name);
    internal class TSystem
    {
        List<Teacher> Teachers = new List<Teacher>();
        public List<TopServices> GetTopServices(List<Teacher> Teachers)
        {
            List<TopServices> TopServices = Teachers
                .GroupBy(t => t.PrefferedService)
                .Select(g => new TopServices() { service = g.Key, CountOfUsing = g.Count() }) 
                .OrderByDescending(g => g.CountOfUsing)
                .Take(3)
                .ToList();

            return TopServices;
        }

        public void AddTeacher(Teacher newTeacher)
        {
            IsCanAddTeacher isCanAddTeacher = (name) => Teachers.Find((t) => t.Fio.Equals(name)) == null;

            if (isCanAddTeacher(newTeacher.Fio))
            {
                Teachers.Add(newTeacher);
            }
        }

        public string PrintTeachers()
        {
            string result = "";
            foreach (Teacher teacher in Teachers)
            {
                result += teacher.Fio +
                    " " +
                    teacher.Institute +
                    " " +
                    teacher.PrefferedService.TextColor +
                    teacher.PrefferedService.ServiceName +
                    Colors.NORMAL +
                    "\n";
            }
            return result;
        }

        public string PrintTopServices()
        {
            string result = "";
            foreach (Service service in TopServices)
            {
                result += service.TextColor +
                    service.ServiceName +
                    Colors.NORMAL +
                    "\n";
            }
            return result;
        }

    }
}
