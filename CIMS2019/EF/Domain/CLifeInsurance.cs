using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 人寿保险信息
    /// </summary>
    public class CLifeInsurance : BaseEntity
    {
        public int CustomerExpectationId { get; set; }

        public string LifeInsuranceCompany { get; set; }
        /// <summary>
        /// 每年保费
        /// </summary>
        public decimal AnnualPremium { get; set; }
        /// <summary>
        /// 最早生效时间
        /// </summary>
        public DateTime EarliestEffectiveTime { get; set; }
        public DateTime CreatedOn { set; get; }
        #region Navigation properties
        public virtual CustomerExpectation CustomerExpectation { get; set; }
        #endregion
    }
}
