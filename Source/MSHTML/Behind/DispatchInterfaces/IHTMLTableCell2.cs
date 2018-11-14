﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// DispatchInterface IHTMLTableCell2 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class IHTMLTableCell2 : IHTMLTableCell, NetOffice.MSHTMLApi.IHTMLTableCell2
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
                    _contractType = typeof(NetOffice.MSHTMLApi.IHTMLTableCell2);
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
                    _type = typeof(IHTMLTableCell2);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IHTMLTableCell2() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string abbr
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "abbr");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "abbr", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string axis
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "axis");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "axis", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string ch
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "ch");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ch", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string chOff
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "chOff");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "chOff", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string headers
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "headers");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "headers", value);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		public virtual string scope
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "scope");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "scope", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}

