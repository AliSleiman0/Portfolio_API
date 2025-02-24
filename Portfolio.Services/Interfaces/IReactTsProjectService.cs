using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface IReactTsProjectService
    {
        Task<ReactTsProject> GetReactTsProjectAsync(int id);
        Task<bool> UpdateReactTsProjectAsync(ReactTsProject project);
        Task<IEnumerable<ReactTsProject>> GetAllReactTsProjectsAsync();
        Task<bool> AddReactTsProjectAsync(ReactTsProject project);
        Task<bool> DeleteReactTsProjectAsync(int id);
    }
}
