using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tahmini.Models
{
    public class Answer
    {
       
        public int Id { get; set; }

        public int QuestionId { get; set; }
        public virtual Question question { get; set; }

        public string OptionText { get; set; }

        public virtual Test tests { get; set; }

        public string userId { get; set; }
        public virtual User user { get; set; }

    }
}
