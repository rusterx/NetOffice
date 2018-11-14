﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.WordApi;

namespace NetOffice.WordApi.Behind
{
    /// <summary>
    /// CoClass OLEControl 
    /// SupportByVersion Word, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.WordApi.EventContracts.OCXEvents))]
    public class OLEControl : NetOffice.WordApi.Behind._OLEControl, NetOffice.WordApi.OLEControl
    {
        #pragma warning disable

        #region Fields

        private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
        private string _activeSinkId;
        private static Type _type;
        private EventContracts.OCXEvents_SinkHelper _oCXEvents_SinkHelper;

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
                    _contractType = typeof(NetOffice.WordApi.OLEControl);
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
                    _type = typeof(OLEControl);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not intended to use
        /// </summary>
        public OLEControl() : base()
        {

        }

        #endregion

        #region Static CoClass Methods
        #endregion

        #region Events

        /// <summary>
        /// SupportByVersion Word, 9,10,11,12,14,15,16
        /// </summary>
        private event OLEControl_GotFocusEventHandler _GotFocusEvent;

        /// <summary>
        /// SupportByVersion Word 9 10 11 12 14 15,16
        /// </summary>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public event OLEControl_GotFocusEventHandler GotFocusEvent
        {
            add
            {
                CreateEventBridge();
                _GotFocusEvent += value;
            }
            remove
            {
                _GotFocusEvent -= value;
            }
        }

        /// <summary>
        /// SupportByVersion Word, 9,10,11,12,14,15,16
        /// </summary>
        private event OLEControl_LostFocusEventHandler _LostFocusEvent;

        /// <summary>
        /// SupportByVersion Word 9 10 11 12 14 15,16
        /// </summary>
        [SupportByVersion("Word", 9, 10, 11, 12, 14, 15, 16)]
        public event OLEControl_LostFocusEventHandler LostFocusEvent
        {
            add
            {
                CreateEventBridge();
                _LostFocusEvent += value;
            }
            remove
            {
                _LostFocusEvent -= value;
            }
        }

        #endregion

        #region IEventBinding

        /// <summary>
        /// Creates active sink helper
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void CreateEventBridge()
        {
            if (false == Factory.Settings.EnableEvents)
                return;

            if (null != _connectPoint)
                return;

            if (null == _activeSinkId)
                _activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, EventContracts.OCXEvents_SinkHelper.Id);

            if (EventContracts.OCXEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
            {
                _oCXEvents_SinkHelper = new EventContracts.OCXEvents_SinkHelper(this, _connectPoint);
                return;
            }
        }

        /// <summary>
        /// The instance use currently an event listener 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
        {
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
        }
        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
            if (null != _oCXEvents_SinkHelper)
            {
                _oCXEvents_SinkHelper.Dispose();
                _oCXEvents_SinkHelper = null;
            }

            _connectPoint = null;
        }

        #endregion

        #pragma warning restore
    }
}
