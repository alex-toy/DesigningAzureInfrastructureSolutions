using sqlapp.Models;
using System.Globalization;

namespace sqlapp.Services
{
    public class CourseService
    {
        private static string data_source = "files/data.csv";        

        
        public List<Course> GetCourses()
        {
            List<Course> _course_lst = new List<Course>();

            StreamReader _reader = new StreamReader(File.OpenRead(data_source));
            
            while (!_reader.EndOfStream)
            {
                string _line = _reader.ReadLine();

                string[] _values = _line.Split(',');

                Course _course = new Course()
                {
                    CourseID = GetCourseId(_values),
                    ExamImage = _values[1],
                    CourseName = _values[2],
                    Rating = GetRating(_values)
                };

                _course_lst.Add(_course);
            }

            return _course_lst;
        }

        private static decimal GetRating(string[] _values)
        {
            return decimal.Parse(_values[3], CultureInfo.InvariantCulture);
        }

        private static int GetCourseId(string[] _values)
        {
            return int.Parse(_values[0]);
        }
    }
}

