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

        [Display(Name ="Enter Question")]
        [DataType(DataType.MultilineText)]
        public string QuestionText { get; set; }
        [Display(Name = "Enter First Option")]
        public string OptionOne { get; set; }
        [Display(Name = "Enter Second Option")]
        public string OptionTwo { get; set; }
    }
}
