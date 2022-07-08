using Moamen.Training.Movies.Domain.Common;

namespace Moamen.Training.Movies.Domain.Gallery
{
    public class MediaRole : IIdentity<int>
    {
        public int Id { get; set; }
        public MediaRoleType Role { get; set; }

    }
}
