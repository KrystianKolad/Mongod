using System.Collections.Generic;
using Mongod.Infrastructure.Models;

namespace Mongod.Infrastructure.ViewModels
{
    public class PageViewModel<T> where T : BaseModel
    {
        public IList<T> Items { get; set; }
        public int PageNumber { get; set; }
        public int MaxPageItemsCount { get; set; }
        public bool NexPageAvailable { get; set; }
    }
}