//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class direcciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public direcciones()
        {
            this.personas = new HashSet<personas>();
        }
    
        public int id_direcciones { get; set; }
        public string pais { get; set; }
        public string localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string piso { get; set; }
        public string departamento { get; set; }
        public string cod_postal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personas> personas { get; set; }
    }
}
