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
        public string ExpectedLoanAmount { get; set; }
        public DateTime ExpectedLoanTime { get; set; }
        public DateTime CreatedOn { set; get; }
    }
}
