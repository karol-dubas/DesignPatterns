using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class QualityScanner
    {
        public IEnumerable<string> QualityScan(string githubUrl)
        {
            Console.WriteLine("Quality scan");

            return new List<string> { "Quality error1", "Quality error2" };
        }
    }
}
