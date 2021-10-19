﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Models.Entities
{
    public abstract class EntityBase
    {
        public Guid Id
        {
            get;
            init;
        }

        public string Name
        {
            get;
            set;
        } = null!;
    }
}
