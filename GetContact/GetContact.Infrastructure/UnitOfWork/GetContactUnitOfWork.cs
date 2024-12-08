
using CreateContact.Infrastructure.Repositories.Contact;
using TechChallenge3.Infrastructure.UnitOfWork;

namespace CreateContact.Infrastructure.UnitOfWork
{
    public sealed class GetContactUnitOfWork : BaseUnitOfWork, IGetContactUnitOfWork
    {
        private readonly ITechDatabase _techDabase;

        public IGetContactRepository GetContactRepository { get; }

        public GetContactUnitOfWork(ITechDatabase database)
            : base(database)
        {
            this._techDabase = database ?? throw new ArgumentNullException(nameof(database));

            this.GetContactRepository = new GetContactRepository(this._techDabase);
        }
    }
}
