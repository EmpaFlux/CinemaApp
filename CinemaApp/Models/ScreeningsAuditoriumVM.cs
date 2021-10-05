using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaApp.Models
{
    public class ScreeningAuditoriumVM
    {
        public IList<Screening> Screenings { get; set; }
        public IList<Auditorium> Auditoriums { get; set; }


    }
}
