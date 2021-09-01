using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksFrontEnd.models
{
    public class TaskReq
    {
        public int Id { get; set; }        
        [Required(ErrorMessage = "Title is required field")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Text is required field")]
        public string Text { get; set; }
        public string Comment { get; set; }
        public string FileUrl { get; set; }
        public bool Checked { get; set; }
        public int Type { get; set; }
    }
}
