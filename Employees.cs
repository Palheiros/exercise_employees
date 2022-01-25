using System.Globalization;

namespace exerciseEmployees
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employees(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return "ID: " + Id + " - Employee: " + Name + " - Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

    
}
