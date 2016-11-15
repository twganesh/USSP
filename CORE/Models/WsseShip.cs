using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("WSSE_SHIP")]
    public class WsseShip
    {
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("WELLSITE")]
        public string WellSite { get; set; }

        [Column("DISTRICT")]
        public string District { get; set; }

        [Column("OPERATOR")]
        public string Operator { get; set; }

        [Column("SHIP_DATE")]
        public DateTime ShipDate { get; set; }

        [Column("TREATMENT")]
        public string Treatment { get; set; }

        [Column("TRUCK_NO")]
        public string TruckNo { get; set; }

        [Column("TRAILER_NO")]
        public string TrailerNo { get; set; }

        [Column("CUSTOMER")]
        public string Customer { get; set; }

        [Column("LOCATION")]
        public string Location { get; set; }

        [Column("WELL")]
        public string Well { get; set; }

        [Column("INSTRUCTIONS")]
        public string Instructions { get; set; }

        [Column("EXEMPT")]
        public string Exempt { get; set; }

        [Column("SAFETY")]
        public string Safety { get; set; }

        [Column("LOAD_DATE")]
        public DateTime LoadDate { get; set; }

        [Column("RETURN_DATE")]
        public DateTime ReturnDate { get; set; }

        [Column("SUPERVISOR")]
        public string Supervisor { get; set; }

        [Column("USERID")]
        public string UserId { get; set; }

        [Column("UPDATE_BY")]
        public string UpdateBy { get; set; }

        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }

        [Column("VERSION")]
        public double Version { get; set; }

        [Column("CREATE_BY")]
        public string CreateBy { get; set; }

        [Column("CREATE_DATE")]
        public DateTime CreateDate { get; set; }

        [Column("LOAD_DIFF")]
        public int LoadDiff { get; set; }

        [Column("TMP_EDIT")]
        public string TmpEdit { get; set; }

        [Column("CERT_SIGN")]
        public string CertSign { get; set; }

        [Column("LOAD_SIGN")]
        public string LoadSign { get; set; }

        [Column("RADIOACTIVE")]
        public bool Radioactive { get; set; }

        [Column("ARCHIVED")]
        public bool Archived { get; set; }

        [Column("COLORADO")]
        public int Colorado { get; set; }

        [Column("SHIPMENT_ID")]
        public string ShipmentId { get; set; }

        [Column("STOP_NUMBER")]
        public string StopNumber { get; set; }

        [Column("ORIGIN")]
        public string Origin { get; set; }

        [Column("DESTINATION")]
        public string Destination { get; set; }

        [Column("NUM_OF_PRODUCTS_TMS")]
        public int NumOfProductsTMS { get; set; }
    }
}
