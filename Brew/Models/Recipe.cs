using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brew.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Roaster { get; set; }
        public double Grind { get; set; }
        public double Dose { get; set; }
        public string Body { get; set; }
        public string Extraction { get; set; }
        public string UserId { get; set; }

        public Recipe()
        {

        }
        public Recipe(double grind, double dose)
        {
            this.Grind = grind;
            this.Dose = dose;
        }
        public Recipe(string origin, string roaster, double grind, double dose)
        {
            this.Grind = grind;
            this.Dose = dose;
            this.Origin = origin;
            this.Roaster = roaster;
        }
        public Recipe(double grind, double dose, string body, string extraction)
        {
            this.Grind = grind;
            this.Dose = dose;

            if (body == "thin")
            {
                this.Body = "thin";
            }
            else if (body == "heavy")
            {
                this.Body = "heavy";
            }

            if (extraction == "sour")
            {
                this.Extraction = "under";
            }
            else if (extraction == "bitter" || extraction == "salty")
            {
                this.Extraction = "over";
            }
        }
    }
}
