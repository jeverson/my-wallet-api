using System;
using System.Diagnostics.CodeAnalysis;

namespace my_wallet_api
{
    public class Money : IEquatable<Money>
    {
        public string Currency { get; set; }
        public decimal Value { get; set; }

        public bool Equals([AllowNull] Money other) => 
            Currency == other.Currency && 
            Value == other.Value;
    }
}
