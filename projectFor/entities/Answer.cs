using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFor.entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int GroupId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Ans { get; set; }
        public DateTime? DateAnswer { get; set; }

    }
}
