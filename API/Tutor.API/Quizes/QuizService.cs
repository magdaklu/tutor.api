using MongoDB.Driver;

namespace Tutor.API.Quizes
{
    public class QuizService : IQuizService
    {
        private readonly IMongoCollection<FlashCard> flashCards;
        private readonly IConfiguration config;

        public QuizService(IConfiguration config)
        {
            this.config = config;
            var client = new MongoClient(config["MongoDbConnectionString"]);
            var database = client.GetDatabase("tutor");

            flashCards = database.GetCollection<FlashCard>("english_quiz");
        }
        public IEnumerable<FlashCard> GetFlashCards() => flashCards.Find(FilterDefinition<FlashCard>.Empty).ToList();
        public FlashCard Add(FlashCard flashCard)
        {
            flashCards.InsertOne(flashCard);
            return flashCard;
        }
    }
}
