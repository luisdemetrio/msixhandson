using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerList.Repository
{
    public class SqlContosoRepository : IContosoRepository
    {
        private readonly DbContextOptions<ContosoContext> _dbOptions;

        public SqlContosoRepository(DbContextOptionsBuilder<ContosoContext>
            dbOptionsBuilder)
        {
            _dbOptions = dbOptionsBuilder.Options;
            using (var db = new ContosoContext(_dbOptions))
            {
                db.Database.EnsureCreated();
            }
        }

        public ICustomerRepository Customers => new SqlCustomerRepository(
            new ContosoContext(_dbOptions));

        public IOrderRepository Orders => new SqlOrderRepository(
            new ContosoContext(_dbOptions));

        public IProductRepository Products => new SqlProductRepository(
            new ContosoContext(_dbOptions));
    }

}
