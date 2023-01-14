using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Private : IPrivate
    {
        public Private(string firstName, string lastName, string id, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Salary = salary;
        }

        public double Salary { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Name: {this.FirstName}" + " " + $"{this.LastName}")
            .AppendLine($"Id: {this.Id}")
            .AppendLine($"Salary: {this.Salary}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
