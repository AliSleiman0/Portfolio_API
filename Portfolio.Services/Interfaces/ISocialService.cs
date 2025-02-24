using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface ISocialService
    {
        Task<Social> GetSocialAsync(int id);
        Task<bool> UpdateSocialAsync(Social social);
        Task<IEnumerable<Social>> GetAllSocialsAsync();
    }
}
