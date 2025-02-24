using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Infrastructure.Repository;


namespace Portfolio.Domain.Services
{
    public class AboutService : IAboutService
    {
        private readonly IPortfolioRepository _repo;

        public AboutService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public async Task<About> GetAboutAsync(int id)
        {
            
            return await _repo.GetAll<About>().Where(abt => abt.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateAboutAsync(About about)
        {
            // Try to find an existing About record by its primary key
            var existingAbout = await _repo.GetAll<About>()
                .Where(abt => abt.Id == about.Id)
                .FirstOrDefaultAsync();

            if (existingAbout == null)
            {
                // Record doesn't exist; add it as new
                _repo.Add(about);
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
            var result = await _repo.SaveChangesAsync();
            return result > 0;
        }
        public async Task<IEnumerable<About>> GetAllAboutAsync()
        {
            return await _repo.GetAll<About>().ToListAsync();
        }
    }
}
