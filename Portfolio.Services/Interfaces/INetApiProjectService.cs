using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface INetApiProjectService
    {
        Task<NetApiProject> GetNetApiProjectAsync(int id);
        Task<bool> UpdateNetApiProjectAsync(NetApiProject project);
        Task<IEnumerable<NetApiProject>> GetAllNetApiProjectAsync();
        Task<bool> AddNetApiProjectAsync(NetApiProject project);
        Task<bool> DeleteNetApiProjectAsync(int id);
    }
}
