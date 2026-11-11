using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Base : Notifica
    {
        [Display (Name = "Códe")]
        public int Id { get; set; }

        [Display (Name = "Name")]
        public string Name { get; set; }
    }    
}

