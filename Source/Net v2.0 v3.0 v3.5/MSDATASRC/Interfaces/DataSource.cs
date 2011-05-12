//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSDATASRCApi
{
	///<summary>
	/// Interface DataSource SupportByLibrary DSI1.0 
	///</summary>
	[SupportByLibrary("DSI1.0")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class DataSource : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSource(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSource(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSource(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataSource()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="bstrDM">string bstrDM</param>
		/// <param name="riid">Guid riid</param>
		[SupportByLibrary("DSI1.0")]
		public COMObject getDataMember(string bstrDM, Guid riid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDM, riid);
			object returnItem = Invoker.MethodReturn(this, "getDataMember", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="lIndex">Int32 lIndex</param>
		[SupportByLibrary("DSI1.0")]
		public string getDataMemberName(Int32 lIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lIndex);
			object returnItem = Invoker.MethodReturn(this, "getDataMemberName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		[SupportByLibrary("DSI1.0")]
		public Int32 getDataMemberCount()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getDataMemberCount", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="pDSL">NetOffice.MSDATASRCApi.DataSourceListener pDSL</param>
		[SupportByLibrary("DSI1.0")]
		public Int32 addDataSourceListener(NetOffice.MSDATASRCApi.DataSourceListener pDSL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pDSL);
			object returnItem = Invoker.MethodReturn(this, "addDataSourceListener", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DSI1.0 
		/// </summary>
		/// <param name="pDSL">NetOffice.MSDATASRCApi.DataSourceListener pDSL</param>
		[SupportByLibrary("DSI1.0")]
		public Int32 removeDataSourceListener(NetOffice.MSDATASRCApi.DataSourceListener pDSL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pDSL);
			object returnItem = Invoker.MethodReturn(this, "removeDataSourceListener", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}