using MongoDB.Bson;
using System;

namespace CSharpEgitimKampi601.Entities
{
    internal class BSonRepresentationAttribute : Attribute
    {
        private BsonType objectId;

        public BSonRepresentationAttribute(BsonType objectId)
        {
            this.objectId = objectId;
        }
    }
}