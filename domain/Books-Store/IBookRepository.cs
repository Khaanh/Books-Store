﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Store
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
