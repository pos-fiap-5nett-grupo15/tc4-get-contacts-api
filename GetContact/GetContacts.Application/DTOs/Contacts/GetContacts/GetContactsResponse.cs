using TechChallenge3.Common.DTOs;

namespace GetContacts.Application.DTOs.Contacts.GetContacts
{
    public class GetContactsResponse : BaseReponse
    {
        public int Id {  get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Ddd { get; set; }
        public int Telefone { get; set; }
        public string? SituacaoAnterior { get; set; }
        public string? SituacaoAtual { get; set; }
    }
}
