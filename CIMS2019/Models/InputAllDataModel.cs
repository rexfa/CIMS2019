using System;
using System.Collections.Generic;

namespace CIMS2019.Models
{
    public class InputAllDataModel
    {
        #region 主要信息
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string CustomerName { set; get; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IDNumber { get; set; }
        /// <summary>
        /// 电话号码，基本上需要手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
        #endregion
        #region 主要业务信息
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
        #endregion
        #region 信用信息
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { set; get; }
        #region  自雇
        /// <summary>
        /// 每年增值税发票额度
        /// </summary>
        public decimal AnnualVATInvoiceAmount { set; get; }
        /// <summary>
        /// 每年纳税额度
        /// </summary>
        public decimal AnnualTaxAmount { set; get; }
        #endregion
        #region  打工
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
        #endregion
        /// <summary>
        /// 信用卡和汽车贷款每月还款
        /// </summary>
        public decimal MonthlyAmount { get; set; }

        #region 房产情况
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
        #endregion
        #region 人寿保险情况
        List<InputLifeInsuranceModel> LifeInsurances { set; get; }
        #endregion
        #endregion


    }
}
