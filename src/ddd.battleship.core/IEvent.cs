
public interface IEvent
{
    DateTime TimeStamp { get; }

    Guid CorrelationId { get; set; }

    string UserName {get; set;}
}