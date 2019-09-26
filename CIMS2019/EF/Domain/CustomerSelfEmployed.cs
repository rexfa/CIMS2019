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
        /// <summary>
        /// 企业年流水（营业额）
        /// </summary>
        public decimal AnnualTurnover { set; get; }
        /// <summary>
        /// 每年增值税发票额度
        /// </summary>
        public decimal AnnualVATInvoiceAmount { set; get; }
        /// <summary>
        /// 每年纳税额度
        /// </summary>
        public decimal  AnnualTaxAmount { set; get; }
        public DateTime CreatedOn { set; get; }

        #region Navigation properties
        public virtual CustomerExpectation CustomerExpectation { get; set; }
        #endregion
    }
}
