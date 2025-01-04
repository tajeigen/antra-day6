namespace hw_day6;

public class Department
{
    private Instructor _head;
    private decimal _budget; 
    private DateTime _budgetStartDate;
    private DateTime _budgetEndDate;
    private List<Course> _courses = new();

    public Department()
    {
        _courses = new List<Course>();
    }
    // Properties
    public Instructor Head
    {
        get { return _head; }
        private set { _head = value; }
    }

    public decimal Budget
    {
        get { return _budget; }
        set 
        { 
            if (value < 0)
                throw new ArgumentException("Budget cannot be negative");
            _budget = value;
        }
    }

    public DateTime BudgetStartDate
    {
        get { return _budgetStartDate; }
        set { _budgetStartDate = value; }
    }

    public DateTime BudgetEndDate
    {
        get { return _budgetEndDate; }
        set 
        { 
            if (value < _budgetStartDate)
                throw new ArgumentException("Budget end date must be after start date");
            _budgetEndDate = value;
        }
    }
    public void SetDepartmentHead(Instructor instructor)
    {
        _head = instructor;
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }

    public void RemoveCourse(Course course)
    {
        _courses.Remove(course);
    }

    public IEnumerable<Course> GetCourses()
    {
        return _courses.AsReadOnly();
    }

    public void SetBudgetPeriod(DateTime startDate, DateTime endDate)
    {
        _budgetStartDate = startDate;
        _budgetEndDate = endDate;
    }
    public bool IsWithinBudgetPeriod(DateTime date)
    {
        return date >= _budgetStartDate && date <= _budgetEndDate;
    }
    public decimal GetBudget()
    {
        return _budget;
    }
    
}