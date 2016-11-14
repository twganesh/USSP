using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.DTO
{
    public class DTOTProdData
    {
        public string FProduct { get; set; }

        public string FDataCode { get; set; }

        public string FData { get; set; }

        public DateTime FDateForDateTypes { get; set; }

        public string FUserUpdated { get; set; }

        public DateTime FDateStamp { get; set; }
    }
}
