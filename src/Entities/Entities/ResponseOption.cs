using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    [Table("ResponseOption")]
    public class ResponseOption : Notification
    {
        public int Id { get; set;}
        
        [ForeignKey("Question")]
        [Column(Order = 1)]
        public int QuestionId { get; set; }

        [ForeignKey("Response")]
        [Column(Order = 1)]
        public int ResponseId { get; set; }

    }
}