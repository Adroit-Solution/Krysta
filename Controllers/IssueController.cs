using Microsoft.AspNetCore.Mvc;
using Test_Series.Models;
using Test_Series.Repository;

namespace Test_Series.Controllers
{
    public class IssueController : Controller
    {
        private readonly IIssueRepository repository;

        public IssueController(IIssueRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IssueModel issueModel)
        {
            var id = await repository.AddIssue(issueModel);
            if (id != Guid.Empty) 
            {
                ModelState.Clear();
            }
            return View();
        }

    }
}
