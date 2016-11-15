using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SLB.USSP.Web.Models
{

    public class GridResultViewModel<T>
    {
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SortDirection { get; set; }
        public string SortBy { get; set; }

        public List<T> Data { get; set; }

    }
    public class ShippingPaperFilterViewModel
    {
        public int? Id { get; set; }
        public int? ShipmentId { get; set; }
        public string ProductCode { get; set; }
        public string CreatedBy { get; set; }
        public string Customer { get; set; }
        public string WellSite { get; set; }
        public string Operator { get; set; }
        public string JobLocation { get; set; }
        public string District { get; set; }
        public string TruckNo { get; set; }
        public string TrailerNo { get; set; }
        public string WellJobName { get; set; }
        public string TreatmentNo { get; set; }
        public bool IsRadioActive { get; set; }
        public string ShipDateFilterType { get; set; }
        public DateTime? ShipDateBetweenFrom { get; set; }
        public DateTime? ShipDateBetweenTo { get; set; }
        public string UpdateDateFilterType { get; set; }
        public DateTime? UpdateDateBetweenFrom { get; set; }
        public DateTime? UpdateDateBetweenTo { get; set; }
        public string CreateDateFilterType { get; set; }
        public DateTime? CreateDateBetweenFrom { get; set; }
        public DateTime? CreateDateBetweenTo { get; set; }
    }

    public class ShippingPaperViewModel
    {
        public int? Id { get; set; }
        public string ShipmentId { get; set; }
        public string StopNo { get; set; }

        public string Origin { get; set; }
        public string Destination { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }

    }


}