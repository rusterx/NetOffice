﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;
using NetOffice.Exceptions;

namespace NetOffice.MSFormsApi.Behind.EventContracts
{

	/// <summary>
	/// Default implementation of <see cref="NetOffice.MSFormsApi.EventContracts.ImageEvents"/>
	/// </summary>
    [InternalEntity(InternalEntityKind.SinkHelper)]
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class ImageEvents_SinkHelper : SinkHelper, NetOffice.MSFormsApi.EventContracts.ImageEvents
	{
		#region Static
		
		/// <summary>
		/// Interface Id from ImageEvents
		/// </summary>
		public static readonly string Id = "4C5992A5-6926-101B-9992-00000B65C6F9";
		
		#endregion
		
		#region Ctor

		/// <summary>
		/// Creates an instance of the class
		/// </summary>
		/// <param name="eventClass"></param>
		/// <param name="connectPoint"></param>
		/// <exception cref="NetOfficeCOMException">Unexpected error</exception>
		public ImageEvents_SinkHelper(ICOMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			SetupEventBinding(connectPoint);
		}
		
		#endregion

		#region ImageEvents
		
		/// <summary>
        /// 
        /// </summary>
        /// <param name="cancel"></param>
        /// <param name="data"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="dragState"></param>
        /// <param name="effect"></param>
        /// <param name="shift"></param>
		public void BeforeDragOver([In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In, MarshalAs(UnmanagedType.IDispatch)] object data, [In] object x, [In] object y, [In] object dragState, [In, MarshalAs(UnmanagedType.IDispatch)] object effect, [In] object shift)
        {
            if (!Validate("BeforeDragOver"))
            {
                Invoker.ReleaseParamsArray(cancel, data, x, y, dragState, effect, shift);
                return;
            }

			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			NetOffice.MSFormsApi.DataObject newData = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.DataObject>(EventClass, data, typeof(NetOffice.MSFormsApi.DataObject));
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			NetOffice.MSFormsApi.Enums.fmDragState newDragState = (NetOffice.MSFormsApi.Enums.fmDragState)dragState;
			NetOffice.MSFormsApi.ReturnEffect newEffect = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnEffect>(EventClass, effect, typeof(NetOffice.MSFormsApi.ReturnEffect));
			Int16 newShift = ToInt16(shift);
			object[] paramsArray = new object[7];
			paramsArray[0] = newCancel;
			paramsArray[1] = newData;
			paramsArray[2] = newX;
			paramsArray[3] = newY;
			paramsArray[4] = newDragState;
			paramsArray[5] = newEffect;
			paramsArray[6] = newShift;
			EventBinding.RaiseCustomEvent("BeforeDragOver", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="cancel"></param>
        /// <param name="action"></param>
        /// <param name="data"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="effect"></param>
        /// <param name="shift"></param>
		public void BeforeDropOrPaste([In, MarshalAs(UnmanagedType.IDispatch)] object cancel, [In] object action, [In, MarshalAs(UnmanagedType.IDispatch)] object data, [In] object x, [In] object y, [In, MarshalAs(UnmanagedType.IDispatch)] object effect, [In] object shift)
		{
            if (!Validate("BeforeDropOrPaste"))
            {
                Invoker.ReleaseParamsArray(cancel, action, data, x, y, effect, shift);
                return;
            }

			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			NetOffice.MSFormsApi.Enums.fmAction newAction = (NetOffice.MSFormsApi.Enums.fmAction)action;
			NetOffice.MSFormsApi.DataObject newData = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.DataObject>(EventClass, data, typeof(NetOffice.MSFormsApi.DataObject));
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			NetOffice.MSFormsApi.ReturnEffect newEffect = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnEffect>(EventClass, effect, typeof(NetOffice.MSFormsApi.ReturnEffect));
			Int16 newShift = ToInt16(shift);
			object[] paramsArray = new object[7];
			paramsArray[0] = newCancel;
			paramsArray[1] = newAction;
			paramsArray[2] = newData;
			paramsArray[3] = newX;
			paramsArray[4] = newY;
			paramsArray[5] = newEffect;
			paramsArray[6] = newShift;
			EventBinding.RaiseCustomEvent("BeforeDropOrPaste", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		public void Click()
        {
            if (!Validate("Click"))
            {
                return;
            }

			object[] paramsArray = new object[0];
			EventBinding.RaiseCustomEvent("Click", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancel"></param>
		public void DblClick([In, MarshalAs(UnmanagedType.IDispatch)] object cancel)
        {
            if (!Validate("DblClick"))
            {
                Invoker.ReleaseParamsArray(cancel);
                return;
            }

			NetOffice.MSFormsApi.ReturnBoolean newCancel = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancel, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			object[] paramsArray = new object[1];
			paramsArray[0] = newCancel;
			EventBinding.RaiseCustomEvent("DblClick", ref paramsArray);
		}

		/// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="description"></param>
        /// <param name="sCode"></param>
        /// <param name="source"></param>
        /// <param name="helpFile"></param>
        /// <param name="helpContext"></param>
        /// <param name="cancelDisplay"></param>
		public void Error([In] object number, [In, MarshalAs(UnmanagedType.IDispatch)] object description, [In] object sCode, [In] object source, [In] object helpFile, [In] object helpContext, [In, MarshalAs(UnmanagedType.IDispatch)] object cancelDisplay)
		{
            if (!Validate("Error"))
            {
                Invoker.ReleaseParamsArray(number, description, sCode, source, helpFile, helpContext, cancelDisplay);
                return;
            }
   
			Int16 newNumber = Convert.ToInt16(number);
			NetOffice.MSFormsApi.ReturnString newDescription = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnString>(EventClass, description, typeof(NetOffice.MSFormsApi.ReturnString));
			Int32 newSCode = ToInt32(sCode);
			string newSource = ToString(source);
			string newHelpFile = ToString(helpFile);
			Int32 newHelpContext = ToInt32(helpContext);
			NetOffice.MSFormsApi.ReturnBoolean newCancelDisplay = Factory.CreateKnownObjectFromComProxy<NetOffice.MSFormsApi.ReturnBoolean>(EventClass, cancelDisplay, typeof(NetOffice.MSFormsApi.ReturnBoolean));
			object[] paramsArray = new object[7];
			paramsArray[0] = newNumber;
			paramsArray[1] = newDescription;
			paramsArray[2] = newSCode;
			paramsArray[3] = newSource;
			paramsArray[4] = newHelpFile;
			paramsArray[5] = newHelpContext;
			paramsArray[6] = newCancelDisplay;
			EventBinding.RaiseCustomEvent("Error", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void MouseDown([In] object button, [In] object shift, [In] object x, [In] object y)
        {
            if (!Validate("MouseDown"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

			Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newX;
			paramsArray[3] = newY;
			EventBinding.RaiseCustomEvent("MouseDown", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void MouseMove([In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseMove"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

            Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newX;
			paramsArray[3] = newY;
			EventBinding.RaiseCustomEvent("MouseMove", ref paramsArray);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="button"></param>
		/// <param name="shift"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void MouseUp([In] object button, [In] object shift, [In] object x, [In] object y)
		{
            if (!Validate("MouseUp"))
            {
                Invoker.ReleaseParamsArray(button, shift, x, y);
                return;
            }

            Int16 newButton = ToInt16(button);
			Int16 newShift = ToInt16(shift);
			Single newX = ToSingle(x);
			Single newY = ToSingle(y);
			object[] paramsArray = new object[4];
			paramsArray[0] = newButton;
			paramsArray[1] = newShift;
			paramsArray[2] = newX;
			paramsArray[3] = newY;
			EventBinding.RaiseCustomEvent("MouseUp", ref paramsArray);
		}

		#endregion
	}
	
}

