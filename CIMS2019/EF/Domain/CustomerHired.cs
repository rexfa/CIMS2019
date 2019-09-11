using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 打工信息
    /// </summary>
    public class CustomerHired : BaseEntity
    {
        public int CEId { get; set; }
        
        public string CompanyName { set; get; }
        public decimal SalaryAfterTax { set; get; }

        /// <summary>
        /// 是否有社保和住房公积金
        /// </summary>
        public bool HavingSIHF { set; get; }
        /// <summary>
        /// 社会保险基数
        /// </summary>
        public decimal SocialInsuranceBase { set; get; }
        /// <summary>
        /// 住房公积金基数
        /// </summary>
        public decimal HousingFundBase { set; get; }

        public DateTime CreatedOn { set; get; }

        #region Navigation properties
        public CustomerExpectation CustomerExpectation { get; set; }
        #endregion

    }
}
