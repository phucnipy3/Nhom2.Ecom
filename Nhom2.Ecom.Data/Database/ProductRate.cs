namespace Nhom2.Ecom.Data.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ProductRate")]
    public partial class ProductRate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? RatePoint { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateBy { get; set; }

        public int? ProductID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
