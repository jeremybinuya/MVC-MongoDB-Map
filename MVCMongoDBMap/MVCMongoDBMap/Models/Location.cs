using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace MVCMongoDBMap.Models
{
    
    public class Location
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public String _id { get; set; }

        [Required]
        public String LocationID { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public String Lat { get; set; }

        [Required]
        public String Long { get; set; }

        [Required]
        public String Address { get; set; }

        [Required]
        public String ImagePath { get; set; }


    }
}
