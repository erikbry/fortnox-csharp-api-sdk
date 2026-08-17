using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fortnox.SDK.Search
{
    public class StockPointSearch : BaseSearch
    {
        //[SearchParameter("sortby")]
        //public Sort.By.Customer? SortBy { get; set; }

        //[SearchParameter("filter")]
        //public Filter.Customer? FilterBy { get; set; }

        [SearchParameter("q")]    
        public string CodeOrName {  get; set; }

        [SearchParameter("state")]
        public StockPointState State { get; set; } = StockPointState.Active;
    }
}

