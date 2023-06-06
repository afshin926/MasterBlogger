using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domin.ArticleCategoryAgg.Exceptions
{
    internal class DuplicatedRecordException : Exception
    {
        public DuplicatedRecordException(string message):base(message) 
        { 

        }
    }
}
