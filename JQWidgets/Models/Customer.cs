using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JQWidgets.Models
{
    public class Customer
    {
        public int Id { get; set; }     
        public string Name { get; set; }     
        public int Age { get; set; }     
        public Gender Gender { get; set; }     
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Male,
        Female
    }
}
