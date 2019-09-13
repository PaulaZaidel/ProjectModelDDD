using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectModelDDD.Application.Interface;
using ProjectModelDDD.Domain.Entities;
using ProjectModelDDD.MVC.ViewModels;

namespace ProjectModelDDD.MVC.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientAppService _serviceApp;
        private readonly IMapper _mapper;

        public ClientsController(IClientAppService service, IMapper mapper)
        {
            _serviceApp = service;
            _mapper = mapper;
        }

        // GET: Client
        public ActionResult Index()
        {
            var clients = _serviceApp.GetAll();
            var clientsViewModel = _mapper.Map<IEnumerable<ClientViewModel>>(clients);

            return View(clientsViewModel);
        }

        public ActionResult Especials()
        {
            var clients = _serviceApp.GetEspecialClients();
            var clientsViewModel = _mapper.Map<IEnumerable<ClientViewModel>>(clients);

            return View(clientsViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var client = _serviceApp.GetById(id);
            var clientViewModel = _mapper.Map<ClientViewModel>(client);

            return View(clientViewModel);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = _mapper.Map<Client>(clientViewModel);

                client.Created = DateTime.Now;

                _serviceApp.Add(client);

                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _serviceApp.GetById(id);
            var clientViewModel = _mapper.Map<ClientViewModel>(client);

            return View(clientViewModel);
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = _mapper.Map<Client>(clientViewModel);
                _serviceApp.Update(client);

                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _serviceApp.GetById(id);
            var clientViewModel = _mapper.Map<ClientViewModel>(client);

            return View(clientViewModel);
        }

        // POST: Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = _serviceApp.GetById(id);
            _serviceApp.Remove(client);

            return RedirectToAction("Index");
        }
    }
}