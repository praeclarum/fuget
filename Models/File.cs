using System;

namespace Fuget
{
	public class File
	{
		public Guid Id { get; private set; }

		public File (Guid id)
		{
			Id = id;
		}
	}
}

