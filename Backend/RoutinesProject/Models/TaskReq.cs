using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutinesProject.Models
{
    public class TaskReq
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string? Comment { get; set; }
        public string FileUrl { get; set; }
        public bool Checked { get; set; }
        public int Type { get; set; }

    }
}
