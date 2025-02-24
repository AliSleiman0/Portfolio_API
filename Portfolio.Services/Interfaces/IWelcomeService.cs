using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Services.Interfaces
{
    public interface IWelcomeService
    {
        Task<Welcome> GetWelcomeAsync();
        Task<bool> UpdateWelcomeAsync(Welcome welcome);
        Task<IEnumerable<Welcome>> GetAllWelcomesAsync();
    }
}
