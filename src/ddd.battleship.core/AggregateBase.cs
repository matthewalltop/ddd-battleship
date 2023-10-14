namespace ddd.battleship.core;

public abstract class AggregateBase
{
	protected Guid Id { get; private set; }
	protected int Version { get; private set; }

	public AggregateBase(Guid id)
	{
		this.Id = id;
		Version = 0;
	}

	public abstract void ApplyEvent(IEvent @event);

	public void Apply(IEnumerable<IEvent> @events)
	{
		foreach (var @event in @events)
		{
			ApplyEvent(@event);
			Version++;
		}
	}

	public abstract IEnumerable<object> GetUncommittedEvents();
	public abstract void ClearUncommittedEvents();
	public abstract void LoadFromHistory(IEnumerable<object> history);
	public abstract void LoadFromSnapshot(Snapshot snapshot);
	public abstract Snapshot TakeSnapshot();
}
