using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBrushupSchool
{
    public class Teacher
    {

        // Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }

        // First method
        public void ValidateName()
        {
            if (Name == null)  
                throw new ArgumentNullException("Name is null!");

            if (Name.Length < 1)
                throw new ArgumentException("Name must be ATLEAST one character!");
        }

        // Second method :D
        public void ValidateSalary()
        {
            if (Salary < 0)
                throw new ArgumentOutOfRangeException("Salary must be over 0.");

        }

        // Single general validator method, calling two property based validator methods
        public void Validate()
        {
            ValidateName();
            ValidateSalary();
        }


    }

}
