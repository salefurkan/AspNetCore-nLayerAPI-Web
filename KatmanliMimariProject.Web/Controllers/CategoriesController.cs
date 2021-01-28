using AutoMapper;
using KatmanliMimariProject.Web.ApiService;
using KatmanliMimariProject.Web.DTOs;
using KatmanliMimariProject.Web.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        private readonly IMapper _mapper;
        public CategoriesController(IMapper mapper, CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var category = await _categoryApiService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<CategoryDto>>(category));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            await _categoryApiService.AddAsync(categoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryApiService.GetByIdAsync(id);
            return View(_mapper.Map<CategoryDto>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _categoryApiService.Update(categoryDto);
            return RedirectToAction("Index");
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        public async Task<IActionResult> Delete(int id)
        {
            
            await _categoryApiService.Remove(id);
            return RedirectToAction("Index");
        }

    }
}
