namespace Tutor.API.Quizes
{
    public interface IQuizService
    {
        IEnumerable<FlashCard> GetFlashCards();
        FlashCard Add(FlashCard flashCard);
    }
}
