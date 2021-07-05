using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tahmini.Models
{
    public class TestEntry
    {
        public int Id { get; set; }

        public int TestId { get; set; }
        public virtual Test tests { get; set; }

        public virtual List<Question> Questions { get; set; }
        public virtual List<Answer> Answers { get; set; }
    }
}
