using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGameProject
{
    class Campaign
    {
        public int Id { get; set; }
        public bool Availability { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double SuccessRate { get; set; }
        public double DiscountRate { get; set; }
    }
}
