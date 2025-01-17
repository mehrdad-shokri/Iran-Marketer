﻿using Pikad.Framework.Repository;
using IranMarketer.SharedData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pikad.Framework.UnitOfWork;

namespace IranMarketer.SharedData.Dao
{
    public class AttachmentCategoryRepository : Repository<Domain.Entity.AttachmentCategory, int>, IAttachmentCategoryRepository
    {
        public AttachmentCategoryRepository(IDbFactory factory) : base(factory)
        {
        }
    }
}
