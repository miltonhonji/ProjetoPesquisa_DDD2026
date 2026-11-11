using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    [Table("Company")]
    public class Company : Base
    {
        public string Document { get; set;}
        public bool Active { get; set;}
    }
}
