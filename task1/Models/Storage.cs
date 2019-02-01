using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task1.Models
{
    public static class Storage
    {
        public static IEnumerable<Article> articles = new List<Article>
        {
            new Article{Date = DateTime.Now,
                Name = "Article 1",
                Text = "fdklfndkfjdkclfsdfksdf"
            },
            new Article{Date = DateTime.Now,
                Name = "Article 2",
                Text = "fdklfndkfjdkclfsdfksdf"
            },
            new Article{Date = DateTime.Now,
                Name = "Article 3",
                Text = "fdklfndkfjdkclfsdfksdf"
            },
            new Article{Date = DateTime.Now,
                Name = "Article 4",
                Text = "fdklfndkfjdkclfsdfksdf"
            },
        };

        public static List<Feedback> feedbacks = new List<Feedback>
        {
            new Feedback
            {
                Date = DateTime.Now,
                UserName = "User1",
                Text = "vfdgfgd"
            },
            new Feedback
            {
                Date = DateTime.Now,
                UserName = "User2",
                Text = "vfddfgdfggfgd"
            },
            new Feedback
            {
                Date = DateTime.Now,
                UserName = "User3",
                Text = "vfdgfsdffdsfdfgd"
            }
        };
    }
}