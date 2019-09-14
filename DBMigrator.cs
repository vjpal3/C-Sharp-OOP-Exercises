using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercises.Composition;

namespace Exercises.Composition
{
    class DBMigrator
    {
        private readonly Logger logger;

        public DBMigrator(Logger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.Log("Migrating database...");
        }
    }
}
