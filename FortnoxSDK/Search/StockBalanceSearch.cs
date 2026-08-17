using System;
using System.Collections.Generic;
using System.Text;

namespace Fortnox.SDK.Search
{
    public class StockBalanceSearch : BaseSearch
    {
        //[SearchParameter("sortby")]
        //public Sort.By.Customer? SortBy { get; set; }

        //[SearchParameter("filter")]
        //public Filter.Customer? FilterBy { get; set; }

        [SearchParameter("itemIds")]    
        public string[] ItemIds {  get; set; }
        
        [SearchParameter("stockPointCodes")]
        public string[] StockPointCodes { get; set; }               
    }
}

