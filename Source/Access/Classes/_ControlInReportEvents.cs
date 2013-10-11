using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass _ControlInReportEvents 
	/// SupportByVersion Access, 9,10,11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Access", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class _ControlInReportEvents : _Control,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		__ControlInReportEvents_SinkHelper ___ControlInReportEvents_SinkHelper;
		_DispControlInReportEvents_SinkHelper __DispControlInReportEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_ControlInReportEvents);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public _ControlInReportEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ControlInReportEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _ControlInReportEvents(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of _ControlInReportEvents 
        /// </summary>		
		public _ControlInReportEvents():base("Access._ControlInReportEvents")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of _ControlInReportEvents
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public _ControlInReportEvents(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods

		/// <summary>
        /// returns all running Access._ControlInReportEvents objects from the running object table(ROT)
        /// </summary>
        /// <returns>an Access._ControlInReportEvents array</returns>
		public static NetOffice.AccessApi._ControlInReportEvents[] GetActiveInstances()
		{		
			NetRuntimeSystem.Collections.Generic.List<object> proxyList = NetOffice.RunningObjectTable.GetActiveProxiesFromROT("Access","_ControlInReportEvents");
			NetRuntimeSystem.Collections.Generic.List<NetOffice.AccessApi._ControlInReportEvents> resultList = new NetRuntimeSystem.Collections.Generic.List<NetOffice.AccessApi._ControlInReportEvents>();
			foreach(object proxy in proxyList)
				resultList.Add( new NetOffice.AccessApi._ControlInReportEvents(null, proxy) );
			return resultList.ToArray();
		}

		/// <summary>
        /// returns a running Access._ControlInReportEvents object from the running object table(ROT). the method takes the first element from the table
        /// </summary>
        /// <returns>an Access._ControlInReportEvents object or null</returns>
		public static NetOffice.AccessApi._ControlInReportEvents GetActiveInstance()
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Access","_ControlInReportEvents", false);
			if(null != proxy)
				return new NetOffice.AccessApi._ControlInReportEvents(null, proxy);
			else
				return null;
		}

		/// <summary>
        /// returns a running Access._ControlInReportEvents object from the running object table(ROT).  the method takes the first element from the table
        /// </summary>
	    /// <param name="throwOnError">throw an exception if no object was found</param>
        /// <returns>an Access._ControlInReportEvents object or null</returns>
		public static NetOffice.AccessApi._ControlInReportEvents GetActiveInstance(bool throwOnError)
		{
			object proxy = NetOffice.RunningObjectTable.GetActiveProxyFromROT("Access","_ControlInReportEvents", throwOnError);
			if(null != proxy)
				return new NetOffice.AccessApi._ControlInReportEvents(null, proxy);
			else
				return null;
		}
		#endregion

		#region Events

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, __ControlInReportEvents_SinkHelper.Id,_DispControlInReportEvents_SinkHelper.Id);


			if(__ControlInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				___ControlInReportEvents_SinkHelper = new __ControlInReportEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(_DispControlInReportEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__DispControlInReportEvents_SinkHelper = new _DispControlInReportEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != ___ControlInReportEvents_SinkHelper)
			{
				___ControlInReportEvents_SinkHelper.Dispose();
				___ControlInReportEvents_SinkHelper = null;
			}
			if( null != __DispControlInReportEvents_SinkHelper)
			{
				__DispControlInReportEvents_SinkHelper.Dispose();
				__DispControlInReportEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}