namespace hw_day6;
/*
 *we need classes: Person, student, instructor
 *Student and instructor iherit person attributes
 * Polymorphism to create virtual method like identity() or salaryCalculation()
 * Interface : ICourseService, IStudentService, IInstructorService, IDepartmentService, IPersonService, IPersonService
 * IStudentService, IInstructorService should Inherit IPersonService
 *
 * Person Class:
 * Person
     Calculate Age of the Person
     Calculate the Salary of the person, Use decimal for salary
     Salary cannot be negative number
     Can have multiple Addresses, should have method to get addresses
 */ 
public interface IPersonService
{
    decimal CalculateSalary();
    int CalculateAge();
    IEnumerable<Address> GetAddresses();
}
//Base class using Abstraction: 
public abstract class Person
{

    //Encapsulation -Private
    private string _name;
    private DateTime _dateOfBirth; 
    private decimal _salary; //salary cannot be negative 
    private List<Address> _addresses = new List<Address>();
    // Encapsulation: 
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void AddAddress(Address address)
    {
        _addresses.Add(address);
    }
    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
        
    }
    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            _salary = value;
        }
    }

    public virtual decimal CalculateSalary()
    {
        return Salary;
    }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }

    public IEnumerable<Address> GetAddresses()
    {
        return _addresses.AsReadOnly();
    }
    

}