using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TutorialEntityFrameworkCore.Models
{
    public class Estudiante
    {   
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
    }
}
