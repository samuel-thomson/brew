using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brew.Models
{
    public class Recipe
    {
        public double Grind { get; set; }
        public double Dose { get; set; }
        public string Body { get; set; }
        public string Extraction { get; set; }

        public Recipe()
        {

        }
        public Recipe(double grind, double dose)
        {
            this.Grind = grind;
            this.Dose = dose;
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
        //public void GetExtraction(string s)
        //{
        //    if(s == "sour")
        //    {
        //        this.Extraction = "under";
        //    }
        //    else if(s == "bitter" || s == "salty")
        //    {
        //        this.Extraction = "over";
        //    }
        //}
        //public void GetBody(string b)
        //{
        //    if(b == "thin")
        //    {
        //        this.Body = "thin";
        //    }
        //    else if(b == "heavy") 
        //    {
        //        this.Body = "heavy";
        //    }
        //}
    }
}
