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
        public int CustomerTypeId { get; set; }
        public string WorkingAddress { get; set; }
        public decimal ExpectedLoanAmount { get; set; }
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
