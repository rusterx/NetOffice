﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.MSProjectApi;

namespace NetOffice.MSProjectApi.Behind
{
	/// <summary>
	/// DispatchInterface CostRateTables 
	/// SupportByVersion MSProject, 11,12,14
	/// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff920578(v=office.14).aspx </remarks>
	public class CostRateTables : COMObject, NetOffice.MSProjectApi.CostRateTables
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
                    _contractType = typeof(NetOffice.MSProjectApi.CostRateTables);
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
                    _type = typeof(CostRateTables);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public CostRateTables() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("MSProject", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public virtual NetOffice.MSProjectApi.CostRateTable this[object index]
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.CostRateTable>(this, "Item", typeof(NetOffice.MSProjectApi.CostRateTable), index);
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual Int32 Count
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Resource Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.Resource>(this, "Parent", typeof(NetOffice.MSProjectApi.Resource));
			}
		}

		/// <summary>
		/// SupportByVersion MSProject 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersion("MSProject", 11,12,14)]
		public virtual NetOffice.MSProjectApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.MSProjectApi.Application>(this, "Application", typeof(NetOffice.MSProjectApi.Application));
			}
		}

        #endregion

        #region Methods

        #endregion

        #region IEnumerableProvider<NetOffice.MSProjectApi.CodeMaskLevel>

        ICOMObject IEnumerableProvider<NetOffice.MSProjectApi.CostRateTable>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.MSProjectApi.CostRateTable>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.MSProjectApi.CostRateTable>

        /// <summary>
        /// SupportByVersion MSProject, 11,12,14
        /// </summary>
        [SupportByVersion("MSProject", 11, 12, 14)]
        public virtual IEnumerator<NetOffice.MSProjectApi.CostRateTable> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.MSProjectApi.CostRateTable item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion MSProject, 11,12,14
        /// </summary>
        [SupportByVersion("MSProject", 11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

