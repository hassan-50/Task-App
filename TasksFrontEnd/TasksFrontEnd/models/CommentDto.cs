using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksFrontEnd.models
{
    public class CommentDto
    {
        [Required(ErrorMessage = "Enter Something!")]
        public string Comment { get; set; }
    }
}
