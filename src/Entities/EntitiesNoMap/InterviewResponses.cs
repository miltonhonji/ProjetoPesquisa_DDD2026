using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntitiesNoMap
{
    public class InterviewResponses
    {
        public InterviewResponses()
        {
            InterviewResponsesList = new List<ResponseQuestionDTO>();
        } 

        public List<ResponseQuestionDTO> InterviewResponsesList { get; set; }
    }

    public class ResponseQuestionDTO
    {
        public int Id { get; set; }
        public string InterviewedDocument { get; set; }
        public string InterviewedName { get; set; }
        public DateTime ResponseDate { get; set; }
        public int CompanyId { get; set; }
        public int QuestionId { get; set; }
        //public 
    }
}