using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Models
{
    public class PageModel
    {
        public int CurrentPageNo { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        //public long Count { get; set; }
        public bool HasPreviousPage => CurrentPageNo > 1;
        public bool HasNextPage => CurrentPageNo < TotalPages;
        
        //public IEnumerable<T> Data { get; set; }

        public int TotalItems { get; set; }
        
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public PageModel()
        {

        }

        public PageModel(int totalItems, int curPage, int pageSize = 30)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            int currentPage = curPage;
            int startPage = currentPage - 5;
            int endPage = currentPage + 4;

            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }
            TotalItems = totalItems;
            CurrentPageNo = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }
    }
}
