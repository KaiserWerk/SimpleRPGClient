using System.Text.Json.Serialization;

namespace SimpleRPGClient.Core.Models.Auth;

public class LoginResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("technical_code")]
    public TechnicalCode TechnicalCode { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("valid_until")]
    public DateTimeOffset ValidUntil { get; set; }

    [JsonPropertyName("player_data")]
    public PlayerData PlayerData { get; set; }
}

public class PlayerData
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("gold")]
    public long Gold { get; set; }

    [JsonPropertyName("experience_points")]
    public int ExperiencePoints { get; set; }

    [JsonPropertyName("max_experience_points")]
    public int MaxExperiencePoints { get; set; }

    [JsonPropertyName("current_health")]
    public int CurrentHealth { get; set; }

    [JsonPropertyName("max_health")]
    public int MaxHealth { get; set; }

    [JsonPropertyName("strength")]
    public int Strength { get; set; }

    [JsonPropertyName("defense")]
    public int Defense { get; set; }

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }

    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}
