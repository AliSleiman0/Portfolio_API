using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models;
using Portfolio.Infrastructure.Repository;
using Portfolio.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Services
{
    public class WelcomeService : IWelcomeService
    {
        private readonly IPortfolioRepository _repo;

        public WelcomeService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public async Task<Welcome> GetWelcomeAsync()
        {
            return await _repo.GetAll<Welcome>().FirstOrDefaultAsync();
        }

        public async Task<bool> UpdateWelcomeAsync(Welcome welcome)
        {
            var existingWelcome = await _repo.GetAll<Welcome>()
                .FirstOrDefaultAsync(w => w.Id == welcome.Id);

            if (existingWelcome == null)
            {
                _repo.Add(welcome);
            }
            else
            {
                // Update properties (example only - adjust based on your Welcome model)
                existingWelcome.Title = welcome.Title;
                existingWelcome.ImgSrc = welcome.ImgSrc;
                existingWelcome.Subtitle = welcome.Subtitle;
                existingWelcome.Skills = welcome.Skills;
            }

            return await _repo.SaveChangesAsync() > 0;
        }
        public async Task<IEnumerable<Welcome>> GetAllWelcomesAsync()
        {
            return await _repo.GetAll<Welcome>().ToListAsync();
        }
    }
}
