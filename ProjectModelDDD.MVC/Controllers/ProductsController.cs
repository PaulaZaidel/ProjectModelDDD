using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectModelDDD.Application.Interface;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.MVC.ViewModels;

namespace ProjectModelDDD.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductAppService _productApp;
        private readonly IClientAppService _clientApp;
        private readonly IMapper _mapper;

        public ProductsController(IProductAppService productApp, IClientAppService clientApp, IMapper mapper)
        {
            _productApp = productApp;
            _clientApp = clientApp;
            _mapper = mapper;
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _productApp.GetAll();
            var productViewModel = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return View(productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productApp.GetById(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            return View(productViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "FirstName");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productViewModel);

                _productApp.Add(product);

                return RedirectToAction("Index");
            }

            return View(productViewModel);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ClientId = new SelectList(_clientApp.GetAll(), "Id", "FirstName");
            var product = _productApp.GetById(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            return View(productViewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<Product>(productViewModel);
                _productApp.Update(product);

                return RedirectToAction("Index");
            }

            return View(productViewModel);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _productApp.GetById(id);
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            return View(productViewModel);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = _productApp.GetById(id);
            _productApp.Remove(product);

            return RedirectToAction("Index");
        }
    }
}