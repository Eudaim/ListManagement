using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManagement
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public DateTime DeadLine { get; set; }

        public string Print()
        {
            return ( $"{Name} Completed: {IsCompleted}");
        }


    }
}
