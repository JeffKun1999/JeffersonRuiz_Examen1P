using System.ComponentModel.DataAnnotations;

namespace JeffersonRuiz_Examen1P.Models
{
    public class JR_tabla1
    {
        public int JR_Int_Atributo1 { get; set; }
        [Required]
        public string? JR_String_Atributo2 { get; set; }

        public bool JR_Booleano_Atributo3 {  get; set; }
        [Range(0.01,20)]
        public decimal JR_Decimal_Atributo4 {  get; set; }
        public DateTime JR_Fecha_Atributo5 { get; set; }


    }
}
