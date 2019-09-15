using System;
using System.ComponentModel.DataAnnotations;

namespace CIMS2019.Models
{
    public class ErrorViewModel
    {
        [Display(Name ="��������")]
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}