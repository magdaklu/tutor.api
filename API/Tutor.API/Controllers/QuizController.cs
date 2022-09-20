using Microsoft.AspNetCore.Mvc;
using Tutor.API.Quizes;

namespace Tutor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {

        private readonly ILogger<QuizController> _logger;
        private IQuizService quizService;

        public QuizController(ILogger<QuizController> logger, IQuizService quizService)
        {
            _logger = logger;
            this.quizService = quizService;
        }

        [HttpGet("flashcards")]
        public IEnumerable<FlashCard> Get()
        {
            return quizService.GetFlashCards();
        }
    }
}