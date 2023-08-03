namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: KaviRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class KaviRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public KaviRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public KaviRealtyFreedomUIEventsSchema(KaviRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3e1cedf-29f4-4e54-a68a-e506f1a291b2");
			Name = "KaviRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f081987-d817-44b8-aca2-f56fe376a79b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,111,219,48,12,189,23,232,127,32,140,29,108,32,16,218,235,250,1,44,89,58,4,43,214,162,113,118,25,118,80,100,198,213,160,15,67,146,211,166,69,255,123,41,203,65,93,167,3,202,139,44,234,241,145,239,153,134,107,244,13,23,8,37,58,199,189,221,4,54,179,102,35,235,214,241,32,173,57,62,122,62,62,2,138,214,75,83,195,114,231,3,234,179,97,106,88,168,181,53,255,125,116,200,230,38,200,32,209,127,6,195,230,91,52,97,15,253,211,165,119,93,238,90,210,16,6,93,190,20,247,168,249,47,210,0,23,144,253,228,91,121,135,92,133,93,86,252,77,85,77,187,86,82,128,80,220,123,72,111,31,240,192,87,152,114,143,31,188,36,150,222,129,1,161,221,210,204,178,66,216,90,89,193,141,89,24,143,46,144,152,220,174,255,161,8,224,209,84,232,38,144,56,167,184,33,101,29,243,55,87,123,192,226,141,113,64,30,99,77,131,176,33,225,158,9,139,179,247,200,68,13,174,83,69,250,243,148,40,82,193,8,92,161,144,154,43,104,156,20,209,172,84,197,126,96,40,119,13,86,51,171,90,109,126,115,213,226,121,15,189,204,59,67,111,99,193,106,249,61,27,183,151,27,200,19,219,37,156,158,236,163,120,15,26,137,139,129,108,225,103,220,8,84,88,209,32,193,181,72,204,135,56,31,92,92,14,90,79,207,107,44,81,55,138,135,56,186,193,7,184,182,130,43,249,196,215,10,151,29,46,239,5,173,200,54,218,95,67,255,128,150,151,221,161,183,173,19,4,178,142,88,38,135,109,98,12,54,231,202,33,86,86,175,22,105,249,178,9,100,7,189,60,235,140,90,248,210,218,169,172,211,45,43,88,105,251,89,138,79,8,34,33,41,193,174,172,211,60,228,35,161,212,248,148,157,76,191,28,248,30,35,220,59,251,208,25,49,127,20,216,68,169,251,250,49,252,229,237,218,127,210,241,242,10,104,136,49,9,247,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("05880815-9ee7-6a28-aae9-0f7063ef55e6"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("6f081987-d817-44b8-aca2-f56fe376a79b"),
				CreatedInSchemaUId = new Guid("d3e1cedf-29f4-4e54-a68a-e506f1a291b2"),
				ModifiedInSchemaUId = new Guid("d3e1cedf-29f4-4e54-a68a-e506f1a291b2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3e1cedf-29f4-4e54-a68a-e506f1a291b2"));
		}

		#endregion

	}

	#endregion

}

