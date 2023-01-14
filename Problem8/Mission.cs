using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Mission
    {
        public Mission(string codeName)
        {
            CodeName = codeName;
            State = false;
        }

        public string CodeName { get; set; }
        public bool State { get; set; }

        public void CompleteMission()
        {
            State = true;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Code name: {this.CodeName}")
            .AppendLine($"State: {this.State}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
