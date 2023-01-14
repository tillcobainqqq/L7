using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class LeutenantGeneral : ILeutenantGeneral
    {
        public LeutenantGeneral(string firstName, string lastName, string id, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Salary = salary;
        }
        public LeutenantGeneral(string firstName, string lastName, string id, double salary, List<Private> privates)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Salary = salary;
            Privates = privates;
        }

        public List<Private> Privates { get; set; }
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
            .AppendLine($"Salary: {this.Salary}")
            .AppendLine("Privates: ")
            .AppendLine(PrivatesList());
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

        private string PrivatesList()
        {
            string res = null;
            
            if(Privates != null)
            {
                for(int i = 0; i < Privates.Count; i++)
                {
                    res += Privates[i].ToString();
                    res += "; ";
                }
            }

            return res;
        }
    }
}
