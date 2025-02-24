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
    public class SocialService : ISocialService
    {
        private readonly IPortfolioRepository _repo;

        public SocialService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public async Task<Social> GetSocialAsync(int id)
        {
            return await _repo.GetAll<Social>()
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> UpdateSocialAsync(Social social)
        {
            var existingSocial = await _repo.GetAll<Social>()
                .FirstOrDefaultAsync(s => s.Id == social.Id);

            if (existingSocial == null)
            {
                _repo.Add(social);
            }
            else
            {
                
                existingSocial.LinkedinUrl = social.LinkedinUrl;
                existingSocial.GithubUrl = social.GithubUrl;
                existingSocial.InstaUrl = social.InstaUrl;
            }

            return await _repo.SaveChangesAsync() > 0;
        }
        public async Task<IEnumerable<Social>> GetAllSocialsAsync()
        {
            return await _repo.GetAll<Social>().ToListAsync();
        }
    }
}
