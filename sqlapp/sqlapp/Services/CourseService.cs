using sqlapp.Models;
using System.Data.SqlClient;
using System.Globalization;

namespace sqlapp.Services
{
    public class CourseService
    {
        private static string data_source = "files/data.csv";
        private static string db_source = "appserveralexei.database.windows.net";
        private static string db_user = "alexeiadmin";
        private static string db_password = "Abcd.1234567";
        private static string db_database = "appdb";

        public List<Course> GetCourses()
        {
            List<Course> _course_lst = new List<Course>();
            string _statement = "SELECT CourseID,ExamImage,CourseName,rating from Course";
            SqlConnection _connection = GetConnection();

            _connection.Open();

            SqlCommand _sqlcommand = new SqlCommand(_statement, _connection);

            using (SqlDataReader _reader = _sqlcommand.ExecuteReader())
            {
                while (_reader.Read())
                {
                    Course _course = new Course()
                    {
                        CourseID = _reader.GetInt32(0),
                        ExamImage = _reader.GetString(1),
                        CourseName = _reader.GetString(2),
                        Rating = _reader.GetDecimal(3)
                    };

                    _course_lst.Add(_course);
                }
            }
            _connection.Close();
            return _course_lst;
        }

        public List<Course> GetCoursesLocal()
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

        private SqlConnection GetConnection()
        {

            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }
    }
}

