using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RefitApp20221123.Api.Services;
using RefitApp20221123.Models;

namespace RefitApp20221123.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinTheinKhaController : ControllerBase
    {
        private readonly DataService _dataService;
        public MinTheinKhaController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public List<QuestionModel> Get()
        {
            return _dataService.GetQuestions();
        }

        [HttpGet("{questionNo}")]
        public AnswerModel Get(int questionNo)
        {
            Random random = new Random();
            var answerNo = random.Next(1, 10);
            return _dataService.GetAnswers().Where(x =>
            x.QuestionNo == questionNo &&
            x.AnswerNo == answerNo).FirstOrDefault();
        }
    }
}
