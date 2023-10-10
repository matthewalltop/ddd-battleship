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

	public abstract void Apply(object @event);
	public abstract IEnumerable<object> GetUncommittedEvents();
	public abstract void ClearUncommittedEvents();
	public abstract void LoadFromHistory(IEnumerable<object> history);
	public abstract void LoadFromSnapshot(Snapshot snapshot);
	public abstract Snapshot TakeSnapshot();
}
