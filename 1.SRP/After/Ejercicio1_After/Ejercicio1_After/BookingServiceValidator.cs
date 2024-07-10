using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1_After
{
    public static class BookingServiceValidator
    {
        public static ValidationResult Validate(Booking booking)
        {
            ValidationResult validationResult = new ValidationResult();

            if (string.IsNullOrEmpty(booking.Usuario.Nombres))
                validationResult.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar un nombre.");

            if (string.IsNullOrEmpty(booking.Usuario.Email) || !booking.Usuario.Email.Contains("@"))
                validationResult.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar un email valido.");          

            if (booking.checkIn.Equals(DateTime.MinValue))
                validationResult.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");
      
            if (booking.checkOut.Equals(DateTime.MinValue))
                validationResult.ErrorMessage.Add("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");

            if (booking.checkIn > booking.checkOut)
                validationResult.ErrorMessage.Add("La reserva no puede ser agendada, debido a que la fecha de salida no puede ser menor a la fecha de entrada.");

            return validationResult;
        }

    }
}
