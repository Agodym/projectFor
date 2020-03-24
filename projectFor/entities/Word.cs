using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFor.entities
{
    public class Word
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string Russian { get; set; }
        public string English { get; set; }
    }
}
