﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OutlookApi.Behind
{
	/// <summary>
	/// CoClass StorageItem 
	/// SupportByVersion Outlook, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864182.aspx </remarks>
	[SupportByVersion("Outlook", 12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
 	public class StorageItem : _StorageItem, NetOffice.OutlookApi.StorageItem
    {
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;

        #endregion

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
                    _contractType = typeof(NetOffice.OutlookApi.StorageItem);
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
        
        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(StorageItem);
                return _type;
            }
        }
        
        #endregion
        		
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public StorageItem() : base()
		{

		}

		#endregion

		#pragma warning restore
	}
}