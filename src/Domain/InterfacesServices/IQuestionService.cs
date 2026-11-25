using System;
using System.Collections.Generic;
using System.Text;
using Entities.EntitiesNoMap;

namespace Domain.InterfacesServices
{
    public interface IQuestionService
    {
        Task AddSearchOptions(QuestionOptionsDTO Response);
        Task UpdateSearchOptions(QuestionOptionsDTO Response);
        Task<QuestionOptionsDTO> GetQuestionWithOptions(int questionId);
    }
}