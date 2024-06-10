using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _feateureDal;
        public FeatureManager(IFeatureDal feateureDal)
        {
            _feateureDal = feateureDal;
        }
        public void TAdd(Feature entity)
        {
            _feateureDal.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _feateureDal.Delete(entity);
        }

        public Feature TGetByID(int id)
        {
            return _feateureDal.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
            return _feateureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _feateureDal.Update(entity);
        }
    }
}
