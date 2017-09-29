namespace baitapnhom1.Model.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chucvu")]
    public partial class chucvu
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
