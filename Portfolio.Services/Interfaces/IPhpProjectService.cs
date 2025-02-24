using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface IPhpProjectService
    {
        Task<PhpProject> GetPhpProjectAsync(int id);
        Task<bool> UpdatePhpProjectAsync(PhpProject project);
        Task<IEnumerable<PhpProject>> GetAllPhpProjectsAsync();
        Task<bool> AddPhpProjectAsync(PhpProject project);
        Task<bool> DeletePhpProjectAsync(int id);
    }
}
