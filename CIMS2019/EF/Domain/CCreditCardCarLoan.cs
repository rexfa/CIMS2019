﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 信用卡和汽车贷款信息
    /// </summary>
    public class CCreditCardCarLoan : BaseEntity
    {
        public int CEId { get; set; }

        /// <summary>
        /// 每月还款
        /// </summary>
        public decimal MonthlyAmount { get; set; }
        public DateTime CreatedOn { set; get; }

        #region Navigation properties
        public CustomerExpectation CustomerExpectation { get; set; }
        #endregion
    }
}
