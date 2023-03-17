using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManaged.Business.Abstract;
using ProductManaged.DataAccess.Abstract;
using ProductManaged.Entities.Concrete;

namespace ProductManaged.Business.Concrete
{
    public class JobManager : IJobService
    {
        private IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }

        public void TAdd(Job entity)
        {
            _jobDal.Add(entity);
        }

        public void TUpdate(Job entity)
        {
            _jobDal.Update(entity);
        }

        public void TDelete(Job entity)
        {
            _jobDal.Delete(entity);
        }

        public List<Job> TGetList()
        {
            return _jobDal.GetAll();
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetAll().Where(j => j.JobId == id).SingleOrDefault();
        }
    }
}
