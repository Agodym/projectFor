using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFor.entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public Group() {
            Users = new List<User>(); 
            LessonGroups = new List<LessonGroup>();
        }
        public ICollection<LessonGroup> LessonGroups { get; set; }
       
    }
}
