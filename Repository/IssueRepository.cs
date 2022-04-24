using Test_Series.Database;
using Test_Series.Models;

namespace Test_Series.Repository
{
    public class IssueRepository : IIssueRepository
    {
        private readonly AppDbContext _context;

        public IssueRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddIssue(IssueModel issue)
        {
            IssueModel issue1 = new IssueModel()
            {
                //Id = Convert.ToInt32(Guid.NewGuid()),
                Name = issue.Name,
                Email = issue.Email,
                Issue = issue.Issue
            };
            var result = await _context.Queries.AddAsync(issue1);
            await _context.SaveChangesAsync();
            return result.Entity.Id;


        }
    }
}
