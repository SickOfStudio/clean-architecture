using System;

namespace CleanArchitecture.Domain.Entities
{    
    public class DueDate
	{
		private readonly DateTime timeStamp;

		public virtual DateTime asSystemInstant()
		{
			return timeStamp;
		}
	}

}