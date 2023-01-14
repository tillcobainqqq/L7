using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Engineer : IEngineer
    {
        public Engineer(string firstName, string lastName, string id, double salary, List<string> corps)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Salary = salary;
            Corps = corps;
        }
        public Engineer(string firstName, string lastName, string id, double salary, List<string> corps, List<Repair> repairs)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Salary = salary;
            Corps = corps;
            Repairs = repairs;
        }

        public List<Repair> Repairs { get; set; }
        public List<string> Corps { get; set; }
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
            .AppendLine("Corps: ")
            .AppendLine(CorpsList())
            .AppendLine("Repairs: ")
            .AppendLine(RepairsList());
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }

        private string CorpsList()
        {
            string res = null;

            if (Corps != null)
            {
                for (int i = 0; i < Corps.Count; i++)
                {
                    res += Corps[i].ToString();
                    res += "; ";
                }
            }

            return res;
        }

        private string RepairsList()
        {
            string res = null;

            if (Repairs != null)
            {
                for (int i = 0; i < Repairs.Count; i++)
                {
                    res += Repairs[i].ToString();
                    res += "; ";
                }
            }

            return res;
        }
    }
}
