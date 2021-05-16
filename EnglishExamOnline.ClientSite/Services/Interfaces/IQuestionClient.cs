using EnglishExamOnline.Shared;
using EnglishExamOnline.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnglishExamOnline.ClientSite.Services.Interfaces
{
    public interface IQuestionClient
    {
        Task<IList<QuestionVm>> GetQuestions();

        Task<IList<QuestionVm>> FindQuests(string find);

        Task<QuestionVm> GetQuestion(int id);

        Task<QuestionVm> PostQuestion(QuestionFormVm question);

        Task<QuestionVm> PutQuestion(int id, QuestionFormVm question);

        Task<int> DeleteQuestion(int id);
    }
}
