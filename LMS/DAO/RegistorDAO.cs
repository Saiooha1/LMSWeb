﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.DAO
{
    public class RegistorDAO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        public string Role { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime bsonDateTime { get; set; }

        public int IsActive { get; set; }
    }
}
