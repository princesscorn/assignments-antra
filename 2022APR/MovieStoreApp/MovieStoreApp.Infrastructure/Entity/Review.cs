﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Entity
{
    public class Review
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public Decimal Rating { get; set; }
        public string ReviewText { get; set; }
    }
}