using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesNoMap
{
    public class QuestionOptionsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int SearchId { get; set; }
        public List<OptionDTO> Options { get; set; }
    }

    public class OptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight {get;set;}
        public bool Active { get; set;}
        public int QuestionId { get; set; }
    }
}