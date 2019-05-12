using System;
namespace pbeextractionbuildlogs.MetaModel
{
	public class TravisWorker : MetaModelObject
	{
		public TravisWorker()
		{
		}

		public override string Description() => "The ID of the travis worker used to execute the build";

		public override string Name() => "Travis Worker ID";
	}
}
