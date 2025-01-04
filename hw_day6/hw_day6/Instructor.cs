namespace hw_day6
{
    public interface IInstructorService : IPersonService
    {
        decimal CalculateBonus();
        int CalculateExperience();
    }
    public class Instructor: Person, IInstructorService
    {
        private DateTime _joinDate;
        private Department _department;
        private const decimal BONUS_PER_YEAR = 1000m;

        // Polymorphism - overriding base method
        public override decimal CalculateSalary()
        {
            return Salary + CalculateBonus();
        }

        public decimal CalculateBonus()
        {
            return CalculateExperience() * BONUS_PER_YEAR;
        }

        public int CalculateExperience()
        {
            return DateTime.Now.Year - _joinDate.Year;
        }

    }
}
// Instructor
//     Belongs to one Department and he can be Head of the Department
//     Instructor will have added bonus salary based on his experience, calculate his
//     years of experience based on Join Date

