namespace hw_day6;

public class Course
{
    private string _name;
    private List<Student> _enrolledStudents = new List<Student>();

    public void EnrollStudent(Student student)
    {
        _enrolledStudents.Add(student);
    }

    public Course(string name)
    {
        _name = name;
    }
    public override string ToString()
    {
        return _name ?? "Unnamed Course";
    }
}