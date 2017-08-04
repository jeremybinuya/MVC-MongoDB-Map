using MongoDB.Driver;
using System;

namespace MVCMongoDBMap.Models
{
    public class LocationDB
    {
        //For Best practice, Please put this in the web.config. This is only for demo purpose.
        //====================================================
        public String connectionString = "mongodb://localhost";
        public String DataBaseName = "MapDB";
        //====================================================

        public MongoDatabase Database;

        public LocationDB()
        {
            var client = new MongoClient(connectionString);
            var server = client.GetServer();

            Database = server.GetDatabase(DataBaseName);
        }

        public MongoCollection<Location> Locations
        {
            get
            {
                var Locations = Database.GetCollection<Location>("Locations");

                return Locations;
            }
        }
    }
}