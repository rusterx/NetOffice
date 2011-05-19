//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Table SupportByLibrary "Word", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Table : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Table()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

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
		public NetOffice.WordApi.Columns Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				NetOffice.WordApi.Columns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Columns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Rows Rows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rows", paramsArray);
				NetOffice.WordApi.Rows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Rows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				NetOffice.WordApi.Borders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Borders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Borders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Shading Shading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shading", paramsArray);
				NetOffice.WordApi.Shading newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Shading;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Uniform
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Uniform", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 AutoFormatType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFormatType", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Tables Tables
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Tables", paramsArray);
				NetOffice.WordApi.Tables newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Tables;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 NestingLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NestingLevel", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool AllowPageBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowPageBreaks", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowPageBreaks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool AllowAutoFit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowAutoFit", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowAutoFit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single PreferredWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreferredWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreferredWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdPreferredWidthType PreferredWidthType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreferredWidthType", paramsArray);
				return (NetOffice.WordApi.Enums.WdPreferredWidthType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreferredWidthType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single TopPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopPadding", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TopPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single BottomPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BottomPadding", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BottomPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single LeftPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftPadding", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single RightPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightPadding", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Single Spacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Spacing", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Spacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdTableDirection TableDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableDirection", paramsArray);
				return (NetOffice.WordApi.Enums.WdTableDirection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public object Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ApplyStyleHeadingRows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleHeadingRows", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleHeadingRows", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ApplyStyleLastRow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleLastRow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleLastRow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ApplyStyleFirstColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleFirstColumn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleFirstColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ApplyStyleLastColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleLastColumn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleLastColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ApplyStyleRowBands
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleRowBands", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleRowBands", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ApplyStyleColumnBands
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ApplyStyleColumnBands", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ApplyStyleColumnBands", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public string Descr
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Descr", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Descr", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="ExcludeHeader">ref optional object ExcludeHeader</param>
		/// <param name="FieldNumber">ref optional object FieldNumber</param>
		/// <param name="SortFieldType">ref optional object SortFieldType</param>
		/// <param name="SortOrder">ref optional object SortOrder</param>
		/// <param name="FieldNumber2">ref optional object FieldNumber2</param>
		/// <param name="SortFieldType2">ref optional object SortFieldType2</param>
		/// <param name="SortOrder2">ref optional object SortOrder2</param>
		/// <param name="FieldNumber3">ref optional object FieldNumber3</param>
		/// <param name="SortFieldType3">ref optional object SortFieldType3</param>
		/// <param name="SortOrder3">ref optional object SortOrder3</param>
		/// <param name="CaseSensitive">ref optional object CaseSensitive</param>
		/// <param name="LanguageID">ref optional object LanguageID</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SortOld(ref object excludeHeader, ref object fieldNumber, ref object sortFieldType, ref object sortOrder, ref object fieldNumber2, ref object sortFieldType2, ref object sortOrder2, ref object fieldNumber3, ref object sortFieldType3, ref object sortOrder3, ref object caseSensitive, ref object languageID)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(excludeHeader, fieldNumber, sortFieldType, sortOrder, fieldNumber2, sortFieldType2, sortOrder2, fieldNumber3, sortFieldType3, sortOrder3, caseSensitive, languageID);
			Invoker.Method(this, "SortOld", paramsArray, modifiers);
			excludeHeader = (object)paramsArray[0];
			fieldNumber = (object)paramsArray[1];
			sortFieldType = (object)paramsArray[2];
			sortOrder = (object)paramsArray[3];
			fieldNumber2 = (object)paramsArray[4];
			sortFieldType2 = (object)paramsArray[5];
			sortOrder2 = (object)paramsArray[6];
			fieldNumber3 = (object)paramsArray[7];
			sortFieldType3 = (object)paramsArray[8];
			sortOrder3 = (object)paramsArray[9];
			caseSensitive = (object)paramsArray[10];
			languageID = (object)paramsArray[11];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SortOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SortOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SortAscending()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SortAscending", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SortDescending()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SortDescending", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Format">ref optional object Format</param>
		/// <param name="ApplyBorders">ref optional object ApplyBorders</param>
		/// <param name="ApplyShading">ref optional object ApplyShading</param>
		/// <param name="ApplyFont">ref optional object ApplyFont</param>
		/// <param name="ApplyColor">ref optional object ApplyColor</param>
		/// <param name="ApplyHeadingRows">ref optional object ApplyHeadingRows</param>
		/// <param name="ApplyLastRow">ref optional object ApplyLastRow</param>
		/// <param name="ApplyFirstColumn">ref optional object ApplyFirstColumn</param>
		/// <param name="ApplyLastColumn">ref optional object ApplyLastColumn</param>
		/// <param name="AutoFit">ref optional object AutoFit</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void AutoFormat(ref object format, ref object applyBorders, ref object applyShading, ref object applyFont, ref object applyColor, ref object applyHeadingRows, ref object applyLastRow, ref object applyFirstColumn, ref object applyLastColumn, ref object autoFit)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(format, applyBorders, applyShading, applyFont, applyColor, applyHeadingRows, applyLastRow, applyFirstColumn, applyLastColumn, autoFit);
			Invoker.Method(this, "AutoFormat", paramsArray, modifiers);
			format = (object)paramsArray[0];
			applyBorders = (object)paramsArray[1];
			applyShading = (object)paramsArray[2];
			applyFont = (object)paramsArray[3];
			applyColor = (object)paramsArray[4];
			applyHeadingRows = (object)paramsArray[5];
			applyLastRow = (object)paramsArray[6];
			applyFirstColumn = (object)paramsArray[7];
			applyLastColumn = (object)paramsArray[8];
			autoFit = (object)paramsArray[9];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void AutoFormat()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AutoFormat", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void UpdateAutoFormat()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdateAutoFormat", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Separator">ref optional object Separator</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ConvertToTextOld(ref object separator)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(separator);
			object returnItem = Invoker.MethodReturn(this, "ConvertToTextOld", paramsArray, modifiers);
			NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Range;
			separator = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ConvertToTextOld()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ConvertToTextOld", paramsArray);
			NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Row">Int32 Row</param>
		/// <param name="Column">Int32 Column</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Cell Cell(Int32 row, Int32 column)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, column);
			object returnItem = Invoker.MethodReturn(this, "Cell", paramsArray);
			NetOffice.WordApi.Cell newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Cell;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="BeforeRow">ref object BeforeRow</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Table Split(ref object beforeRow)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(beforeRow);
			object returnItem = Invoker.MethodReturn(this, "Split", paramsArray, modifiers);
			NetOffice.WordApi.Table newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Table;
			beforeRow = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Separator">ref optional object Separator</param>
		/// <param name="NestedTables">ref optional object NestedTables</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ConvertToText(ref object separator, ref object nestedTables)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(separator, nestedTables);
			object returnItem = Invoker.MethodReturn(this, "ConvertToText", paramsArray, modifiers);
			NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Range;
			separator = (object)paramsArray[0];
			nestedTables = (object)paramsArray[1];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Range ConvertToText()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ConvertToText", paramsArray);
			NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Behavior">NetOffice.WordApi.Enums.WdAutoFitBehavior Behavior</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void AutoFitBehavior(NetOffice.WordApi.Enums.WdAutoFitBehavior behavior)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(behavior);
			Invoker.Method(this, "AutoFitBehavior", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="ExcludeHeader">ref optional object ExcludeHeader</param>
		/// <param name="FieldNumber">ref optional object FieldNumber</param>
		/// <param name="SortFieldType">ref optional object SortFieldType</param>
		/// <param name="SortOrder">ref optional object SortOrder</param>
		/// <param name="FieldNumber2">ref optional object FieldNumber2</param>
		/// <param name="SortFieldType2">ref optional object SortFieldType2</param>
		/// <param name="SortOrder2">ref optional object SortOrder2</param>
		/// <param name="FieldNumber3">ref optional object FieldNumber3</param>
		/// <param name="SortFieldType3">ref optional object SortFieldType3</param>
		/// <param name="SortOrder3">ref optional object SortOrder3</param>
		/// <param name="CaseSensitive">ref optional object CaseSensitive</param>
		/// <param name="BidiSort">ref optional object BidiSort</param>
		/// <param name="IgnoreThe">ref optional object IgnoreThe</param>
		/// <param name="IgnoreKashida">ref optional object IgnoreKashida</param>
		/// <param name="IgnoreDiacritics">ref optional object IgnoreDiacritics</param>
		/// <param name="IgnoreHe">ref optional object IgnoreHe</param>
		/// <param name="LanguageID">ref optional object LanguageID</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Sort(ref object excludeHeader, ref object fieldNumber, ref object sortFieldType, ref object sortOrder, ref object fieldNumber2, ref object sortFieldType2, ref object sortOrder2, ref object fieldNumber3, ref object sortFieldType3, ref object sortOrder3, ref object caseSensitive, ref object bidiSort, ref object ignoreThe, ref object ignoreKashida, ref object ignoreDiacritics, ref object ignoreHe, ref object languageID)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(excludeHeader, fieldNumber, sortFieldType, sortOrder, fieldNumber2, sortFieldType2, sortOrder2, fieldNumber3, sortFieldType3, sortOrder3, caseSensitive, bidiSort, ignoreThe, ignoreKashida, ignoreDiacritics, ignoreHe, languageID);
			Invoker.Method(this, "Sort", paramsArray, modifiers);
			excludeHeader = (object)paramsArray[0];
			fieldNumber = (object)paramsArray[1];
			sortFieldType = (object)paramsArray[2];
			sortOrder = (object)paramsArray[3];
			fieldNumber2 = (object)paramsArray[4];
			sortFieldType2 = (object)paramsArray[5];
			sortOrder2 = (object)paramsArray[6];
			fieldNumber3 = (object)paramsArray[7];
			sortFieldType3 = (object)paramsArray[8];
			sortOrder3 = (object)paramsArray[9];
			caseSensitive = (object)paramsArray[10];
			bidiSort = (object)paramsArray[11];
			ignoreThe = (object)paramsArray[12];
			ignoreKashida = (object)paramsArray[13];
			ignoreDiacritics = (object)paramsArray[14];
			ignoreHe = (object)paramsArray[15];
			languageID = (object)paramsArray[16];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void Sort()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Sort", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="StyleName">string StyleName</param>
		[SupportByLibrary("Word", 12,14)]
		public void ApplyStyleDirectFormatting(string styleName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(styleName);
			Invoker.Method(this, "ApplyStyleDirectFormatting", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}