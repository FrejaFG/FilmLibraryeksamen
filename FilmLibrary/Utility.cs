using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Utility
    {
        public void ConvertMinutesToSeconds (int minutes)
        {
              if (minutes < 0)
            {
                throw new ArgumentOutOfRangeException("Bad pie");
            }
                
        }
    }
}
