using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProje.Models
{
    public class Statistics
    {
        public int categoryCount { get; set; }
        public int headingCount { get; set; }
        public int authorCount { get; set; }
        public string categoryWithMostHeadings { get; set; }
        public int diff { get; set; }
    }
}