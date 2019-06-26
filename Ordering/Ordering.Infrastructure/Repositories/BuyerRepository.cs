using Ordering.Domain.AggregatesModel.BuyerAggregate;
using Ordering.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        private readonly OrderingContext dd;

        public Buyer Add(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindAsync(string BuyerIdentityGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Buyer Update(Buyer buyer)
        {
            throw new NotImplementedException();
        }
    }
}
