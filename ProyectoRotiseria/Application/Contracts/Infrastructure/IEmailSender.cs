using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}

/*La carpeta contract contiene los contratos de la API. Los contratos son interfaces que definen las operaciones que se pueden realizar en la API.
 * La carpeta infrastructure contiene la infraestructura de la aplicación. La infraestructura incluye cosas como el almacenamiento, la autenticación y la autorización.*/
 