﻿
using DDD.Application.Interfaces.Base;
using DDD.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace DDD.Application.Base
{
	public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
	{
		private readonly IServiceBase<TEntity> _serviceBase;

		public AppServiceBase(IServiceBase<TEntity> serviceBase)
		{
			_serviceBase = serviceBase;
		}

		public void Add(TEntity obj)
		{
			_serviceBase.Add(obj);
		}		

		public IEnumerable<TEntity> GetAll()
		{
			return _serviceBase.GetAll();
		}

		public TEntity GetById(int id)
		{
			return _serviceBase.GetById(id);
		}

		public void Remove(TEntity obj)
		{
			_serviceBase.Remove(obj);
		}

		public void Update(TEntity obj)
		{
			_serviceBase.Update(obj);
		}

		public void Dispose()
		{
			_serviceBase.Dispose();
		}

		public void SetContext(string conn)
		{
			_serviceBase.SetContext(conn);
		}
	}
}
