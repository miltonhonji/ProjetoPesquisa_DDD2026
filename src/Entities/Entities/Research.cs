using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.Entities
{
    public class Research : Base
    {
        public bool Active { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }

        [ForeignKey("Company")]
        [Column(Order = 1)]
        public int CompanyId { get; set; }

        [JsonIgnore]
        public virtual Company? Company { get; set; }
    }
}