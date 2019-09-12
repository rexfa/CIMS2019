using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.Models
{
    public class InputLifeInsuranceModel
    {
        public string LifeInsuranceCompany { get; set; }
        /// <summary>
        /// 每年保费
        /// </summary>
        public decimal AnnualPremium { get; set; }
        /// <summary>
        /// 最早生效时间
        /// </summary>
        public DateTime EarliestEffectiveTime { get; set; }
    }
}
