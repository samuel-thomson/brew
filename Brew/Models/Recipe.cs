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
        public Recipe()
        {

        }
        public Recipe(float grind, float dose)
        {
            this.Grind = grind;
            this.Dose = dose;
        }
        
    }
}
