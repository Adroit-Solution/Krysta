using Test_Series.Models;

namespace Test_Series.Repository
{
    public interface IIssueRepository
    {
        Task<Guid> AddIssue(IssueModel issue);
    }
}