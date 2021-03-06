using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Dao;
using Core.Entities.Entidade;
using Microsoft.AspNetCore.Authorization;

namespace Core.Ui.Controllers
{
    public class PessoaEntidadesController : Controller
    {
        private readonly Contexto _context;

        public PessoaEntidadesController(Contexto context)
        {
            _context = context;
        }

        // GET: PessoaEntidades
      
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaEntidade = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoaEntidade == null)
            {
                return NotFound();
            }

            return View(pessoaEntidade);
        }

        // GET: PessoaEntidades/Create
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cpf,Email,UserName,Senha,Id")] PessoaEntidade pessoaEntidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoaEntidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoaEntidade);
        }

        // GET: PessoaEntidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaEntidade = await _context.Pessoas.FindAsync(id);
            if (pessoaEntidade == null)
            {
                return NotFound();
            }
            return View(pessoaEntidade);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Cpf,Email,UserName,Senha,Id,Status,Dt_Criacao")] PessoaEntidade pessoaEntidade)
        {
            if (id != pessoaEntidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoaEntidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaEntidadeExists(pessoaEntidade.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pessoaEntidade);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaEntidade = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pessoaEntidade == null)
            {
                return NotFound();
            }

            return View(pessoaEntidade);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoaEntidade = await _context.Pessoas.FindAsync(id);
            _context.Pessoas.Remove(pessoaEntidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaEntidadeExists(int id)
        {
            return _context.Pessoas.Any(e => e.Id == id);
        }
    }
}
