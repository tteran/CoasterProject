using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoasterProject.Models
{
    /// <summary>
    /// Properties of roller coasters
    /// </summary>
    public class RollerCoasters
    {
        public string Name { get; set; }
        public int BuildYear { get; set; }
        public int Speed { get; set; }
        public int Height { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int MinHeight { get; set; }
        public string RideVideo { get; set; }
        public string RideImage { get; set; }
    }
}
