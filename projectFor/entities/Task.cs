using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFor.entities
{
    public class Task
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }
        public string Var1 { get; set; }
        public string Var2 { get; set; }
        public string Var3 { get; set; }
        public string Var4 { get; set; }
        public string Ans { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateClose { get; set; }
        public int MaxGrade { get; set; }
    }
}
