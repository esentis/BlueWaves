namespace Esentis.BlueWaves.Web.Api.Helpers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public class BWLogTemplates
	{
		public const string CreatedEntity = "Created {Entity} {@Value}";

		public const string RequestEntity = "User requested {Entity} with ID {Id}";

		public const string RequestEntities = "User requested collection of {Entity}. Found {Count} records";

		public const string Conflict = "{Entity} with {Id} has assignments";

		public const string Deleted = "{Entity} with {Id} has been deleted";

		public const string Updated = "{Entity} has been updated";
	}
}