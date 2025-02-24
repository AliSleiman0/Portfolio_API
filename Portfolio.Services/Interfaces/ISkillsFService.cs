using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface ISkillsFService
    {
        Task<SkillsF> GetSkillFAsync(int id);
        Task<bool> UpdateSkillFAsync(SkillsF skill);
        Task<IEnumerable<SkillsF>> GetAllSkillsFAsync();
        Task<bool> DeleteSkillFAsync(int id);
        Task<bool> AddSkillFAsync(SkillsF skill);
    }
}
