using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace sample_api_mongodb.Models
{
    public class Page
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int AccessTypeId { get; set; }
        
        public string PageName { get; set; }

        public bool Status { get; set; }

    }
}