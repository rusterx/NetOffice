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
	/// DispatchInterface Indexes SupportByLibrary "Word", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Indexes : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes()
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
		public NetOffice.WordApi.Enums.WdIndexFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (NetOffice.WordApi.Enums.WdIndexFormat)returnItem;
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
		public NetOffice.WordApi.Index this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="HeadingSeparator">ref optional object HeadingSeparator</param>
		/// <param name="RightAlignPageNumbers">ref optional object RightAlignPageNumbers</param>
		/// <param name="Type">ref optional object Type</param>
		/// <param name="NumberOfColumns">ref optional object NumberOfColumns</param>
		/// <param name="AccentedLetters">ref optional object AccentedLetters</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index AddOld(NetOffice.WordApi.Range range, ref object headingSeparator, ref object rightAlignPageNumbers, ref object type, ref object numberOfColumns, ref object accentedLetters)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, headingSeparator, rightAlignPageNumbers, type, numberOfColumns, accentedLetters);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray, modifiers);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			headingSeparator = (object)paramsArray[1];
			rightAlignPageNumbers = (object)paramsArray[2];
			type = (object)paramsArray[3];
			numberOfColumns = (object)paramsArray[4];
			accentedLetters = (object)paramsArray[5];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index AddOld(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Entry">ref optional object Entry</param>
		/// <param name="EntryAutoText">ref optional object EntryAutoText</param>
		/// <param name="CrossReference">ref optional object CrossReference</param>
		/// <param name="CrossReferenceAutoText">ref optional object CrossReferenceAutoText</param>
		/// <param name="BookmarkName">ref optional object BookmarkName</param>
		/// <param name="Bold">ref optional object Bold</param>
		/// <param name="Italic">ref optional object Italic</param>
		/// <param name="Reading">ref optional object Reading</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, ref object entry, ref object entryAutoText, ref object crossReference, ref object crossReferenceAutoText, ref object bookmarkName, ref object bold, ref object italic, ref object reading)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, crossReference, crossReferenceAutoText, bookmarkName, bold, italic, reading);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray, modifiers);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			entry = (object)paramsArray[1];
			entryAutoText = (object)paramsArray[2];
			crossReference = (object)paramsArray[3];
			crossReferenceAutoText = (object)paramsArray[4];
			bookmarkName = (object)paramsArray[5];
			bold = (object)paramsArray[6];
			italic = (object)paramsArray[7];
			reading = (object)paramsArray[8];
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
		/// <param name="Entry">ref optional object Entry</param>
		/// <param name="EntryAutoText">ref optional object EntryAutoText</param>
		/// <param name="CrossReference">ref optional object CrossReference</param>
		/// <param name="CrossReferenceAutoText">ref optional object CrossReferenceAutoText</param>
		/// <param name="BookmarkName">ref optional object BookmarkName</param>
		/// <param name="Bold">ref optional object Bold</param>
		/// <param name="Italic">ref optional object Italic</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllEntries(NetOffice.WordApi.Range range, ref object entry, ref object entryAutoText, ref object crossReference, ref object crossReferenceAutoText, ref object bookmarkName, ref object bold, ref object italic)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, crossReference, crossReferenceAutoText, bookmarkName, bold, italic);
			Invoker.Method(this, "MarkAllEntries", paramsArray, modifiers);
			entry = (object)paramsArray[1];
			entryAutoText = (object)paramsArray[2];
			crossReference = (object)paramsArray[3];
			crossReferenceAutoText = (object)paramsArray[4];
			bookmarkName = (object)paramsArray[5];
			bold = (object)paramsArray[6];
			italic = (object)paramsArray[7];
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllEntries(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "MarkAllEntries", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="ConcordanceFileName">string ConcordanceFileName</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void AutoMarkEntries(string concordanceFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(concordanceFileName);
			Invoker.Method(this, "AutoMarkEntries", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="HeadingSeparator">ref optional object HeadingSeparator</param>
		/// <param name="RightAlignPageNumbers">ref optional object RightAlignPageNumbers</param>
		/// <param name="Type">ref optional object Type</param>
		/// <param name="NumberOfColumns">ref optional object NumberOfColumns</param>
		/// <param name="AccentedLetters">ref optional object AccentedLetters</param>
		/// <param name="SortBy">ref optional object SortBy</param>
		/// <param name="IndexLanguage">ref optional object IndexLanguage</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index Add(NetOffice.WordApi.Range range, ref object headingSeparator, ref object rightAlignPageNumbers, ref object type, ref object numberOfColumns, ref object accentedLetters, ref object sortBy, ref object indexLanguage)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, headingSeparator, rightAlignPageNumbers, type, numberOfColumns, accentedLetters, sortBy, indexLanguage);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			headingSeparator = (object)paramsArray[1];
			rightAlignPageNumbers = (object)paramsArray[2];
			type = (object)paramsArray[3];
			numberOfColumns = (object)paramsArray[4];
			accentedLetters = (object)paramsArray[5];
			sortBy = (object)paramsArray[6];
			indexLanguage = (object)paramsArray[7];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
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