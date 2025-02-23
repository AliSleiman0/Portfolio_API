using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using ClothingStore.Infrastructure.Context;  // Adjust this namespace if needed

namespace Portfolio.Domain.Services
{
    public class AboutService : IAboutService
    {
        private readonly PortfolioDbContext _context;

        public AboutService(PortfolioDbContext context)
        {
            _context = context;
        }

        public async Task<About> GetAboutAsync()
        {
            // If you expect only one About record, this returns the first one (or null)
            return await _context.Abouts.FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAboutAsync(About about)
        {
            // Try to find an existing About record by its primary key
            var existingAbout = await _context.Abouts.FindAsync(about.Id);

            if (existingAbout == null)
            {
                // Record doesn't exist; add it as new
                _context.Abouts.Add(about);
            }
            else
            {
                // Update existing record's fields
                existingAbout.FirstP = about.FirstP;
                existingAbout.SecondP = about.SecondP;
                existingAbout.ThirdP = about.ThirdP;
                existingAbout.FourthP = about.FourthP;
            }

            // Save changes and return true if at least one record was modified/added
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }
    }
}
