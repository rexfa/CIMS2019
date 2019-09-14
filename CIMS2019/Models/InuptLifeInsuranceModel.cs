using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIMS2019.Models
{
    public class InputLifeInsuranceModel
    {

        [Display(Name = "保险公司名称")]
        [MaxLength(200, ErrorMessage = "不能超过200")]
        public string LifeInsuranceCompany { get; set; }
        /// <summary>
        /// 每年保费
        /// </summary>
        [Display(Name = "每年保费")]
        [RegularExpression(@"((?=.*\d)(?=.*\D))^$", ErrorMessage = "只能是数字")]
        public decimal AnnualPremium { get; set; }
        /// <summary>
        /// 最早生效时间
        /// </summary>
        [Display(Name = "最早保单生效时间")]
        public DateTime EarliestEffectiveTime { get; set; }
    }
}
