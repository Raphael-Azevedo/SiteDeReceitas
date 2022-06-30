using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_mvc.Context;
using desafio_mvc.Repository.Interfaces;

namespace desafio_mvc.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private CategoriaRepository _categoriaRepo;
        private MedidaRepository _medidaRepo;
        private IngredienteRepository _ingredienteRepo;
        private ReceitaRepository _receitaRepo;
        private ReceitaIngredienteRepository _receitaIngredienteRepo;
        private LogginRepository _logginRepo;
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepo = _categoriaRepo ?? new CategoriaRepository(_context);
            }
        }
        public IMedidaRepository MedidaRepository
        {
            get
            {
                return _medidaRepo = _medidaRepo ?? new MedidaRepository(_context);
            }
        }
        public IIngredienteRepository IngredienteRepository
        {
            get
            {
                return _ingredienteRepo = _ingredienteRepo ?? new IngredienteRepository(_context);
            }
        }
        public IReceitaRepository ReceitaRepository
        {
            get
            {
                return _receitaRepo = _receitaRepo ?? new ReceitaRepository(_context);
            }
        }
        public IReceitaIngredienteRepository ReceitaIngredienteRepository
        {
            get
            {
                return _receitaIngredienteRepo = _receitaIngredienteRepo ?? new ReceitaIngredienteRepository(_context);
            }
        }
        public ILogginRepository LogginRepository
        {
            get
            {
                return _logginRepo = _logginRepo ?? new LogginRepository(_context);
            }
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}