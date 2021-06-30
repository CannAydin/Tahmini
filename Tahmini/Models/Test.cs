using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tahmini.Models
{
    public class Test
    {
        public Test()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }

        public string Title { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [Display(Name ="Start Time")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Finish Time")]
        public DateTime EndDate { get; set; }

        public string RemainingTime
        {
            get
            {
                var remainingHour = (DateTime.Now - EndDate);
                return ("Kalan zaman: " + remainingHour.Days.ToString() + " gün");
            }
        }

        public virtual List<Question> AllQuestions { get; set; }
        public virtual List<Answer> AllAnswers { get; set; }
    }
}
