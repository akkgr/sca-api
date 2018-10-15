using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Sca.Api.Entities;

namespace Sca.Api.Entities
{
    public class DbContext
    {
        public DbContext(string connectionString)
        {
            var url = new MongoUrl(connectionString);
            var client = new MongoClient(url);
            var database = client.GetDatabase("sca");

            Applicants = database.GetCollection<Applicant>("applicant");
        }

        public IMongoCollection<Applicant> Applicants { get; set; }

        private void EnsureIndexes()
        {
            var options = new CreateIndexOptions();
            options.Unique = true;
        }

        public static void Init()
        {
            BsonClassMap.RegisterClassMap<BaseEntity>(cm =>
            {
                cm.AutoMap();
                cm.SetIdMember(cm.GetMemberMap(c => c.Id)
                    .SetSerializer(new StringSerializer(BsonType.ObjectId))
                    .SetIdGenerator(StringObjectIdGenerator.Instance));
            });

            BsonClassMap.RegisterClassMap<Person>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Applicant>(cm =>
            {
                cm.AutoMap();
            });
        }
    }
}