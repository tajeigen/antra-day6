namespace hw_day6;
// Student
//     Can take multiple courses
//     Calculate student GPA based on grades for courses
//     Each course will have grade from A to F
public interface IStudentService : IPersonService
{
    double CalculateGPA();
    void EnrollInCourse(Course course);
}
public class Student: Person,IStudentService
{
    
    private List<Course> _courses = new();
    private Dictionary<Course, Grade> _grades = new();
    private List<Course> _enrolledCourses = new List<Course>();

    public double CalculateGPA()
    {
        if (!_grades.Any())
        {
            return 0;
        }
        double totalPoints = _grades.Sum(g => (int)g.Value);
        return totalPoints / _grades.Count;
    }

    public void EnrollInCourse(Course course)
    {
        _enrolledCourses.Add(course);
    }

    public IEnumerable<Course> GetEnrolledCourses()
    {
        return _enrolledCourses.AsReadOnly();
    }
    
}