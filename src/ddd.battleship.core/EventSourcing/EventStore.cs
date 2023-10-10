using NEventStore;

public class EventStore
{
	private readonly IStoreEvents _storeEvents;

	public EventStore(IStoreEvents storeEvents)
	{
		this._storeEvents = storeEvents;
	}

	public async Task AppendToStream(string streamId, IEnumerable<IEvent> events)
	{
		using (var stream = this._storeEvents.OpenStream(streamId))
		{
			foreach (var @event in events)
			{
				stream.Add(new EventMessage { Body = @event });
			}

			// await stream.CommitChangesAsync(Guid.NewGuid());
		}
	}

}
