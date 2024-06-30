using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Id - number of price
        /// </summary>
        public int PrizeNumber { get; set; }
        /// <summary>
        /// Name of the prize
        /// </summary>
        public string PrizeName { get; set; }
        /// <summary>
        /// Amount of prize
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
