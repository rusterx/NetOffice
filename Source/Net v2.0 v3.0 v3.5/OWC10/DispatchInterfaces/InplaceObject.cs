//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface InplaceObject SupportByLibrary "OWC10", 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class InplaceObject : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InplaceObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InplaceObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InplaceObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InplaceObject()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		/// <param name="Hwnd">Int32 Hwnd</param>
		[SupportByLibrary("OWC10", 1)]
		public void Activate(Int32 hwnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hwnd);
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public void Deactivate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Deactivate", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}