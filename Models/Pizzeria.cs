using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TizzarthApi.Models
{
    public class Pizzeria {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public List<Pizza> pizzas { get; set; }
        
    }
}