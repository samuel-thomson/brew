using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brew.Models
{
    public class Recipe
    {
        public float Grind { get; set; }
        public float Dose { get; set; }
        public string Body { get; set; }
        public string Extraction { get; set; }

        public Recipe()
        {

        }
        public Recipe(float grind, float dose)
        {
            this.Grind = grind;
            this.Dose = dose;
        }
        public void GetExtraction(string s)
        {
            if(s == "sour")
            {
                this.Extraction = "under";
            }
            else if(s == "bitter" || s == "salty")
            {
                this.Extraction = "over";
            }
        }
        public void GetBody(string b)
        {
            if(b == "thin")
            {
                this.Body = "thin";
            }
            else if(b == "heavy") 
            {
                this.Body = "heavy";
            }
        }
    }
}
