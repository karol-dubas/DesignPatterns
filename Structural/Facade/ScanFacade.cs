using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ScanFacade
    {
        private readonly SecurityScanner _securityScanner = new();
        private readonly QualityScanner _qualityScanner = new();
        private readonly DependencyScanner _dependencyScanner = new();
        private readonly ReportGenerator _reportGenerator = new();

        public void Scan(string githubUrl)
        {
            var securityScanErrors = _securityScanner.SecurityScan(githubUrl);
            var qualityScanErrors = _qualityScanner.QualityScan(githubUrl);
            var dependencyScanErrors = _dependencyScanner.DependencyScan(githubUrl);

            _reportGenerator.GenerateReport(securityScanErrors, qualityScanErrors, dependencyScanErrors);
        }
    }
}
