using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public ICultureDAL cultureDAL { get; set; }

        private Adventureworks2016Context _adventureworks2016Context;

        public UnidadDeTrabajo(Adventureworks2016Context adventureworks2016Context, ICultureDAL cultureDAL) 
        {
                this._adventureworks2016Context = adventureworks2016Context;
                this.cultureDAL = cultureDAL;
        }
       

        public bool Complete()
        {
            try
            {
                _adventureworks2016Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            this._adventureworks2016Context.Dispose();
        }
    }
}
