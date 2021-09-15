using System;
using System.Collections.Generic;

namespace Api.Models
{
    public class Incident
    {
        public DateTime DateTime { get; set; }
        public List<string> Location { get; set; }
        public string Details { get; set; }
        public List<string> Category  { get; set; }
        public List<string> Severity  { get; set; }
        public Employee ReportedEmployee { get; set; }

        public Investigation Investigation { get; set; }
        public string RootCause { get; set; }
    }
}