using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace YardimMasasi.Sunum.Yetkilendirme
{
    public class YmIdentityDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public YmIdentityDbContext(DbContextOptions<YmIdentityDbContext> options) : base(options)
        {
        }
    }
}
