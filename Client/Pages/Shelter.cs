using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Booking
{
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public Properties Properties { get; set; }
    }

    public class Geometry
    {

        public string Type { get; set; }
    }

    public class Properties
    {
        [BsonElement("navn")]
        public string Navn { get; set; }

        [BsonElement("antal_pl")]
        public int AntalPersoner { get; set; }

        [BsonElement("facil_ty")]
        public string Faciliteter { get; set; }

        // Add properties for other fields in 'properties'
        // ...
    }
}
