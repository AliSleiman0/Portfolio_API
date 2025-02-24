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
    public class PhpProjectService : IPhpProjectService
    {
        private readonly IPortfolioRepository _repo;

        public PhpProjectService(IPortfolioRepository repo)
        {
            _repo = repo;
        }

        public async Task<PhpProject> GetPhpProjectAsync(int id)
        {
            return await _repo.GetAll<PhpProject>()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> UpdatePhpProjectAsync(PhpProject project)
        {
            var existingProject = await _repo.GetAll<PhpProject>()
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
        public async Task<IEnumerable<PhpProject>> GetAllPhpProjectsAsync()
        {
            return await _repo.GetAll<PhpProject>().ToListAsync();
        }
        public async Task<bool> AddPhpProjectAsync(PhpProject project)
        {
            _repo.Add(project);
            return await _repo.SaveChangesAsync() > 0;
        }

        // Delete a project by ID
        public async Task<bool> DeletePhpProjectAsync(int id)
        {
            var project = await _repo.GetAll<PhpProject>()
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
