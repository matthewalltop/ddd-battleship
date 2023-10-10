public abstract class EventBase : IEvent
{
    public DateTime TimeStamp => DateTime.UtcNow;
    public Guid CorrelationId { get; set; }
    public string UserName { get; set; }  = default!;
}