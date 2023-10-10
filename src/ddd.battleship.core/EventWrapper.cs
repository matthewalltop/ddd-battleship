using System.Text.Json.Serialization;


public class EventWrapper
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("stream")]
    public EventStream Stream { get; set; } = default!;

    [JsonPropertyName("timestamp")]
    public DateTime TimeStamp { get; set; }

    [JsonPropertyName("correlationId")]
    public Guid CorrelationId { get; set; }

    [JsonPropertyName("userName")]
    public string UserName { get; set; } = default!;

    [JsonPropertyName("eventData")]
    public object EventData { get; set; } = default!;
}

public class EventStream
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("removed")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Removed {get; set;}

}