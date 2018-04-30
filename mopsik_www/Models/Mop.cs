﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mopsik_www.Models
{
    public class Mop
    {

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("chainage")]
        public string Chainage { get; set; }
        [JsonProperty("direction")]
        public string Direction { get; set; }
        [JsonProperty("road_number")]
        public string RoadNumber { get; set; }
        [JsonProperty("town")]
        public string Town { get; set; }
        [JsonProperty("operator")]
        public Operator Operator { get; set; }
        [JsonProperty("facilities")]
        public Facilities Facilities { get; set; }
        [JsonProperty("coords")]
        public Coordinates Coordinates { get; set; }
        [JsonProperty("available")]
        public SpacesCount Available { get; set; }
        [JsonProperty("taken")]
        public SpacesCount Taken { get; set; }

        static public List<Mop> DeserializeJSON(string json)
        {
            return JsonConvert.DeserializeObject<Dictionary<int, Mop>>(json).Values.ToList();
        }

    }

}
