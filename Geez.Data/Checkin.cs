//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geez.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Checkin
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime DateTime { get; set; }
        public int ServiceProviderId { get; set; }
    
        public virtual ServiceProvider ServiceProvider { get; set; }
    }
}
