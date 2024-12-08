using CreateContact.Infrastructure.Repositories.Contact;
using TechChallenge3.Infrastructure.UnitOfWork;

namespace CreateContact.Infrastructure.UnitOfWork
{
    public interface IGetContactUnitOfWork : IBaseUnitOfWork
    {
        IGetContactRepository GetContactRepository { get; }
    }
}
