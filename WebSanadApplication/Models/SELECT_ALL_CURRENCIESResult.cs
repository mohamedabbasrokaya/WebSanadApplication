﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSanadApplication.Models
{
    public partial class SELECT_ALL_CURRENCIESResult
    {
        public short CURRENCY_ID { get; set; }
        public string CURRENCY_CODE { get; set; }
        public string CURRENCY_AR_NAME { get; set; }
        public string CURRENCY_EN_NAME { get; set; }
        public string CURRENCY_SUB_AR_NAME { get; set; }
        public string CURRENCY_SUB_EN_NAME { get; set; }
        public double CURRENCY_RATE { get; set; }
        public short SUB_TO_CURRENCY_TRANS { get; set; }
        public double? CURRENCY_FIXED_RATE { get; set; }
    }
}
