using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 自雇信息
    /// </summary>
    public class CustomerSelfEmployed : BaseEntity
    {
        public int CEId { get; set; }
        public string CompanyName { set; get; }
        public decimal AnnualVATInvoiceAmount { set; get; }
        public decimal  AnnualTaxAmount { set; get; }
        public DateTime CreatedOn { set; get; }

        #region Navigation properties
        public CustomerExpectation CustomerExpectation { get; set; }
        #endregion
    }
}
