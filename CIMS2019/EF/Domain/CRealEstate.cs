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
        public string Address { set; get; }
        /// <summary>
        /// 贷款类型
        /// </summary>
        public int LoanTypeId { set; get; }
        /// <summary>
        /// 性质
        /// </summary>
        public int PropertyNatureId { set; get; }
        /// <summary>
        /// 价值
        /// </summary>
        public decimal Value { set; get; }
        public DateTime CreatedOn { set; get; }
    }
}
