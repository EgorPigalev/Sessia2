//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sessia2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscribers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscribers()
        {
            this.CRM = new HashSet<CRM>();
            this.EquipmentInstallations = new HashSet<EquipmentInstallations>();
        }
    
        public int SubscriberID { get; set; }
        public string SubscriberNomer { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int GenderID { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Place0fResidence { get; set; }
        public string ResidentialAddressID { get; set; }
        public string Seria { get; set; }
        public string Nomer { get; set; }
        public string DivisionCode { get; set; }
        public string IssuedBy { get; set; }
        public System.DateTime DateOfIssue { get; set; }
        public int ServiceContractID { get; set; }
    
        public virtual Contracts Contracts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRM> CRM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentInstallations> EquipmentInstallations { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ResidentialAddress ResidentialAddress { get; set; }
    }
}