//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHFirstDraft.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MealOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MealOption()
        {
            this.DietDetails = new HashSet<DietDetail>();
            this.MealTags = new HashSet<MealTag>();
            this.Comments = new HashSet<Comment>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> NutrientID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DietDetail> DietDetails { get; set; }
        public virtual Nutrient Nutrient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTag> MealTags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
