﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DBHandler
{
   public class PropertyRepository : AbstractRepository<DataContext,Property>
    {
        public PropertyRepository(DataContext dataContext) :  base(dataContext)
        {

        }

        public IQueryable<Property> GetAllWithImages(Expression<Func<Property, bool>> predicate)
        {
            return context.Property.Include("Images").Where(predicate);
        }
    }
}