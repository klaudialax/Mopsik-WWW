﻿using mopsik_www.Models;
using System.Collections.Generic;

namespace mopsik_www.ViewModels
{
    public class MopViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Chainage { get; set; }
        public string Direction { get; set; }
        public string RoadNumber { get; set; }
        public string Town { get; set; }
        public string LatitudePrint { get; set; }
        public string LongitudePrint { get; set; }
        public Operator Operator { get; set; }
        public Dictionary<string, bool> Facilities { get; set; }
        public Coordinates Coordinates { get; set; }
        public SpacesCount Available { get; set; }
        public SpacesCount Taken { get; set; }
        public SpacesCount Free { get; set; }
        public SpacesUsage Usage { get; set; }

        static public Dictionary<string, bool> ParseFacilities(FacilitiesParser fp)
        {
            return new Dictionary<string, bool>()
            {
                { "monitoring", fp.Monitoring},
                { "garage", fp.Garage },
                { "toilets", fp.Toilets },
                { "petrol_station", fp.PetrolStation },
                { "dangerous_cargo_places", fp.DangerousCargoPlaces },
                { "sleeping_places", fp.SleepingPlaces },
                { "restaurant", fp.Restaurant },
                { "car_wash", fp.CarWash },
                { "security", fp.Lighting },
                { "lighting", fp.Security },
            }; ;
        }

        public MopViewModel(Mop m)
        {
            Id = m.Id;
            Title = m.Title;
            Chainage = m.Chainage;
            Direction = m.Direction;
            RoadNumber = m.RoadNumber;
            Town = m.Town;
            Operator = m.Operator;
            Facilities = ParseFacilities(m.Facilities);
            Coordinates = new Coordinates(m.Coordinates.Longitude, m.Coordinates.Latitude);
            Available = m.Available;
            Taken = m.Taken;
            Free = new SpacesCount(m.Available.Bus - m.Taken.Bus, m.Available.Car - m.Taken.Car, m.Available.Truck - m.Taken.Truck);
            Usage = new SpacesUsage(m.Available, m.Taken);
        }
    }
}
