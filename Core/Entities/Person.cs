using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    public abstract class Person : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly BirthDate { get; private set; }
        public void SetName(string firsName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firsName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Invalid name");
            FirstName = firsName;
            LastName = lastName;
        }

        public void SetBirthDate(DateOnly birthDate)
        {
            if (birthDate < new DateOnly(1989, 1, 1))
                throw new ArgumentException("Invalid birth date");
            BirthDate = birthDate;
        }
    }
}
