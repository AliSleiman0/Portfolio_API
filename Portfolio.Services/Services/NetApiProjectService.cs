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
    public class NetApiProjectService : INetApiProjectService
    {
        private readonly IPortfolioRepository _repo;

        public NetApiProjectService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public async Task<NetApiProject> GetNetApiProjectAsync(int id)
        {
            return await _repo.GetAll<NetApiProject>()
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<NetApiProject>> GetAllNetApiProjectAsync()
        {
            return await _repo.GetAll<NetApiProject>()
                .ToListAsync();
        }

        public async Task<bool> UpdateNetApiProjectAsync(NetApiProject project)
        {
            var existingProject = await _repo.GetAll<NetApiProject>()
                .FirstOrDefaultAsync(p => p.Id == project.Id);

            if (existingProject == null)
            {
                _repo.Add(project);
            }
            else
            {
                existingProject.Title = project.Title;
                existingProject.Description = project.Description;
                existingProject.TechUsed = project.TechUsed; // Added
                existingProject.GithubUrl = project.GithubUrl; // Fixed casing (not GitHubUrl)
                existingProject.LiveDemoUrl = project.LiveDemoUrl; // AddedS
                existingProject.ImgSrc = project.ImgSrc;
            }

            return await _repo.SaveChangesAsync() > 0;
        }
        // Add a new project
        public async Task<bool> AddNetApiProjectAsync(NetApiProject project)
        {
            _repo.Add(project);
            return await _repo.SaveChangesAsync() > 0;
        }

      
      
        // Delete a project by ID
        public async Task<bool> DeleteNetApiProjectAsync(int id)
        {
            var project = await _repo.GetAll<NetApiProject>()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (project == null)
            {
                return false; // Project not found
            }

            _repo.Remove(project);
            return await _repo.SaveChangesAsync() > 0;
        }
    }
}
