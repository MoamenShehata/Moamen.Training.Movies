using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Application.Common
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
    }
}
