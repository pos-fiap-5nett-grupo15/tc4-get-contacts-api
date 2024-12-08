
using TechChallenge3.Domain.Entities.Contact;

namespace CreateContact.Infrastructure.Services.Contact
{
    public interface IContactService
    {

        Task<ContactEntity?> GetByIdAsync(int id);

        Task<IEnumerable<ContactEntity>> GetListPaginatedByFiltersAsync(int? ddd, int currentIndex, int pageSize);
    }
}
