﻿namespace ddd.battleship.domain;

using System.Collections.Generic;
using ddd.battleship.core;

public class Game : AggregateBase
{
	public Game(Guid id) : base(id)
	{

	}
	public override void ApplyEvent(IEvent @event)
	{
		throw new NotImplementedException();
	}

	public override void ClearUncommittedEvents()
	{
		throw new NotImplementedException();
	}

	public override IEnumerable<object> GetUncommittedEvents()
	{
		throw new NotImplementedException();
	}

	public override void LoadFromHistory(IEnumerable<object> history)
	{
		throw new NotImplementedException();
	}

	// public override void LoadFromSnapshot(Snapshot snapshot)
	// {
	// 	throw new NotImplementedException();
	// }

	// public override Snapshot TakeSnapshot()
	// {
	// 	throw new NotImplementedException();
	// }
}
