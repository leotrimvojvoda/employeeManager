using System;
using System.Collections.Generic;
using Emanager01.Models;
namespace Emanager01.Data
{
    public interface CRUD
    {

        void add(Object obj);

        object get(string id);

        void update(string id, object newObject);

        void delete(string id);
    }
}
