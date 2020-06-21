using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DBHandler;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RealEstate
{
    public class PropertyController : BaseController<Property, PropertyRepository>
    {
        private readonly PropertyRepository _propertyRepository;
        public PropertyController(PropertyRepository propertyRepository) : base(propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }

        [HttpGet("GetAllWithImages/{typeId:int}/{cityId:int}/{prize:decimal}/{pageNumber:int}/{pageSize:int}/{sortField}/{sortOrder}")]
        public async Task<IPageResult<Property>> GetAllWithImages(int typeId, int cityId,decimal prize,int pageNumber, int pageSize, string sortField, string sortOrder)
        {
            Expression<Func<Property, bool>> predicate = x => (typeId > -1 ? x.TypeId == typeId : true) &&( cityId > 0 ? x.Address.CityId == cityId : true) && (x.Prize <= prize);
            return await CreatePageResult<Property>(_propertyRepository.GetAllWithImages(predicate).OrderBy(sortField + " " + sortOrder), pageNumber, pageSize, false);
        }
    }
}