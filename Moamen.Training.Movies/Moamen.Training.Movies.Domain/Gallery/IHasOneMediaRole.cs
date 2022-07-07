using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Domain.Gallery
{
    public interface IHasOneMediaRole<T, TId> where T : IIdentity<TId>
    {
        public TId RoleId { get; set; }
        public T Role { get; set; }
    }
}
