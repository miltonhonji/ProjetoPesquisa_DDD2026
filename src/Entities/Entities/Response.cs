using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    [Table("Response")]
    public class Response : Notifica
    {
        public int Id { get; set; }
        public string CpfInterviewed {get;set;}
        public int InterviwedName { get; set; }
        public DateTime ResponseDate { get; set; }

        [ForeignKey("Company")]
        [Column(Order = 1)]
        //All responses are linked to a company, 
        //so we can know which company the response belongs to.
        public int CompanyId { get; set; }

        [JsonIgnore]
        public virtual Company? Company { get; set; }
    }
}