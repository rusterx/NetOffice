//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{

	#region Delegates

	#pragma warning disable
	public delegate void ChartSpace_DataSetChangeEventHandler();
	public delegate void ChartSpace_DblClickEventHandler();
	public delegate void ChartSpace_ClickEventHandler();
	public delegate void ChartSpace_KeyDownEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void ChartSpace_KeyUpEventHandler(Int32 KeyCode, Int32 Shift);
	public delegate void ChartSpace_KeyPressEventHandler(Int32 KeyAscii);
	public delegate void ChartSpace_BeforeKeyDownEventHandler(Int32 KeyCode, Int32 Shift, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_BeforeKeyUpEventHandler(Int32 KeyCode, Int32 Shift, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_BeforeKeyPressEventHandler(Int32 KeyAscii, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_MouseDownEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void ChartSpace_MouseMoveEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void ChartSpace_MouseUpEventHandler(Int32 Button, Int32 Shift, Int32 x, Int32 y);
	public delegate void ChartSpace_MouseWheelEventHandler(bool Page, Int32 Count);
	public delegate void ChartSpace_SelectionChangeEventHandler();
	public delegate void ChartSpace_BeforeScreenTipEventHandler(NetOffice.OWC10Api.ByRef TipText, COMObject ContextObject);
	public delegate void ChartSpace_CommandEnabledEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Enabled);
	public delegate void ChartSpace_CommandCheckedEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Checked);
	public delegate void ChartSpace_CommandTipTextEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Caption);
	public delegate void ChartSpace_CommandBeforeExecuteEventHandler(COMObject Command, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_CommandExecuteEventHandler(COMObject Command, bool Succeeded);
	public delegate void ChartSpace_BeforeContextMenuEventHandler(Int32 x, Int32 y, NetOffice.OWC10Api.ByRef Menu, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_BeforeRenderEventHandler(NetOffice.OWC10Api.ChChartDraw drawObject, COMObject chartObject, NetOffice.OWC10Api.ByRef Cancel);
	public delegate void ChartSpace_AfterRenderEventHandler(NetOffice.OWC10Api.ChChartDraw drawObject, COMObject chartObject);
	public delegate void ChartSpace_AfterFinalRenderEventHandler(NetOffice.OWC10Api.ChChartDraw drawObject);
	public delegate void ChartSpace_AfterLayoutEventHandler(NetOffice.OWC10Api.ChChartDraw drawObject);
	public delegate void ChartSpace_ViewChangeEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass ChartSpace SupportByLibrary "OWC10", 1
	///</summary>
	[SupportByLibrary("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class ChartSpace : ChChartSpace, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		IChartEvents_SinkHelper _iChartEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartSpace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartSpace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChartSpace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public ChartSpace()
		{
			CreateFromProgId("OWC10.ChartSpace");
		}
		
		/// <param name="progId">progId</param>
		public ChartSpace(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, IChartEvents_SinkHelper.Id);


			if(IChartEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iChartEvents_SinkHelper = new IChartEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_DataSetChangeEventHandler _DataSetChangeEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_DataSetChangeEventHandler DataSetChangeEvent
		{
			add
			{
				CreateEventBridge();
				_DataSetChangeEvent += value;
			}
			remove
			{
				_DataSetChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeKeyDownEventHandler _BeforeKeyDownEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeKeyDownEventHandler BeforeKeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyDownEvent += value;
			}
			remove
			{
				_BeforeKeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeKeyUpEventHandler _BeforeKeyUpEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeKeyUpEventHandler BeforeKeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyUpEvent += value;
			}
			remove
			{
				_BeforeKeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeKeyPressEventHandler _BeforeKeyPressEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeKeyPressEventHandler BeforeKeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeKeyPressEvent += value;
			}
			remove
			{
				_BeforeKeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_MouseWheelEventHandler _MouseWheelEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_MouseWheelEventHandler MouseWheelEvent
		{
			add
			{
				CreateEventBridge();
				_MouseWheelEvent += value;
			}
			remove
			{
				_MouseWheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_SelectionChangeEventHandler _SelectionChangeEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_SelectionChangeEventHandler SelectionChangeEvent
		{
			add
			{
				CreateEventBridge();
				_SelectionChangeEvent += value;
			}
			remove
			{
				_SelectionChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeScreenTipEventHandler _BeforeScreenTipEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeScreenTipEventHandler BeforeScreenTipEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeScreenTipEvent += value;
			}
			remove
			{
				_BeforeScreenTipEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_CommandEnabledEventHandler _CommandEnabledEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_CommandEnabledEventHandler CommandEnabledEvent
		{
			add
			{
				CreateEventBridge();
				_CommandEnabledEvent += value;
			}
			remove
			{
				_CommandEnabledEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_CommandCheckedEventHandler _CommandCheckedEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_CommandCheckedEventHandler CommandCheckedEvent
		{
			add
			{
				CreateEventBridge();
				_CommandCheckedEvent += value;
			}
			remove
			{
				_CommandCheckedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_CommandTipTextEventHandler _CommandTipTextEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_CommandTipTextEventHandler CommandTipTextEvent
		{
			add
			{
				CreateEventBridge();
				_CommandTipTextEvent += value;
			}
			remove
			{
				_CommandTipTextEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_CommandBeforeExecuteEventHandler _CommandBeforeExecuteEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_CommandBeforeExecuteEventHandler CommandBeforeExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandBeforeExecuteEvent += value;
			}
			remove
			{
				_CommandBeforeExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_CommandExecuteEventHandler _CommandExecuteEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_CommandExecuteEventHandler CommandExecuteEvent
		{
			add
			{
				CreateEventBridge();
				_CommandExecuteEvent += value;
			}
			remove
			{
				_CommandExecuteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeContextMenuEventHandler _BeforeContextMenuEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeContextMenuEventHandler BeforeContextMenuEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeContextMenuEvent += value;
			}
			remove
			{
				_BeforeContextMenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_BeforeRenderEventHandler _BeforeRenderEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_BeforeRenderEventHandler BeforeRenderEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeRenderEvent += value;
			}
			remove
			{
				_BeforeRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_AfterRenderEventHandler _AfterRenderEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_AfterRenderEventHandler AfterRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterRenderEvent += value;
			}
			remove
			{
				_AfterRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_AfterFinalRenderEventHandler _AfterFinalRenderEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_AfterFinalRenderEventHandler AfterFinalRenderEvent
		{
			add
			{
				CreateEventBridge();
				_AfterFinalRenderEvent += value;
			}
			remove
			{
				_AfterFinalRenderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_AfterLayoutEventHandler _AfterLayoutEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_AfterLayoutEventHandler AfterLayoutEvent
		{
			add
			{
				CreateEventBridge();
				_AfterLayoutEvent += value;
			}
			remove
			{
				_AfterLayoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10, 1
		/// </summary>
		private event ChartSpace_ViewChangeEventHandler _ViewChangeEvent;

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		[SupportByLibrary("OWC10", 1)]
		public event ChartSpace_ViewChangeEventHandler ViewChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ViewChangeEvent += value;
			}
			remove
			{
				_ViewChangeEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
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
        public void DisposeSinkHelper()
        {
			if( null != _iChartEvents_SinkHelper)
			{
				_iChartEvents_SinkHelper.Dispose();
				_iChartEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}