using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Catalog.DataAccessLayer
{
    public class RepositoryInitializer : CreateDatabaseIfNotExists<RepositoryContext>
    {
        protected override void Seed(RepositoryContext context)
        {
            base.Seed(context);
        }
    }
}