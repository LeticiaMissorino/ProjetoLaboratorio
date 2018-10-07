using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoLaboratorio.Models;

namespace ProjetoLaboratorio.Controllers
{
    public class ModelLaboratoriosController : Controller
    {
        Servico.ServicoClient server = new Servico.ServicoClient();

        // GET: ModelLaboratorios
        public ActionResult Index()
        {
            List<ModelLaboratorio> lstLab = new List<ModelLaboratorio>();

            var lst = server.Listar();

            foreach (var item in lst)
            {

                ModelLaboratorio s = new ModelLaboratorio();
                s = Converte.ToModelLaboratorio(item);
                lstLab.Add(s);
            }

            return View(lstLab);
        }

        // GET: ModelLaboratorios/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: ModelLaboratorios/Create
        [HttpPost]
        public ActionResult Create(ModelLaboratorio lab)
        {
            try
            {
                server.Inserir(Converte.ToLaboratorio(lab));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelLaboratorios/Edit/5
        public ActionResult Edit(int id)
        {
            ModelLaboratorio sm = new ModelLaboratorio();
            sm = Converte.ToModelLaboratorio(server.getById(id));
            return View(sm);
        }

        // POST: ModelLaboratorios/Edit/5
        [HttpPost]
        public ActionResult Edit( ModelLaboratorio modelLaboratorio)
        {
            try
            {
                server.Editar(Converte.ToLaboratorio(modelLaboratorio));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ModelLaboratorios/Delete/5
        public ActionResult Delete(int id)
        {
            server.Excluir(id);
            return RedirectToAction("Index");
        }

        // POST: ModelLaboratorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                server.Excluir(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
