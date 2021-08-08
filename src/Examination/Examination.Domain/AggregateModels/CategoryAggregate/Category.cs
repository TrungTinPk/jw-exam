using Examination.Domain.SeedWork;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Domain.AggregateModels.CategoryAggregate
{
    public class Category : Entity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("urlPath")]
        public string UrlPath { set; get; } //domain/exam-category-1/
    }
}
