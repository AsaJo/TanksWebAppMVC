using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TanksWebAppMVC.Models
{
    public class Tank
    {
        public Tank(string type, string designation, Country country, string designer, int designed, string manufacturer, double mass, double length, double width, double height, int crew, Cannon mainArmament, int ammoCapacity)
        {
            Type = type;
            Designation = designation;
            Country = country;
            Designer = designer;
            Designed = designed;
            Manufacturer = manufacturer;
            Mass = mass;
            Length = length;
            Width = width;
            Height = height;
            Crew = crew;
            MainArmament = mainArmament;
            AmmoCapacity = ammoCapacity;
        }

        public int TankId { get; set; }
        public string Type { get; set; }
        public string Designation { get; set; }
        public Country Country { get; set; }
        public string Designer { get; set; }
        public int Designed { get; set; }
        public string Manufacturer { get; set; }
        public double Mass { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Crew { get; set; }
        public Cannon MainArmament { get; set; }
        public int AmmoCapacity { get; set; }

    }
    
}
