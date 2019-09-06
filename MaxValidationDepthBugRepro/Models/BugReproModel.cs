using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MaxValidationDepthBugRepro.Models
{
    public class BugReproModel
    {
        [Required]
        public string Prop { get; set; }
    }
}
