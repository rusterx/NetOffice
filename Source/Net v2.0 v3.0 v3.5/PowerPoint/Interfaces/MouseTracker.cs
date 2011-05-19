//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// Interface MouseTracker SupportByLibrary "PowerPoint", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class MouseTracker : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTracker(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTracker(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTracker(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTracker()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="X">Single X</param>
		/// <param name="Y">Single Y</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 OnTrack(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			object returnItem = Invoker.MethodReturn(this, "OnTrack", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="X">Single X</param>
		/// <param name="Y">Single Y</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Int32 EndTrack(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			object returnItem = Invoker.MethodReturn(this, "EndTrack", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}