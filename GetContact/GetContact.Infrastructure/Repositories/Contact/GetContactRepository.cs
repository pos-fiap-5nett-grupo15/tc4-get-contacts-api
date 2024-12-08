using Dapper;
using TechChallenge3.Domain.Entities.Contact;
using TechChallenge3.Infrastructure.UnitOfWork;

namespace CreateContact.Infrastructure.Repositories.Contact
{
    public class GetContactRepository : IGetContactRepository
    {
        private readonly ITechDatabase _database;
        private const string TABLE_NAME = "Contact";
        private const string SCHEMA = "ContactsManagement";

        public GetContactRepository(ITechDatabase database) =>
            _database = database ?? throw new ArgumentNullException(nameof(database));

        public async Task<ContactEntity?> GetByIdAsync(int id) =>
            await _database.Connection.QueryFirstOrDefaultAsync<ContactEntity>(
                $"SELECT * FROM [{SCHEMA}].[{TABLE_NAME}] WHERE {nameof(ContactEntity.Id)} = {id};");




        public async Task<IEnumerable<ContactEntity>> GetListPaginatedByFiltersAsync(int? ddd, int currentIndex, int pageSize) =>
            await _database.Connection.QueryAsync<ContactEntity>(
                $@"SELECT * FROM [{SCHEMA}].[{TABLE_NAME}]
                   {(!ddd.HasValue
                        ? string.Empty
                        : $"WHERE {nameof(ContactEntity.Ddd)} = {ddd}")}
                   ORDER BY {nameof(ContactEntity.Id)} ASC
                   OFFSET {currentIndex} ROWS FETCH FIRST {pageSize} ROWS ONLY;");
    }
}
