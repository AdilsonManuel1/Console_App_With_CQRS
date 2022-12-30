using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;

namespace Application.Service
{

    public abstract class BaseService
    {
        public readonly DataContext _dataContext;
        protected BaseService(DataContext dataContext) { _dataContext = dataContext; }
    }
}