using System.Text.Json.Serialization;

namespace SimpleRPGClient.Core.Models.Auth;

public class LogoutResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("technical_code")]
    public TechnicalCode TechnicalCode { get; set; }
}
