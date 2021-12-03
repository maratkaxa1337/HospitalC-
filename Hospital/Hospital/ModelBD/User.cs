//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.ModelBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string RoleID { get; set; }
        public System.DateTime BrithDay { get; set; }
        public string HomeAddress { get; set; }
        public string CodeMKB { get; set; }
        public Nullable<System.DateTime> DateStartDiseases { get; set; }
        public Nullable<System.DateTime> DateStopDiseases { get; set; }
        public Nullable<int> CodeID { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string GenderID { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual MKB MKB { get; set; }
        public virtual Role Role { get; set; }
    }
}
