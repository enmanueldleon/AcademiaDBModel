//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademiaDBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personas
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int GenerosId { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
    
        public virtual Generos Genero { get; set; }
    }
}
