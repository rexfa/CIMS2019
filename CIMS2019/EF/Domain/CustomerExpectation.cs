using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 客户类型和期望信息
    /// </summary>
    public class CustomerExpectation : BaseEntity
    {
        public int CustomerId { get; set; }
        /// <summary>
        /// 客户类型
        /// </summary>
        public int CustomerTypeId { get; set; }
        public string WorkingAddress { get; set; }
        /// <summary>
        /// 希望贷款金额
        /// </summary>
        public decimal ExpectedLoanAmount { get; set; }
        /// <summary>
        /// 希望放款时间
        /// </summary>
        public DateTime ExpectedLoanTime { get; set; }
        public DateTime CreatedOn { set; get; }

        #region Navigation properties
        public Customer Customer { set; get; }        
        public virtual ICollection<CCreditCardCarLoan> CCreditCardCarLoans { set; get; }
        public virtual ICollection<CLifeInsurance> CLifeInsurances { set; get; }
        public virtual ICollection<CRealEstate> CRealEstates { set; get; }
        public virtual ICollection<CustomerHired> CustomerHireds { set; get; }
        public virtual ICollection<CustomerSelfEmployed> CustomerSelfEmployeds { set; get; }
        #endregion
    }
}
