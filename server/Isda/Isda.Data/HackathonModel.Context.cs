﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class HackathonEntities : DbContext
    {
        public HackathonEntities()
            : base("name=HackathonEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Haul> Hauls { get; set; }
        public DbSet<HaulGearXREF> HaulGearXREFs { get; set; }
        public DbSet<HaulPhoto> HaulPhotoes { get; set; }
        public DbSet<LandingSite> LandingSites { get; set; }
        public DbSet<Vessel> Vessels { get; set; }
        public DbSet<ViewHaulDetail> ViewHaulDetails { get; set; }
    
        public virtual ObjectResult<DeltaOverTimeByLanding_Result> DeltaOverTimeByLanding(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2, Nullable<System.DateTime> date3, Nullable<System.DateTime> date4)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            var date3Parameter = date3.HasValue ?
                new ObjectParameter("date3", date3) :
                new ObjectParameter("date3", typeof(System.DateTime));
    
            var date4Parameter = date4.HasValue ?
                new ObjectParameter("date4", date4) :
                new ObjectParameter("date4", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeltaOverTimeByLanding_Result>("DeltaOverTimeByLanding", date1Parameter, date2Parameter, date3Parameter, date4Parameter);
        }
    
        public virtual ObjectResult<CountAndWeightByLongLat_Result> CountAndWeightByLongLat(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2, Nullable<int> precision, Nullable<decimal> lat1, Nullable<decimal> lng1, Nullable<decimal> lat2, Nullable<decimal> lng2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            var precisionParameter = precision.HasValue ?
                new ObjectParameter("precision", precision) :
                new ObjectParameter("precision", typeof(int));
    
            var lat1Parameter = lat1.HasValue ?
                new ObjectParameter("lat1", lat1) :
                new ObjectParameter("lat1", typeof(decimal));
    
            var lng1Parameter = lng1.HasValue ?
                new ObjectParameter("lng1", lng1) :
                new ObjectParameter("lng1", typeof(decimal));
    
            var lat2Parameter = lat2.HasValue ?
                new ObjectParameter("lat2", lat2) :
                new ObjectParameter("lat2", typeof(decimal));
    
            var lng2Parameter = lng2.HasValue ?
                new ObjectParameter("lng2", lng2) :
                new ObjectParameter("lng2", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CountAndWeightByLongLat_Result>("CountAndWeightByLongLat", date1Parameter, date2Parameter, precisionParameter, lat1Parameter, lng1Parameter, lat2Parameter, lng2Parameter);
        }
    
        public virtual ObjectResult<DeltaOverTimeByLongLat_Result> DeltaOverTimeByLongLat(Nullable<System.DateTime> date1, Nullable<System.DateTime> date2, Nullable<System.DateTime> date3, Nullable<System.DateTime> date4, Nullable<int> precision, Nullable<decimal> lat1, Nullable<decimal> lng1, Nullable<decimal> lat2, Nullable<decimal> lng2)
        {
            var date1Parameter = date1.HasValue ?
                new ObjectParameter("date1", date1) :
                new ObjectParameter("date1", typeof(System.DateTime));
    
            var date2Parameter = date2.HasValue ?
                new ObjectParameter("date2", date2) :
                new ObjectParameter("date2", typeof(System.DateTime));
    
            var date3Parameter = date3.HasValue ?
                new ObjectParameter("date3", date3) :
                new ObjectParameter("date3", typeof(System.DateTime));
    
            var date4Parameter = date4.HasValue ?
                new ObjectParameter("date4", date4) :
                new ObjectParameter("date4", typeof(System.DateTime));
    
            var precisionParameter = precision.HasValue ?
                new ObjectParameter("precision", precision) :
                new ObjectParameter("precision", typeof(int));
    
            var lat1Parameter = lat1.HasValue ?
                new ObjectParameter("lat1", lat1) :
                new ObjectParameter("lat1", typeof(decimal));
    
            var lng1Parameter = lng1.HasValue ?
                new ObjectParameter("lng1", lng1) :
                new ObjectParameter("lng1", typeof(decimal));
    
            var lat2Parameter = lat2.HasValue ?
                new ObjectParameter("lat2", lat2) :
                new ObjectParameter("lat2", typeof(decimal));
    
            var lng2Parameter = lng2.HasValue ?
                new ObjectParameter("lng2", lng2) :
                new ObjectParameter("lng2", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeltaOverTimeByLongLat_Result>("DeltaOverTimeByLongLat", date1Parameter, date2Parameter, date3Parameter, date4Parameter, precisionParameter, lat1Parameter, lng1Parameter, lat2Parameter, lng2Parameter);
        }
    }
}
