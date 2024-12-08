using TechChallenge3.Domain.Entities.Contact;

namespace CreateContact.Infrastructure.Repositories.Contact
{
    public interface IGetContactRepository
    {
        Task<ContactEntity?> GetByIdAsync(int id);
        Task<IEnumerable<ContactEntity>> GetListPaginatedByFiltersAsync(int? ddd, int currentIndex, int pageSize);
    }
}
