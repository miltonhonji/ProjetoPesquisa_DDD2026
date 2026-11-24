using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    [Table("Option")]
    public class Option : Base
    {
        public bool Active{ get; set;}
        public int Weight { get; set;}

        [ForeignKey("Question")]
        [Column(Order = 1)]
        public int QuestionId { get; set; }
        
        [JsonIgnore]
        public virtual Question? Question { get; set; }

    }
}   