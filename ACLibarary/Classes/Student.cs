using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACLibarary.Classes
{
    class Student
    {
        [JsonProperty(PropertyName = "name")]
        public string name;
        [JsonProperty(PropertyName = "index")]
        public string index;
        [JsonProperty(PropertyName = "grade")]
        public string grade;
        [JsonProperty(PropertyName = "cls")]
        public string cls;
        [JsonProperty(PropertyName = "borrowed")]
        public string borrowed;

        //public Student(string name, string index, int year, int cls) {
        //    this.name = name;
        //    this.year = year;
        //    this.index = index;
        //    this.cls = cls;
        //    borrowed = new ArrayList();
        //}
    }
}
