using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TattooController : Controller
    {
        private readonly ITattooService _tattooService;

        public TattooController(ITattooService tattooService)
        {
            _tattooService = tattooService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var model = new TattooDTO();
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync(TattooDTO tattooDTO)
        {
            var result = await _tattooService.CreateAsync(tattooDTO);
            if (result.IsSuccess)
                return View(result);

            return NotFound(result);
        }

    }
}
