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
    
    public partial class Application
    {
        public Application()
        {
            this.Menu = new HashSet<Menu>();
        }
    
        public int Id { get; set; }
        public string FileName { get; set; }
        public string AssemblyName { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public string ServiceUrl { get; set; }
    
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
