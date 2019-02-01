using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using task1.Models;

namespace task1.ViewModels
{
    public class FeedbackViewModel
    {
        public IEnumerable<Feedback> feedbacks { get; set; }
        public Feedback feedback { get; set; }
    }
}