//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class images
    {
        public int imageId { get; set; }
        public Nullable<int> productId { get; set; }
        public byte[] imgName { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
