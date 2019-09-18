using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CIMS2019.Models.Enum;
using CIMS2019.Models.Attribute;

namespace CIMS2019.Models
{
    public class InputAllDataModel
    {
        public string NowString { get; set; }
        public InputAllDataModel()
        {
            this.NowString = DateTime.Now.ToShortDateString();
        }
        //https://www.c-sharpcorner.com/article/asp-net-mvc5-jquery-form-validator/ 尚未完成
        [Display(Name = "信息使用授权")]
        public bool AgreeToInformationAuthorization {get;set;}
        [Display(Name = "服务合同")]
        public bool AgreeToServiceAuthorization { get; set; }
        #region 主要信息
        public int Id { set; get; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Required]
        [Display(Name = "姓名")]
        [MaxLength(30, ErrorMessage = "姓名不能超过30")]
        public string CustomerName { set; get; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        [Required]
        [Display(Name = "身份证")]
        [MaxLength(18, ErrorMessage = "不能超过18")]
        [RegularExpression(@"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$", ErrorMessage = "输入有误")]
        public string IDNumber { get; set; }
        /// <summary>
        /// 电话号码，基本上需要手机号码
        /// </summary>
        [Required]
        [Display(Name = "电话号码")]
        [MaxLength(18, ErrorMessage = "不能超过18")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "只能是数字")]
        public string PhoneNumber { get; set; }
        #endregion
        #region 主要业务信息
        /// <summary>
        /// 客户类型
        /// </summary>
        //[Display(Name = "客户类型")]
        //public int CustomerTypeId { get; set; }

        [Display(Name = "客户类型")]
        [EnumDataType(typeof(CustomerType))]
        public CustomerType customerType { get; set; }

        [Display(Name = "工作地点")]
        public string WorkingAddress { get; set; }
        /// <summary>
        /// 期望贷款金额
        /// </summary>
        [Display(Name = "期望贷款金额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal ExpectedLoanAmount { get; set; }
        /// <summary>
        /// 期望放款时间
        /// </summary>
        [Display(Name = "期望放款时间")]
        [DataType(DataType.Date)]
        public DateTime ExpectedLoanTime { get; set; }


        #region 附加数据的标签
        [Display(Name = "是否有人寿保单")]
        public bool HavingLifeInsurance { get; set; }
        [Display(Name = "是否有信用卡车辆贷款")]
        public bool HavingCreditCardCarLoan { get; set; }
        [Display(Name = "是否有房产")]
        public bool HavingRealEstate { get; set; }
        #endregion
        #endregion
        #region 信用信息
        /// <summary>
        /// 公司名称
        /// </summary>
        [Display(Name = "单位名称")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string CompanyName { set; get; }
        #region  自雇
        [Display(Name = "企业年营业额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal AnnualTurnover { set; get; }
        /// <summary>
        /// 每年增值税发票额度
        /// </summary>
        [Display(Name = "企业年增值税开票额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal AnnualVATInvoiceAmount { set; get; }
        /// <summary>
        /// 每年纳税额度
        /// </summary>
        [Display(Name = "企业年纳税额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal AnnualTaxAmount { set; get; }
        #endregion
        #region  打工
        [Display(Name = "税后工资")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal SalaryAfterTax { set; get; }
        [Display(Name = "是否有社保和公积金")]
        /// <summary>
        /// 是否有社保和住房公积金
        /// </summary>
        public bool HavingSIHF { set; get; }
        /// <summary>
        /// 社会保险基数
        /// </summary>
        [Display(Name = "社保缴存基数")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal SocialInsuranceBase { set; get; }
        /// <summary>
        /// 住房公积金基数
        /// </summary>
        [Display(Name = "公积金缴存基数")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal HousingFundBase { set; get; }
        #endregion

        #region 信用卡车贷
        /// <summary>
        /// 信用卡汽车贷款每月还款
        /// </summary>
        [Display(Name = "月供金额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal CCLMonthlyAmount { get; set; }
        /// <summary>
        /// 已经还款期数
        /// </summary>
        [Display(Name = "已经还款期数")]
        public int NumberOfRepaymentsCC { set; get; }
        #endregion
        #region 房产情况
        [Display(Name = "房屋地址")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string RealEstateAddress { set; get; }
        /// <summary>
        /// 贷款类型
        /// </summary>
        //[Display(Name = "贷款情况")]
        //public int LoanTypeId { set; get; }
        [Display(Name = "贷款情况")]
        [EnumDataType(typeof(RealEstateLoanType))]
        public RealEstateLoanType realEstateLoanType { set; get; }
        /// <summary>
        /// 性质
        /// </summary>
        //[Display(Name = "房屋性质")]
        //public int PropertyNatureId { set; get; }
        [Display(Name = "房屋性质")]
        [EnumDataType(typeof(RealEstatePropertyNature))]
        public RealEstatePropertyNature realEstatePropertyNature { set; get; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        [Display(Name = "建筑面积")]
        public decimal ConstructionArea { set; get; }
        /// <summary>
        /// 价值
        /// </summary>
        [Display(Name = "房屋价值")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "请校验金额")]
        public decimal RealEstateValue { set; get; }
        /// <summary>
        /// 贷款或者按揭银行
        /// </summary>
        [Display(Name = "银行名称")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string BankName { set; get; }
        /// <summary>
        /// 每月还款金额
        /// </summary>
        [Display(Name = "每月还款金额")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "只能是数字")]
        public decimal MonthlyPayment { set; get; }
        /// <summary>
        /// 已经还款期数
        /// </summary>
        [Display(Name = "已还期数")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "只能是数字")]
        public int NumberOfRepayments { set; get; }
        #endregion

        #region 人寿保险情况
        [Display(Name = "保险公司名称A")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string LifeInsuranceCompany0 { get; set; }
        [Display(Name = "每年保费A")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "只能是数字")]
        public decimal AnnualPremium0 { get; set; }
        [Display(Name = "最早保单生效时间A")]
        [DataType(DataType.Date)]
        public DateTime EarliestEffectiveTime0 { get; set; }

        [Display(Name = "保险公司名称B")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string LifeInsuranceCompany1 { get; set; }
        [Display(Name = "每年保费B")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "只能是数字")]
        public decimal AnnualPremium1 { get; set; }
        [Display(Name = "最早保单生效时间B")]
        [DataType(DataType.Date)]
        public DateTime EarliestEffectiveTime1 { get; set; }

        [Display(Name = "保险公司名称C")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string LifeInsuranceCompany2 { get; set; }
        [Display(Name = "每年保费C")]
        [RegularExpression(@"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,2})?)$", ErrorMessage = "只能是数字")]
        public decimal AnnualPremium2 { get; set; }
        [Display(Name = "最早保单生效时间C")]
        [DataType(DataType.Date)]
        public DateTime EarliestEffectiveTime2 { get; set; }
        #endregion
        #endregion
    }
}
