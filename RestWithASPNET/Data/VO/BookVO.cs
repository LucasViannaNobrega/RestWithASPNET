using RestWithASPNET.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNET.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Author { get; set; }
        public DateTime LauchDate { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}
