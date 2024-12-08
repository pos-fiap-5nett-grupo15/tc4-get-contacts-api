using CreateContact.Infrastructure.UnitOfWork;
using TechChallenge3.Domain.Entities.Contact;

namespace CreateContact.Infrastructure.Services.Contact
{
    public class ContactService : IContactService
    {
        private readonly IGetContactUnitOfWork _unitOfWork;

        public ContactService(IGetContactUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }




        public async Task<ContactEntity?> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetContactRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ContactEntity>> GetListPaginatedByFiltersAsync(int? ddd, int currentIndex, int pageSize)
        {
            return await _unitOfWork.GetContactRepository.GetListPaginatedByFiltersAsync(ddd, currentIndex, pageSize);
        }
    }
}
