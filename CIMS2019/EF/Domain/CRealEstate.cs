using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 不动产信息
    /// </summary>
    public class CRealEstate : BaseEntity
    {
        public int CEId { get; set; }
        public string RealEstateAddress { set; get; }
        /// <summary>
        /// 贷款类型
        /// </summary>
        public int LoanTypeId { set; get; }
        /// <summary>
        /// 性质
        /// </summary>
        public int PropertyNatureId { set; get; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        public decimal ConstructionArea { set; get; }
        /// <summary>
        /// 价值
        /// </summary>
        public decimal RealEstateValue { set; get; }
        /// <summary>
        /// 贷款或者按揭银行
        /// </summary>
        public string BankName { set; get; }
        /// <summary>
        /// 每月还款金额
        /// </summary>
        public decimal MonthlyPayment { set; get; }
        /// <summary>
        /// 已经还款期数
        /// </summary>
        public int NumberOfRepayments { set; get; }
        public DateTime CreatedOn { set; get; }
        #region Navigation properties
        public virtual CustomerExpectation CustomerExpectation { get; set; }
        #endregion
    }
}
