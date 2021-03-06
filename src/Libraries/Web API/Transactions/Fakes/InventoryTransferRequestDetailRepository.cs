// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using MixERP.Net.Schemas.Transactions.Data;
using MixERP.Net.EntityParser;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Transactions.Fakes
{
    public class InventoryTransferRequestDetailRepository : IInventoryTransferRequestDetailRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetAll()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public IEnumerable<dynamic> Export()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail Get(long inventoryTransferRequestDetailId)
        {
            return new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> Get([FromUri] long[] inventoryTransferRequestDetailIds)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public IEnumerable<MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Transactions.InventoryTransferRequestDetail(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields()
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public IEnumerable<PetaPoco.CustomField> GetCustomFields(string resourceId)
        {
            return Enumerable.Repeat(new CustomField(), 1);
        }

        public object AddOrEdit(dynamic inventoryTransferRequestDetail, List<EntityParser.CustomField> customFields)
        {
            return true;
        }

        public void Update(dynamic inventoryTransferRequestDetail, long inventoryTransferRequestDetailId)
        {
            if (inventoryTransferRequestDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferRequestDetailId is null.");
        }

        public object Add(dynamic inventoryTransferRequestDetail)
        {
            return true;
        }

        public List<object> BulkImport(List<ExpandoObject> inventoryTransferRequestDetails)
        {
            return Enumerable.Repeat(new object(), 1).ToList();
        }

        public void Delete(long inventoryTransferRequestDetailId)
        {
            if (inventoryTransferRequestDetailId > 0)
            {
                return;
            }

            throw new ArgumentException("inventoryTransferRequestDetailId is null.");
        }


    }
}