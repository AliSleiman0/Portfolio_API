using System.Threading.Tasks;
using Portfolio.Domain.Models;

namespace Portfolio.Domain.Services
{
	public interface IAboutService
	{
		/// <summary>
		/// Retrieves the About record. Assumes that there is only one About record.
		/// </summary>
		/// <returns>The About record, or null if not found.</returns>
		Task<About> GetAboutAsync(int id);

		/// <summary>
		/// Updates an existing About record or adds it if it doesn’t exist.
		/// </summary>
		/// <param name="about">The About model with updated values.</param>
		/// <returns>A boolean indicating whether the operation succeeded.</returns>
		Task<bool> UpdateAboutAsync(About about);
		Task<IEnumerable<About>> GetAllAboutAsync();

    }
}
