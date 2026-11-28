using System;
using System.Collections.Generic;
using System.Text;
using Domain.InterfacesServices;
using Entities.EntitiesNoMap;

namespace Domain.Services
{
    public class QuestionService : IQuestionService
    {
        public QuestionService()
        {
            
        } 

        public async Task AddSearchOptions(QuestionOptionsDTO Response)
        {
            throw new NotImplementedException();
        }

        public async Task<QuestionOptionsDTO> GetQuestionWithOptions(int questionId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateSearchOptions(QuestionOptionsDTO Response)
        {
            throw new NotImplementedException();
        }
    }
}