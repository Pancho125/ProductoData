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
    
    public partial class Empleado
    {
        public string EmpleadoCodigo { get; set; }
        public string EmpleadoCargo { get; set; }
        public string EmpleadoUser { get; set; }
        public string EmpleadoPassword { get; set; }
        public string CodigoPersona { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}