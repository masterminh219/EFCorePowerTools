﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldingTester.Models
{
    public partial class RegionShipper
    {
        public int RegionId { get; set; }
        public int ShipperId { get; set; }

        public virtual Region Region { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}