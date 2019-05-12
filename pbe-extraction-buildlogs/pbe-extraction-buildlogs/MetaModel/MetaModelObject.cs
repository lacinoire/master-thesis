using System;
namespace pbeextractionbuildlogs.MetaModel
{
	/// <summary>
	/// An object from the buildlog data metamodel
	/// </summary>
	public abstract class MetaModelObject
	{
		public abstract string Name();
		public abstract string Description();

		public MetaModelObject()
		{
		}
	}
}
