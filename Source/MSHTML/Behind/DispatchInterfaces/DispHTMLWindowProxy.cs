﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// DispatchInterface DispHTMLWindowProxy 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
 	public class DispHTMLWindowProxy : COMObject, NetOffice.MSHTMLApi.DispHTMLWindowProxy
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.MSHTMLApi.DispHTMLWindowProxy);
                return _contractType;
            }
        }
        private static Type _contractType;


		/// <summary>
		/// Instance Type
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
		public override Type InstanceType
		{
			get
			{
				return LateBindingApiWrapperType;
			}
		}

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DispHTMLWindowProxy);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public DispHTMLWindowProxy() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 length
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "length");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLFramesCollection2 frames
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLFramesCollection2>(this, "frames");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string defaultStatus
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "defaultStatus");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "defaultStatus", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string status
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "status");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "status", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLLocation location
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLLocation>(this, "location", typeof(NetOffice.MSHTMLApi.IHTMLLocation));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IOmHistory history
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IOmHistory>(this, "history", typeof(NetOffice.MSHTMLApi.IOmHistory));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object opener
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "opener");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "opener", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IOmNavigator navigator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IOmNavigator>(this, "navigator", typeof(NetOffice.MSHTMLApi.IOmNavigator));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string name
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "name");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "name", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "parent", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 self
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "self", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 top
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "top", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 window
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "window", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onfocus
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onfocus");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onfocus", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onblur
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onblur");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onblur", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onload
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onload");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onload", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onbeforeunload
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onbeforeunload");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onbeforeunload", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onunload
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onunload");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onunload", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onhelp
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onhelp");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onhelp", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onerror
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onerror");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onerror", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onresize
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onresize");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onresize", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onscroll
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onscroll");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onscroll", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLDocument2 document
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLDocument2>(this, "document", typeof(NetOffice.MSHTMLApi.IHTMLDocument2));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLEventObj get_event()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLEventObj>(this, "event", typeof(NetOffice.MSHTMLApi.IHTMLEventObj));
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual object _newEnum
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "_newEnum");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLScreen screen
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLScreen>(this, "screen");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual bool closed
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "closed");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IOmNavigator clientInformation
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IOmNavigator>(this, "clientInformation", typeof(NetOffice.MSHTMLApi.IOmNavigator));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object offscreenBuffering
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "offscreenBuffering");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "offscreenBuffering", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		public virtual object external
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "external");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 screenLeft
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "screenLeft");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 screenTop
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "screenTop");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onbeforeprint
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onbeforeprint");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onbeforeprint", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onafterprint
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onafterprint");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onafterprint", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLDataTransfer clipboardData
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLDataTransfer>(this, "clipboardData", typeof(NetOffice.MSHTMLApi.IHTMLDataTransfer));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLFrameBase frameElement
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLFrameBase>(this, "frameElement");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLStorage sessionStorage
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLStorage>(this, "sessionStorage", typeof(NetOffice.MSHTMLApi.IHTMLStorage));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLStorage localStorage
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSHTMLApi.IHTMLStorage>(this, "localStorage", typeof(NetOffice.MSHTMLApi.IHTMLStorage));
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onhashchange
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onhashchange");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onhashchange", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 maxConnectionsPerServer
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "maxConnectionsPerServer");
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual object onmessage
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "onmessage");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "onmessage", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("MSHTML", 4), ProxyResult]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public virtual object constructor
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "constructor");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="pvarIndex">object pvarIndex</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object item(object pvarIndex)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "item", pvarIndex);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void clearTimeout(Int32 timerID)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "clearTimeout", timerID);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void alert(object message)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "alert", message);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual void alert()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "alert");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersion("MSHTML", 4)]
		public virtual bool confirm(object message)
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "confirm", message);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual bool confirm()
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "confirm");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		/// <param name="defstr">optional string defstr = undefined</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object prompt(object message, object defstr)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "prompt", message, defstr);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object prompt()
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "prompt");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="message">optional string message = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object prompt(object message)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "prompt", message);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual void close()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "close");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		/// <param name="replace">optional bool replace = false</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features, object replace)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "open", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url, name, features, replace);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 open()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "open", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 open(object url)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "open", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "open", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url, name);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "open", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url, name, features);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">string url</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void navigate(string url)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "navigate", url);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="varOptions">optional object varOptions</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object showModalDialog(string dialog, object varArgIn, object varOptions)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "showModalDialog", dialog, varArgIn, varOptions);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object showModalDialog(string dialog)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "showModalDialog", dialog);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object showModalDialog(string dialog, object varArgIn)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "showModalDialog", dialog, varArgIn);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		/// <param name="features">optional string features = </param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void showHelp(string helpURL, object helpArg, object features)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "showHelp", helpURL, helpArg, features);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual void showHelp(string helpURL)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "showHelp", helpURL);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual void showHelp(string helpURL, object helpArg)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "showHelp", helpURL, helpArg);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual void focus()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "focus");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual void blur()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "blur");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void scroll(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "scroll", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void clearInterval(Int32 timerID)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "clearInterval", timerID);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="code">string code</param>
		/// <param name="language">optional string language = jScript</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object execScript(string code, object language)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "execScript", code, language);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="code">string code</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object execScript(string code)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "execScript", code);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string toString()
		{
			return InvokerService.InvokeInternal.ExecuteStringMethodGet(this, "toString");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void scrollBy(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "scrollBy", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void scrollTo(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "scrollTo", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void moveTo(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "moveTo", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void moveBy(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "moveBy", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void resizeTo(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "resizeTo", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void resizeBy(Int32 x, Int32 y)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "resizeBy", x, y);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="_event">string event</param>
		/// <param name="pdisp">object pdisp</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual bool attachEvent(string _event, object pdisp)
		{
			return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "attachEvent", _event, pdisp);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="_event">string event</param>
		/// <param name="pdisp">object pdisp</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void detachEvent(string _event, object pdisp)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "detachEvent", _event, pdisp);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 setTimeout(object expression, Int32 msec, object language)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "setTimeout", expression, msec, language);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 setTimeout(object expression, Int32 msec)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "setTimeout", expression, msec);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 setInterval(object expression, Int32 msec, object language)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "setInterval", expression, msec, language);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="expression">object expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 setInterval(object expression, Int32 msec)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "setInterval", expression, msec);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual void print()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "print");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="options">optional object options</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(object url, object varArgIn, object options)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "showModelessDialog", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url, varArgIn, options);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "showModelessDialog", typeof(NetOffice.MSHTMLApi.IHTMLWindow2));
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(object url)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "showModelessDialog", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual NetOffice.MSHTMLApi.IHTMLWindow2 showModelessDialog(object url, object varArgIn)
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLWindow2>(this, "showModelessDialog", typeof(NetOffice.MSHTMLApi.IHTMLWindow2), url, varArgIn);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="varArgIn">optional object varArgIn</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual object createPopup(object varArgIn)
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "createPopup", varArgIn);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual object createPopup()
		{
			return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "createPopup");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="msg">string msg</param>
		/// <param name="targetOrigin">optional object targetOrigin</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void postMessage(string msg, object targetOrigin)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "postMessage", msg, targetOrigin);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="msg">string msg</param>
		[CustomMethod]
		[SupportByVersion("MSHTML", 4)]
		public virtual void postMessage(string msg)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "postMessage", msg);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="bstrHTML">string bstrHTML</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual string toStaticHTML(string bstrHTML)
		{
			return InvokerService.InvokeInternal.ExecuteStringMethodGet(this, "toStaticHTML", bstrHTML);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="bstrProfilerMarkName">string bstrProfilerMarkName</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual void msWriteProfilerMark(string bstrProfilerMarkName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "msWriteProfilerMark", bstrProfilerMarkName);
		}

		#endregion

		#pragma warning restore
	}
}


