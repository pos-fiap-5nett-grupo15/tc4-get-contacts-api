using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetContacts.Application.DTOs.Contacts.GetContacts
{
    public class GetContactsRequest : IRequest<GetContactsRequest>
    {
        public string Email { get; set; }
        public int Ddd { get; set; }
    }
}
