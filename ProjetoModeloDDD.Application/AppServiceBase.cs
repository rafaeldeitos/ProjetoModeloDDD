using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IAppServiceBase<TEntity> _serviceBase;
        private IClienteService clienteService;
        private IProdutoService produtoService;

        public AppServiceBase(IAppServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public AppServiceBase(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        public AppServiceBase(IProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
