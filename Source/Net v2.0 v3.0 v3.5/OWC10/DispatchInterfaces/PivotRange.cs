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
	/// DispatchInterface PivotRange SupportByLibrary "OWC10", 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotRange : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRange(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRange(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRange(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotRange()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotCell TopLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopLeft", paramsArray);
				NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotCell BottomRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BottomRight", paramsArray);
				NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotRowMembers RowMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowMembers", paramsArray);
				NetOffice.OWC10Api.PivotRowMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotRowMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotColumnMembers ColumnMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnMembers", paramsArray);
				NetOffice.OWC10Api.PivotColumnMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotColumnMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 1 
		/// </summary>
		/// <param name="Row">NetOffice.OWC10Api.PivotRowMember Row</param>
		/// <param name="Column">NetOffice.OWC10Api.PivotColumnMember Column</param>
		[SupportByLibrary("OWC10", 1)]
		public NetOffice.OWC10Api.PivotCell get_Cells(NetOffice.OWC10Api.PivotRowMember row, NetOffice.OWC10Api.PivotColumnMember column)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, column);
			object returnItem = Invoker.PropertyGet(this, "Cells", paramsArray);
			NetOffice.OWC10Api.PivotCell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotCell;
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}