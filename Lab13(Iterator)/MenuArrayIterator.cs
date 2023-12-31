﻿using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Iterator_
{
    public class MenuArrayIterator : IIterator<MenuItem>
    {
        private MenuItem[] _items;
        private int _index = 0;
        public MenuArrayIterator(MenuItem[] items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
        }

        public MenuItem Current()
        {
            return _items[_index];
        }
        public bool IsNext()
        {
            return _index < _items.Length;
        }
        public MenuItem Next()
        {
            if (IsNext())
            {
                return _items[_index++];
            }
            else
            {
                throw new InvalidOperationException("Блюд больше нет");
            }
        }
    }
}
