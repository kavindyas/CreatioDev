namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: KaviRealtyServiceSchema

	/// <exclude/>
	public class KaviRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public KaviRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public KaviRealtyServiceSchema(KaviRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3acbd6c7-7529-4943-aa69-925fdd6c0460");
			Name = "KaviRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f081987-d817-44b8-aca2-f56fe376a79b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,208,211,211,3,0,43,31,116,100,4,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3acbd6c7-7529-4943-aa69-925fdd6c0460"));
		}

		#endregion

	}

	#endregion

}

