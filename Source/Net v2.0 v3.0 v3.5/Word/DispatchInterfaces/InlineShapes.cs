//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface InlineShapes SupportByLibrary "Word", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class InlineShapes : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShapes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShapes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShapes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShapes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.InlineShape this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="LinkToFile">ref optional object LinkToFile</param>
		/// <param name="SaveWithDocument">ref optional object SaveWithDocument</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddPicture(string fileName, ref object linkToFile, ref object saveWithDocument, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, range);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			linkToFile = (object)paramsArray[1];
			saveWithDocument = (object)paramsArray[2];
			range = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddPicture(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="ClassType">ref optional object ClassType</param>
		/// <param name="FileName">ref optional object FileName</param>
		/// <param name="LinkToFile">ref optional object LinkToFile</param>
		/// <param name="DisplayAsIcon">ref optional object DisplayAsIcon</param>
		/// <param name="IconFileName">ref optional object IconFileName</param>
		/// <param name="IconIndex">ref optional object IconIndex</param>
		/// <param name="IconLabel">ref optional object IconLabel</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddOLEObject(ref object classType, ref object fileName, ref object linkToFile, ref object displayAsIcon, ref object iconFileName, ref object iconIndex, ref object iconLabel, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(classType, fileName, linkToFile, displayAsIcon, iconFileName, iconIndex, iconLabel, range);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			classType = (object)paramsArray[0];
			fileName = (object)paramsArray[1];
			linkToFile = (object)paramsArray[2];
			displayAsIcon = (object)paramsArray[3];
			iconFileName = (object)paramsArray[4];
			iconIndex = (object)paramsArray[5];
			iconLabel = (object)paramsArray[6];
			range = (object)paramsArray[7];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddOLEObject()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="ClassType">ref optional object ClassType</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddOLEControl(ref object classType, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(classType, range);
			object returnItem = Invoker.MethodReturn(this, "AddOLEControl", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			classType = (object)paramsArray[0];
			range = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddOLEControl()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddOLEControl", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape New(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "New", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddHorizontalLine(string fileName, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, range);
			object returnItem = Invoker.MethodReturn(this, "AddHorizontalLine", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			range = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddHorizontalLine(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddHorizontalLine", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddHorizontalLineStandard(ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddHorizontalLineStandard", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			range = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddHorizontalLineStandard()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddHorizontalLineStandard", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddPictureBullet(string fileName, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, range);
			object returnItem = Invoker.MethodReturn(this, "AddPictureBullet", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			range = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.InlineShape AddPictureBullet(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddPictureBullet", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlChartType Type</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.InlineShape AddChart(NetOffice.OfficeApi.Enums.XlChartType type, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(type, range);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			range = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlChartType Type</param>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.InlineShape AddChart(NetOffice.OfficeApi.Enums.XlChartType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="Range">ref optional object Range</param>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.InlineShape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, ref object range)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(layout, range);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray, modifiers);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			range = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		[SupportByLibrary("Word", 14)]
		public NetOffice.WordApi.InlineShape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.InlineShape;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Word", 9,10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}