//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NNStore.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string ShortDes { get; set; }
        public string FullDescription { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Img { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PriceSale { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<int> Status { get; set; }
    }
}