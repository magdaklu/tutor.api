using MongoDB.Driver;

namespace Tutor.API.Quizes
{
    public class QuizService : IQuizService
    {
        private readonly IMongoCollection<FlashCard> flashCards;

        public QuizService()
        {
            var client = new MongoClient("mongodb+srv://wraps:SSXUkgoAwgbrfOM3@cluster0.4fnxw.mongodb.net/?retryWrites=true&w=majority");
            var database = client.GetDatabase("tutor");

            flashCards = database.GetCollection<FlashCard>("english_quiz");
        }
        public IEnumerable<FlashCard> GetFlashCards() => flashCards.Find(FilterDefinition<FlashCard>.Empty).ToList();
    }
}
