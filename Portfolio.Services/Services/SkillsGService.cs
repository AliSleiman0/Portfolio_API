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
    public class SkillsGService : ISkillsGService
    {
        private readonly IPortfolioRepository _repo;

        public SkillsGService(IPortfolioRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<SkillsG>> GetAllSkillsGAsync()
        {
            return await _repo.GetAll<SkillsG>().ToListAsync();
        }
        public async Task<SkillsG> GetSkillGAsync(int id)
        {
            return await _repo.GetAll<SkillsG>()
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> UpdateSkillGAsync(SkillsG skill)
        {
            var existingSkill = await _repo.GetAll<SkillsG>()
                .FirstOrDefaultAsync(s => s.Id == skill.Id);

            if (existingSkill == null)
            {
                _repo.Add(skill);
            }
            else
            {

                existingSkill.SkillName = skill.SkillName;

            }

            return await _repo.SaveChangesAsync() > 0;
        }
        // Add a new SkillsB
        public async Task<bool> AddSkillGAsync(SkillsG skill)
        {
            _repo.Add(skill);
            return await _repo.SaveChangesAsync() > 0;
        }



        // Delete a SkillsB by ID
        public async Task<bool> DeleteSkillGAsync(int id)
        {
            var skill = await _repo.GetAll<SkillsG>()
                .FirstOrDefaultAsync(s => s.Id == id);

            if (skill == null)
            {
                return false; // Skill not found
            }

            _repo.Remove(skill);
            return await _repo.SaveChangesAsync() > 0;
        }
    }
}
