using System;

namespace Fuget
{
	public class Project
	{
		public Guid Id { get; private set; }

		public Project (Guid id)
		{
			Id = id;
		}
	}
}

