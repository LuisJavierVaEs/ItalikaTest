using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ItalikaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace ItalikaMVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public async Task<ActionResult> Index(string search,string Eleccion)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:59690/api/producto");
            List<producto> lstProducto = JsonConvert.DeserializeObject<List<producto>>(json);
            switch (Eleccion)
            {
                case "SKU":
                    return View(lstProducto.Where(x => x.Sku == search).ToList());
                case "Modelo":
                    return View(lstProducto.Where(x => x.Modelo == search || search == null).ToList());
                //TODOS
                default:
                    return View(lstProducto);
            }
        }

        // GET: Producto/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"http://localhost:59690/api/producto/{id}");
            producto pr = JsonConvert.DeserializeObject<producto>(json);
            var idTipo = pr.IdTipo;
            var json1 = await httpClient.GetStringAsync($"http://localhost:59690/api/tipo/{idTipo}");
            tipo tip = JsonConvert.DeserializeObject<tipo>(json1);
            ViewBag.IdTipo = tip.Nombre;
            return View(pr);
        }

        // GET: Producto/Create
        public async Task<ActionResult> Create()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:59690/api/tipo");
            List<tipo> lstTipo = JsonConvert.DeserializeObject<List<tipo>>(json);
            List<SelectListItem> lstTi = lstTipo.ConvertAll(d =>
            {
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),

                    Selected = false
                };
            });
            ViewBag.IdTipo = lstTi;
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(producto collection)
        {
            try
            {
                var prod = JsonConvert.SerializeObject(collection);
                var buffer = System.Text.Encoding.UTF8.GetBytes(prod);
                var bytecontent = new ByteArrayContent(buffer);
                bytecontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var httpClient = new HttpClient();
                var result =  httpClient.PostAsync("http://localhost:59690/api/producto",bytecontent).Result;
                // TODO: Add insert logic here
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"http://localhost:59690/api/producto/{id}");
            producto prod = JsonConvert.DeserializeObject<producto>(json);
            var idTipo = prod.IdTipo;
            var json1 = await httpClient.GetStringAsync("http://localhost:59690/api/tipo");
            List<tipo> lstTipo = JsonConvert.DeserializeObject<List<tipo>>(json1);
            List<SelectListItem> lstTi = lstTipo.ConvertAll(d =>
            {
                if (d.Id==idTipo)
                {
                    return new SelectListItem()
                    {
                        Text = d.Nombre.ToString(),
                        Value = d.Id.ToString(),

                        Selected = true
                    };
                }
                return new SelectListItem()
                {
                    Text = d.Nombre.ToString(),
                    Value = d.Id.ToString(),

                    Selected = false
                };
            });
            ViewBag.IdTipo = lstTi;
            //prod.Fecha = Convert.ToDateTime(prod.Fecha).ToShortDateString();
            string fecha="";
            prod.Fecha = Convert.ToDateTime(prod.Fecha).ToShortDateString();
            for (int i = 9; i >= 0; i--)
            {
                if (i == 6)
                {
                    fecha = prod.Fecha.Substring(i,4) + "-";
                }
                else if (i == 3)
                {
                    fecha = fecha + prod.Fecha.Substring(i,2) + "-";
                }
                else if (i ==0)
                {
                    fecha = fecha + prod.Fecha.Substring(i, 2);
                }
            }

            prod.Fecha = fecha;
            return View(prod);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, producto collection)
        {
            try
            {
                var prod = JsonConvert.SerializeObject(collection);
                var buffer = System.Text.Encoding.UTF8.GetBytes(prod);
                var bytecontent = new ByteArrayContent(buffer);
                bytecontent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var httpClient = new HttpClient();
                var result = httpClient.PutAsync($"http://localhost:59690/api/producto/{id}", bytecontent).Result;
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync($"http://localhost:59690/api/producto/{id}");
            producto pr = JsonConvert.DeserializeObject<producto>(json);

            var idTipo = pr.IdTipo;
            var json1 = await httpClient.GetStringAsync($"http://localhost:59690/api/tipo/{idTipo}");
            tipo tip = JsonConvert.DeserializeObject<tipo>(json1);
            ViewBag.IdTipo = tip.Nombre;


            return View(pr);
        }

        // POST: Producto/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, producto collection)
        {
            try
            {
                // TODO: Add delete logic here
                var httpClient = new HttpClient();
                var json = await httpClient.DeleteAsync($"http://localhost:59690/api/producto/{id}");


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}