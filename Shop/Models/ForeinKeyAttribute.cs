﻿using System;

namespace Shop.Models
{
    internal class ForeinKeyAttribute : Attribute
    {
        private string v;

        public ForeinKeyAttribute(string v)
        {
            this.v = v;
        }
    }
}