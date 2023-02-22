using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ImageGallery.Models.Identity;

namespace ImageGallery.Contexts
{
    public class DataContext : IdentityDbContext<GalleryUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
