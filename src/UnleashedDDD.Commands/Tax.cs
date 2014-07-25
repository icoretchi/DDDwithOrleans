﻿using System;

namespace UnleashedDDD.Commands
{
    public class Tax
    {
        public Guid Id { get; private set; }
        public decimal Rate { get; private set; }

        public Tax(Guid id, decimal rate)
        {
            Id = id;
            Rate = rate;
        }
    }
}