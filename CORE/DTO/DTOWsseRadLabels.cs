using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseRadLabels
    {        
        public int Id { get; set; }

        public string ModelDesc { get; set; }

        public string Label { get; set; }

        public string HazType { get; set; }

        public string ImageName { get; set; }
    }
}
