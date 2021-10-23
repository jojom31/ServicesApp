using System;
using System.Collections.Generic;
using System.Linq;
using ServicesApp.Core;

namespace ServicesApp.DAL
{
    public class BusinessService
    {

        ServicesDbContext _context;

        public BusinessService()
        {
            _context = new ServicesDbContext();
        }

        public Services GetServicesById (int id)
        {
            return this._context.Service.Where(services => services.ID == id).FirstOrDefault();
        }

        public List<Services> GetAllServices()
        {
            return this._context.Service.ToList();
        }

        public Services AddServices(Services services)
        {
            this._context.Service.Add(services);
            this._context.SaveChanges();
            return services;
        }

        public Services RemoveServices(int id)
        {
            Services services = this.GetServicesById(id);
            if(services != null)
            {
                this._context.Service.Remove(services);
                this._context.SaveChanges();
            }
            return services;
        }

            
    }
}
