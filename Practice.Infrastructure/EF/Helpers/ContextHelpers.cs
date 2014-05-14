﻿using Practice.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Infrastructure.EF.Helpers
{
    public class ContextHelpers
    {
        public static void ApplyStateChanges(this DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<IObjectWithState>())
            {
                IObjectWithState stateInfo = entry.Entity;
                entry.State = StateHelpers.ConvertState(stateInfo.State);
            }
        }
    }
}
