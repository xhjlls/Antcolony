//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Power
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Power()
        {
            this.Role_Post_Power = new HashSet<Role_Post_Power>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Route { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> DeleteTime { get; set; }
        public short State { get; set; }
        public bool IsCompany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role_Post_Power> Role_Post_Power { get; set; }
        public virtual TeamRole_Post_Power TeamRole_Post_Power { get; set; }
    }
}