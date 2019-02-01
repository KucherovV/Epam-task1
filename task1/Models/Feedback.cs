using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task1.Models
{
    public class Feedback
    {
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}