using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfacesServices
{
    public interface IResponseService
    {
        Task AddQuestionsOptions(InterviewResponses Response);
    }
}