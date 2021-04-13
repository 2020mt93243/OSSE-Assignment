using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSE_Assignment.Models
{
    public interface IBooksDataSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

    }
}
