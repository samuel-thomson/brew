using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brew.Models
{
    public interface StaticMethodLayer
    {
        public Recipe GetNextRecipe(Recipe r)
        {
            if(r.Extraction == "over")
            {
                if(r.Body == "heavy")
                {
                    //corsen up
                    r.Grind += 1;
                    return r;
                }
                else //if(r.Body == "thin")
                {
                    //up dose
                    r.Dose += .5;
                    return r;
                }
            }
            else //if(r.Extraction == "under")
            {
                if(r.Body == "heavy")
                {
                    //down dose
                    r.Dose -= .5;
                    return r;
                }
                else //if(r.Body == "thin")
                {
                    //finer grind
                    r.Grind -= 1;
                    return r;
                }
            }
        }
    }
}
