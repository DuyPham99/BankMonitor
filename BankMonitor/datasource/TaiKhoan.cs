//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankMonitor.datasource
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public string SOTK { get; set; }
        public string CMND { get; set; }
        public decimal SODU { get; set; }
        public string MACN { get; set; }
        public System.DateTime NGAYMOTK { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual ChiNhanh ChiNhanh { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
