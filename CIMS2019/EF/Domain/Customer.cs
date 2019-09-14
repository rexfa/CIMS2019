using System;
using System.Collections.Generic;

namespace CIMS2019.EF.Domain
{
    /// <summary>
    /// 客户基础信息表
    /// </summary>
    public class Customer : BaseEntity
    {
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

        //以下为系统专用
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { set; get; }
        public string CPassword { set; get; }
        /// <summary>
        /// 密码盐 
        /// </summary>
        public string Salt { set; get; }
        public string Avatar { set; get; }
        public DateTime CreatedOn { set; get; }

        /// <summary>
        /// 记录热度标签
        /// </summary>
        public int Fever { set; get; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public bool IsDeleted { set; get; }

        #region Navigation properties
        public virtual ICollection<CustomerExpectation> CustomerExpectations { set; get; }
        #endregion
    }
}
