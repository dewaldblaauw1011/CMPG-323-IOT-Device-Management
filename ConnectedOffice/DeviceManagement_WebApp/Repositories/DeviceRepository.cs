using DeviceManagement_WebApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DeviceManagement_WebApp.Models;
using System.Linq.Expressions;


    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public void Add(Device entity)
        {
            _context.Set<Device>().Add(entity);
        }
        public void AddRange(IEnumerable<Device> entities)
        {
            _context.Set<Device>().AddRange(entities);
        }
        public IEnumerable<Device> Find(Expression<Func<Device, bool>> expression)
        {
            return _context.Set<Device>().Where(expression);
        }
        public IEnumerable<Device> GetAll()
        {
            return _context.Set<Device>().ToList();
        }
        public Device GetById(int id)
        {
            return _context.Set<Device>().Find(id);
        }
        public void Remove(Device entity)
        {
            _context.Set<Device>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<Device> entities)
        {
            _context.Set<Device>().RemoveRange(entities);
        }
    }





