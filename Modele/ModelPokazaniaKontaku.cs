using System;
using System.ComponentModel.DataAnnotations;

namespace netPcListaKontaktow.Modele
{
    public class ModelPokazaniaKontaku
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Imie jest zbyt dlugie")]
        [MinLength(5, ErrorMessage ="Imie jest zbyt krótkie")]
        public string Imie { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Nazwisko jest zbyt dlugie")]
        [MinLength(5, ErrorMessage ="Nazwisko jest zbyt krótkie")]
        public string Nazwisko { get; set; }

        [Required]
        [EmailAddress]
        public string AdresEmail { get; set; }

        public string Haslo { get; set; }

        [StringLength(8, ErrorMessage = "Kategoria jest zbyt dlugie")]
        public string Kategoria { get; set; }
        public string NumerTelefonu { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public ModelPokazaniaKontaku()
        {
            DataUrodzenia = DateTime.Now;
        }

    }
}
