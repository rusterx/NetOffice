//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPTabSheets SupportByLibrary "PowerPoint", 9
	///</summary>
	[SupportByLibrary("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPTabSheets : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPTabSheets(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPTabSheets(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPTabSheets(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPTabSheets()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPTabSheet ActiveSheet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveSheet", paramsArray);
				NetOffice.PowerPointApi.PPTabSheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.PPTabSheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		[SupportByLibrary("PowerPoint", 9)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PowerPoint", 9)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.PPTabSheet this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.PPTabSheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPTabSheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPTabSheet Add(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.PPTabSheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.PPTabSheet;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}