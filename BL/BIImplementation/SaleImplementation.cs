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
    internal class SaleImplementation : Isale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                try//Check if this product exists and can be sold.
                {
                    DO.Product product = _dal.Product.Read(item.ProductId);
                }
                catch (DalIdNotExistsException ex)
                {
                    throw new BlIdNotExistsException(ex.Message, ex);
                }
         
                int id = _dal.Sale.Create(item.ConvertBoSaleToDoSale());
                return id;
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
                _dal.Sale.Delete(id);
            }
            catch (DalIdNotExistsException ex)

            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }

        public BO.Sale? Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id).ConvertDoSaleToBoSale();
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(s => filter(s.ConvertDoSaleToBoSale())).ConvertDoSaleToBoSale();
            }
            catch (DalNotFound ex)
            {
                throw new BLMissingDataException(ex.Message, ex);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Sale.ReadAll().Select(s => s.ConvertDoSaleToBoSale()).ToList();
                return _dal.Sale.ReadAll(s => filter(s.ConvertDoSaleToBoSale()))
                    .Select(s => s.ConvertDoSaleToBoSale()).ToList();
            }
            catch (DalNotFound ex) { throw new BLMissingDataException(ex.Message, ex); }
        }

        public void Update(BO.Sale item)
        {
            try
            {
                try//Check if this product exists and can be sold.
                {
                    DO.Product product = _dal.Product.Read(item.ProductId);
                }
                catch (DalIdNotExistsException ex)
                {
                    throw new BlIdNotExistsException(ex.Message, ex);
                }
                _dal.Sale.Update(item.ConvertBoSaleToDoSale());
            }
            catch (DalIdExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message, ex);
            }
        }
    }
}
