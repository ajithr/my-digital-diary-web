﻿namespace MyDigitalDiaryWeb.Shared
{
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    public class BankDetails
    {
        [JsonPropertyName("bankName")]
        [Required(ErrorMessage = "Bank name is required.")]
        public string BankName { get; set; }
        [JsonPropertyName("ifsc")]
        [Required(ErrorMessage = "IFSC code is required.")]
        public string IFSC { get; set; }
        [JsonPropertyName("accountHolderName")]
        [Required(ErrorMessage = "Account holder name is required.")]
        public string AccountHolderName { get; set; }
        [JsonPropertyName("accountType")]
        [Required(ErrorMessage = "Account holder name is required.")]
        public string AccountType { get; set; }
    }
    public class CardDetails
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("bankName")]
        [Required(ErrorMessage = "Bank name is required.")]
        public string BankName { get; set; }
        [JsonPropertyName("cardNumber")]
        [Required(ErrorMessage = "Card number is required.")]
        public string CardNumber { get; set; }
        [JsonPropertyName("expiryMonth")]
        [Required(ErrorMessage = "Expiry month is required.")]
        public string ExpiryMonth { get; set; }
        [JsonPropertyName("expiryYear")]
        [Required(ErrorMessage = "Expiry year is required.")]
        public string ExpiryYear { get; set; }
        [JsonPropertyName("cardHolderName")]
        [Required(ErrorMessage = "Card holder name is required.")]
        public string CardHolderName { get; set; }
        [JsonPropertyName("cvv")]
        [Required(ErrorMessage = "CVV is required.")]
        public int? CVV { get; set; }
        [JsonPropertyName("pin")]
        [Required(ErrorMessage = "Pin is required.")]
        public int? Pin { get; set; }
    }

    public class CardApiResponse
    {
        [JsonPropertyName("isCardAdded")]
        public bool IsCardAdded { get; set; }
        [JsonPropertyName("isCardUpdated")]
        public bool IsCardUpdated { get; set; }
        [JsonPropertyName("isCardDeleted")]
        public bool IsCardDeleted { get; set; }
        [JsonPropertyName("error")]
        public string? ErrorMessage { get; set; }
    }

    public static class Banks
    {
        public static Dictionary<string, string> BankNames { get; set; } = new Dictionary<string, string>()
        {
            { "Add Custom Bank", "custom-bank.jpg" },
            { "Axis Bank", "axis.png" },
            {"Bank of Baroda", "bank-of-baroda.png" },
            {"Canara Bank", "canara.png" },
            {"Citi Bank", "citi.jpeg" },
            {"HDFC Bank", "hdfc.png" },
            {"HSBC", "hsbc.png" },
            {"ICICI Bank", "icici.png" },
            {"Indian Bank", "indian.png" },
            {"Indian Overseas Bank", "indian-overseas.png" },
            {"Karur Vysya Bank", "karur-vysya.jpg" },
            {"Kotak Mahendra Bank", "kotak-mahindra.jpg" },
            {"State Bank of India", "sbi.png" },
            {"Tamilnad Mercantile Bank", "tmb.webp" },
            {"Union Bank of India", "union.webp" }
        };
    }
}