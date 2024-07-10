using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_After
{
    public class BookingService
    {
        public string Create(Booking booking)
        {
            ValidationResult validationResult = BookingServiceValidator.Validate(booking);

            //Environment.NewLine es "\r\n -> separador de linesa
            return validationResult.IsValid ?
                $"La cita quedo agendada para el paciente   {booking.Usuario.Nombres}."
                : string.Join(Environment.NewLine, validationResult.ErrorMessage);

        }

    }
}
