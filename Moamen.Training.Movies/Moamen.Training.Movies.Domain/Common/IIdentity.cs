using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Domain.Common
{
    public interface IIdentity<TId>
    {
        TId Id { get; }
    }
}
