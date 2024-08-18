using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> securityErrors, IEnumerable<string> qualityErrors,
            IEnumerable<string> dependencyErrors)
        {
            Console.WriteLine("Security scan errors:");
            Console.WriteLine(string.Join(", ", securityErrors));

            Console.WriteLine("Quality scan errors:");
            Console.WriteLine(string.Join(", ", qualityErrors));

            Console.WriteLine("Dependency scan errors:");
            Console.WriteLine(string.Join(", ", dependencyErrors));
        }
    }
}
