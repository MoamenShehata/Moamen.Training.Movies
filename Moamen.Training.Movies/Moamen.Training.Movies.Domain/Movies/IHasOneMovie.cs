using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Domain.Movies
{
    public interface IHasOneMovie<T, TId> where T : IIdentity<TId>
    {
        public TId MovieId { get; set; }
        public T Movie { get; set; }
    }
}
