namespace Nhom2.Ecom.Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProductComment")]
    public partial class ProductComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductComment()
        {
            ProductComments = new HashSet<ProductComment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Content { get; set; }

        public int? CreateBy { get; set; }

        public int? ProductID { get; set; }

        public int? ParentID { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModify { get; set; }

        public virtual Product Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductComment> ProductComments { get; set; }

        public virtual User User { get; set; }
    }
}
