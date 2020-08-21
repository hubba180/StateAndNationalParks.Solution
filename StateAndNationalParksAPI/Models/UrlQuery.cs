using System.ComponentModel.DataAnnotations;

namespace StateAndNationalParksAPI.Models
{ 
    public class UrlQuery
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public UrlQuery()
        {
            this.PageNumber = 1;
            this.PageSize = 25;
        }

        public UrlQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 25 ? 25 : pageSize;
        }
    }
}