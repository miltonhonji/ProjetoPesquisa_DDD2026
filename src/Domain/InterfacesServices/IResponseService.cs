using System;
using System.Collections.Generic;
using System.Text;
using Entities.EntitiesNoMap;

namespace Domain.InterfacesServices
{
    public interface IResponseService
    {
        Task AddQuestionsOptions(InterviewResponses Response);
    }
}