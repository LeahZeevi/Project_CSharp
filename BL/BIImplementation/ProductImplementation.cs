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
    internal class ProductImplementation : Iproducts
    {

        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                int id = _dal.Product.Create(item.ConvertBoProductToDoProduct());
                return id;
            }
            catch (DalIdExistsException ex)
            {
                throw new BLIdExistsException(ex.Message);
            }

        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (Dalfailed ex)
            {
                throw new BlIdNotExistsException(ex.Message);
            }
        }

        
        public void GetAllProductInSale(ProductInOrder product, bool IsFavorite)
        {
          
        }

        public BO.Product? Read(int id)
        {
            try
            {
                return _dal.Product.Read(id).ConvertDoProductToBoProduct();
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(p => filter(p.ConvertDoProductToBoProduct())).ConvertDoProductToBoProduct();
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BLMissingDataException(ex.Message);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                    return _dal.Product.ReadAll().Select(p => p.ConvertDoProductToBoProduct()).ToList();
                return _dal.Product.ReadAll(p => filter(p.ConvertDoProductToBoProduct()))
                    .Select(p => p.ConvertDoProductToBoProduct()).ToList();
            }
            catch (DalNotFound ex)
            {
                throw new BLMissingDataException(ex.Message);
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ConvertBoProductToDoProduct());
            }
            catch (DalIdNotExistsException ex)
            {
                throw new BlIdNotExistsException(ex.Message);
            }
        }
    }
}
