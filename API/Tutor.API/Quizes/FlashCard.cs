using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace Tutor.API.Quizes
{
    public class FlashCard
    {
        public ObjectId _id { get; set; }

        [BsonElement("question")]
        public string Question { get; set; } = null!;

        [BsonElement("answer")]
        public string Answer { get; set; } = null!;
    }
}
