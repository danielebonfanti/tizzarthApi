using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TizzarthApi 
{
    public class Pizza 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string name { get; set; }
    }
}