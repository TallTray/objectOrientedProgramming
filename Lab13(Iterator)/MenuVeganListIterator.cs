﻿using Lab8_Composite_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Iterator_
{
    public class MenuVeganListIterator : IIterator<MenuItem>
    {
        private readonly List<MenuItem> _items;
        private int _index;
        public MenuVeganListIterator(List<MenuItem> items)
        {
            _items = items ?? throw new ArgumentNullException(nameof(items));
            _index = _items.Count - 1;
        }

        public MenuItem Current()
        {
            return _items[_index];
        }
        public bool IsNext()
        {
            return _index < _items.Count;
        }
        public MenuItem Next()
        {
            if (_index != 0)
            {
                if (_items[_index++].IsVegan)
                {
                    return _items[_index];
                }
                else
                {
                    return Next();
                }
            }
            else
            {
                throw new InvalidOperationException("Веганских блюд больше нет");
            }
            
        }
    }
}
