//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Isda.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HaulGearXREF
    {
        public int HaulGearId { get; set; }
        public int HaulId { get; set; }
        public int GearId { get; set; }
    
        public virtual Gear Gear { get; set; }
        public virtual Haul Haul { get; set; }
    }
}
