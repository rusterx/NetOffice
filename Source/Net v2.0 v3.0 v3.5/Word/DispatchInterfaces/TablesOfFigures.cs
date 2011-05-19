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
	/// DispatchInterface TablesOfFigures SupportByLibrary "Word", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TablesOfFigures : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfFigures()
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

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdTofFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (NetOffice.WordApi.Enums.WdTofFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
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
		public NetOffice.WordApi.TableOfFigures this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.TableOfFigures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfFigures;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Caption">ref optional object Caption</param>
		/// <param name="IncludeLabel">ref optional object IncludeLabel</param>
		/// <param name="UseHeadingStyles">ref optional object UseHeadingStyles</param>
		/// <param name="UpperHeadingLevel">ref optional object UpperHeadingLevel</param>
		/// <param name="LowerHeadingLevel">ref optional object LowerHeadingLevel</param>
		/// <param name="UseFields">ref optional object UseFields</param>
		/// <param name="TableID">ref optional object TableID</param>
		/// <param name="RightAlignPageNumbers">ref optional object RightAlignPageNumbers</param>
		/// <param name="IncludePageNumbers">ref optional object IncludePageNumbers</param>
		/// <param name="AddedStyles">ref optional object AddedStyles</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range, ref object caption, ref object includeLabel, ref object useHeadingStyles, ref object upperHeadingLevel, ref object lowerHeadingLevel, ref object useFields, ref object tableID, ref object rightAlignPageNumbers, ref object includePageNumbers, ref object addedStyles)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray, modifiers);
			NetOffice.WordApi.TableOfFigures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfFigures;
			caption = (object)paramsArray[1];
			includeLabel = (object)paramsArray[2];
			useHeadingStyles = (object)paramsArray[3];
			upperHeadingLevel = (object)paramsArray[4];
			lowerHeadingLevel = (object)paramsArray[5];
			useFields = (object)paramsArray[6];
			tableID = (object)paramsArray[7];
			rightAlignPageNumbers = (object)paramsArray[8];
			includePageNumbers = (object)paramsArray[9];
			addedStyles = (object)paramsArray[10];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures AddOld(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfFigures;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Entry">ref optional object Entry</param>
		/// <param name="EntryAutoText">ref optional object EntryAutoText</param>
		/// <param name="TableID">ref optional object TableID</param>
		/// <param name="Level">ref optional object Level</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, ref object entry, ref object entryAutoText, ref object tableID, ref object level)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, tableID, level);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray, modifiers);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			entry = (object)paramsArray[1];
			entryAutoText = (object)paramsArray[2];
			tableID = (object)paramsArray[3];
			level = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Caption">ref optional object Caption</param>
		/// <param name="IncludeLabel">ref optional object IncludeLabel</param>
		/// <param name="UseHeadingStyles">ref optional object UseHeadingStyles</param>
		/// <param name="UpperHeadingLevel">ref optional object UpperHeadingLevel</param>
		/// <param name="LowerHeadingLevel">ref optional object LowerHeadingLevel</param>
		/// <param name="UseFields">ref optional object UseFields</param>
		/// <param name="TableID">ref optional object TableID</param>
		/// <param name="RightAlignPageNumbers">ref optional object RightAlignPageNumbers</param>
		/// <param name="IncludePageNumbers">ref optional object IncludePageNumbers</param>
		/// <param name="AddedStyles">ref optional object AddedStyles</param>
		/// <param name="UseHyperlinks">ref optional object UseHyperlinks</param>
		/// <param name="HidePageNumbersInWeb">ref optional object HidePageNumbersInWeb</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range, ref object caption, ref object includeLabel, ref object useHeadingStyles, ref object upperHeadingLevel, ref object lowerHeadingLevel, ref object useFields, ref object tableID, ref object rightAlignPageNumbers, ref object includePageNumbers, ref object addedStyles, ref object useHyperlinks, ref object hidePageNumbersInWeb)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, caption, includeLabel, useHeadingStyles, upperHeadingLevel, lowerHeadingLevel, useFields, tableID, rightAlignPageNumbers, includePageNumbers, addedStyles, useHyperlinks, hidePageNumbersInWeb);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.TableOfFigures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfFigures;
			caption = (object)paramsArray[1];
			includeLabel = (object)paramsArray[2];
			useHeadingStyles = (object)paramsArray[3];
			upperHeadingLevel = (object)paramsArray[4];
			lowerHeadingLevel = (object)paramsArray[5];
			useFields = (object)paramsArray[6];
			tableID = (object)paramsArray[7];
			rightAlignPageNumbers = (object)paramsArray[8];
			includePageNumbers = (object)paramsArray[9];
			addedStyles = (object)paramsArray[10];
			useHyperlinks = (object)paramsArray[11];
			hidePageNumbersInWeb = (object)paramsArray[12];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfFigures Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfFigures newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.TableOfFigures;
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