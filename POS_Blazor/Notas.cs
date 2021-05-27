using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_Blazor
{
    public class Notas
    {
        /*
         * VALIDACIONES
         CORREOS: AGRAGR EN LA VARIABLE DEL CORREO
        [Required(ErrorMessage = "La dirección de correo electrónico es obligatoria.")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico inválida")]
         
        PARA QUE SE PUEDA REALIZAR LAS VALIDACIONES AGREGAR 
        <EditForm Model="@_prod">
             <DataAnnotationsValidator/> <-- AGREGAR: PARA QUE SE PUEDA REALIZAR LAS VALIDACIONES

        <InputText class="form-control" @bind-Value="@_prod.(VARIABLE CORREO)"></InputText>
        <ValidationMessage For="(()=>_prod.VARIABLE CORREO)"/> <-- AGREAGAR

        [Display(Name = "CODIGO")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
        [Range(01, 99, ErrorMessage = "El Campo {0} debe ser un numero entre 01 y {2}")]
        public int Codi { get; set; }
        
        [Display(Name = "DESCRIPCION")]
        [Required]
        [StringLength(15)]
        [RegularExpression("^[A-ZÑÁÉÍÓÚ]+$", ErrorMessage = "* .. solo letras mayúsculas")]
        public string Desc { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        para mas validaciones revisar en: https://docs.microsoft.com/es-es/dotnet/api/system.componentmodel.dataannotations?view=net-5.0
         */
    }
}
