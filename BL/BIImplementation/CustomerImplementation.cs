using BLApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BIImplementation
{
    internal class CustomerImplementation : Icustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.ConvertBoClientToDoClient());
            }
            catch (DalIdExistsException ex)
            {
                throw new BLIdExistsException(ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (DalIdNotExistsException ex)

            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }

        }

        public bool IsExist(BO.Customer item)
        {
            try
            {
                _dal.Customer.Read(item.CustomerId);
                return true;
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }

        public BO.Customer? Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id).ConvertDoClientToBoClient();
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(c => filter(c.ConvertDoClientToBoClient())).ConvertDoClientToBoClient();
            }
            catch (DalNotFound ex)
            {
                throw new BLMissingDataException(ex.Message, ex);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Customer.ReadAll().Select(c => c.ConvertDoClientToBoClient()).ToList();
                return _dal.Customer.ReadAll(c => filter(c.ConvertDoClientToBoClient()))
                    .Select(c => c.ConvertDoClientToBoClient()).ToList();
            }
            catch (DalNotFound ex)
            {
                throw new BLMissingDataException(ex.Message, ex);
            }
        }

        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.ConvertBoClientToDoClient());
            }
            catch (DalIdNotExistsException ex)
            {
                throw new (ex.Message, ex);

            }
        }
    }
}
