using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface ISkillsBService
    {
        Task<SkillsB> GetSkillBAsync(int id);
        Task<bool> UpdateSkillBAsync(SkillsB skill);
        Task<IEnumerable<SkillsB>> GetAllSkillsBAsync();
        Task<bool> DeleteSkillBAsync(int id); 
        Task<bool> AddSkillBAsync(SkillsB skill);
    }
}
