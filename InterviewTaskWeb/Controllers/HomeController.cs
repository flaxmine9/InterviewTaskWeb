using InterviewTaskWeb.DataBase.Services;
using InterviewTaskWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTaskWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyService _companyService;

        public HomeController(CompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _companyService.GetAllCompaniesAsync();

            var model = new CompanyViewModel
            {
                Companies = [.. companies]
            };

            return View(model);
        }
    }
}