//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YinghModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerRole()
        {
            this.Customer_CustomerRole_Mapping = new HashSet<Customer_CustomerRole_Mapping>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public bool Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_CustomerRole_Mapping> Customer_CustomerRole_Mapping { get; set; }
    }
}
