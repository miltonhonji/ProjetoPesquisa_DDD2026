using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    [Table("Question")]
    public class Question : Base
    {
        public bool Active { get; set; }
    }
}