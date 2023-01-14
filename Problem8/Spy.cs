using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Spy : ISpy
    {
        public Spy(string firstName, string lastName, string id, int codeNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Name: {this.FirstName}" + " " + $"{this.LastName}")
            .AppendLine($"Id: {this.Id}")
            .AppendLine($"Code number: {this.CodeNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
