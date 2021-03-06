using System;
using Falcon.Numerics;
using MAVN.Service.PartnersIntegration.Domain.Enums;

namespace MAVN.Service.PartnersIntegration.Domain.Models
{
    public class PaymentsExecuteResponse
    {
        public PaymentExecuteStatus Status { get; set; }

        public string PaymentId { get; set; }

        public string CustomerId { get; set; }

        public Money18 TokensAmount { get; set; }

        public decimal FiatAmount { get; set; }

        public string Currency { get; set; }
    }
}
