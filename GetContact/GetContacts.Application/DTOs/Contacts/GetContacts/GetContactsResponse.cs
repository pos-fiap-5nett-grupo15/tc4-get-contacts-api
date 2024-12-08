using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechChallenge3.Common.DTOs;
using TechChallenge3.Domain.Entities.Contact;

namespace GetContacts.Application.DTOs.Contacts.GetContacts
{
    public class GetContactsResponse : BaseReponse
    {
        public int Id {  get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Ddd { get; set; }
        public int Telefone { get; set; }
    }
}
