//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce.DATOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.DetalleProductoes = new HashSet<DetalleProducto>();
            this.Imagenes = new HashSet<Imagene>();
        }
    
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string DescripcionBreve { get; set; }
        public int IdCategoria { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProducto> DetalleProductoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imagene> Imagenes { get; set; }
    }
}
