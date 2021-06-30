using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tahmini.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public virtual Test test { get; set; }

        [Display(Name ="Question")]
        public string QuestionText { get; set; }

        public string OptionOne { get; set; }
        public string OptionTwo { get; set; }
    }
}
