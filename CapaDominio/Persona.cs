//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        public Persona()
        {
            this.Empleado = new HashSet<Empleado>();
            this.Gerente = new HashSet<Gerente>();
        }
    
        public string PersonaCodigo { get; set; }
        public string PersonaDNI { get; set; }
        public string PersonaApellidoMaterno { get; set; }
        public string PersonaApellidoPaterno { get; set; }
        public string PersonaNombre { get; set; }
        public string PersonaNombreCompleto { get; set; }
        public string PersonaEdad { get; set; }
        public string PersonaSexo { get; set; }
        public string PersonaDireccion { get; set; }
        public string PersonaTelefono { get; set; }
        public string PersonaCorreo { get; set; }
    
        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Gerente> Gerente { get; set; }
    }
}
