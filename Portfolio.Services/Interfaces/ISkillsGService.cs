using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface ISkillsGService
    {
        Task<SkillsG> GetSkillGAsync(int id);
        Task<bool> UpdateSkillGAsync(SkillsG skill);
        Task<IEnumerable<SkillsG>> GetAllSkillsGAsync();
        Task<bool> DeleteSkillGAsync(int id);
        Task<bool> AddSkillGAsync(SkillsG skill);
    }
}
