using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerce.Core.Entities.User;
using ECommerce.Core.Interfaces.User;

namespace ECommerce.Dal.Repositories.User
{
    public class ContactUsRepository : IContactUsRepository<ContactUsEf>
    {
        private readonly StoreContext _context;

        public ContactUsRepository(StoreContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<ContactUsEf>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ContactUsEf> GetByIdAsync(uint id)
        {
            throw new System.NotImplementedException();
        }

        public Task AddAsync(ContactUsEf entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ContactUsEf entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteByIdAsync(uint id)
        {
            throw new System.NotImplementedException();
        }
    }
}