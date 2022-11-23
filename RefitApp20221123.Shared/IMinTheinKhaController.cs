using Refit;
using RefitApp20221123.Models;

namespace RefitApp20221123.Shared
{
    public interface IMinTheinKhaController
    {
        [Get("/api/MinTheinKha")]
        Task<List<QuestionModel>> Get();

        [Get("/api/MinTheinKha/{questionNo}")]
        Task<AnswerModel> Get(int questionNo);
    }
}