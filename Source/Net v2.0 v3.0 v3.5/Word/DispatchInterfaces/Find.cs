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
	/// DispatchInterface Find SupportByLibrary "Word", 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Find : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Find()
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
		public bool Forward
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Forward", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Forward", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.WordApi.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Font;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Found
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Found", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchAllWordForms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchAllWordForms", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchAllWordForms", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchCase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchCase", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchCase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchWildcards
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchWildcards", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchWildcards", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchSoundsLike
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchSoundsLike", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchSoundsLike", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchWholeWord
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchWholeWord", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchWholeWord", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchFuzzy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchFuzzy", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchFuzzy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchByte
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchByte", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchByte", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.ParagraphFormat ParagraphFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParagraphFormat", paramsArray);
				NetOffice.WordApi.ParagraphFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ParagraphFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ParagraphFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageID", paramsArray);
				return (NetOffice.WordApi.Enums.WdLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Highlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Highlight", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Highlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Replacement Replacement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Replacement", paramsArray);
				NetOffice.WordApi.Replacement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Replacement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Frame Frame
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Frame", paramsArray);
				NetOffice.WordApi.Frame newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Frame;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdFindWrap Wrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Wrap", paramsArray);
				return (NetOffice.WordApi.Enums.WdFindWrap)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Wrap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageIDFarEast
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageIDFarEast", paramsArray);
				return (NetOffice.WordApi.Enums.WdLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageIDFarEast", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdLanguageID LanguageIDOther
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageIDOther", paramsArray);
				return (NetOffice.WordApi.Enums.WdLanguageID)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LanguageIDOther", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool CorrectHangulEndings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CorrectHangulEndings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CorrectHangulEndings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 NoProofing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoProofing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NoProofing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchKashida
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchKashida", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchKashida", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchDiacritics
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchDiacritics", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchDiacritics", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchAlefHamza
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchAlefHamza", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchAlefHamza", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MatchControl
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchControl", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchControl", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool MatchPhrase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchPhrase", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchPhrase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool MatchPrefix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchPrefix", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchPrefix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool MatchSuffix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchSuffix", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchSuffix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool IgnoreSpace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IgnoreSpace", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IgnoreSpace", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool IgnorePunct
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IgnorePunct", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IgnorePunct", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool HanjaPhoneticHangul
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HanjaPhoneticHangul", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HanjaPhoneticHangul", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FindText">ref optional object FindText</param>
		/// <param name="MatchCase">ref optional object MatchCase</param>
		/// <param name="MatchWholeWord">ref optional object MatchWholeWord</param>
		/// <param name="MatchWildcards">ref optional object MatchWildcards</param>
		/// <param name="MatchSoundsLike">ref optional object MatchSoundsLike</param>
		/// <param name="MatchAllWordForms">ref optional object MatchAllWordForms</param>
		/// <param name="Forward">ref optional object Forward</param>
		/// <param name="Wrap">ref optional object Wrap</param>
		/// <param name="Format">ref optional object Format</param>
		/// <param name="ReplaceWith">ref optional object ReplaceWith</param>
		/// <param name="Replace">ref optional object Replace</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ExecuteOld(ref object findText, ref object matchCase, ref object matchWholeWord, ref object matchWildcards, ref object matchSoundsLike, ref object matchAllWordForms, ref object forward, ref object wrap, ref object format, ref object replaceWith, ref object replace)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace);
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			findText = (object)paramsArray[0];
			matchCase = (object)paramsArray[1];
			matchWholeWord = (object)paramsArray[2];
			matchWildcards = (object)paramsArray[3];
			matchSoundsLike = (object)paramsArray[4];
			matchAllWordForms = (object)paramsArray[5];
			forward = (object)paramsArray[6];
			wrap = (object)paramsArray[7];
			format = (object)paramsArray[8];
			replaceWith = (object)paramsArray[9];
			replace = (object)paramsArray[10];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ExecuteOld()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ExecuteOld", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ClearFormatting()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearFormatting", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void SetAllFuzzyOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetAllFuzzyOptions", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ClearAllFuzzyOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ClearAllFuzzyOptions", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		/// <param name="FindText">ref optional object FindText</param>
		/// <param name="MatchCase">ref optional object MatchCase</param>
		/// <param name="MatchWholeWord">ref optional object MatchWholeWord</param>
		/// <param name="MatchWildcards">ref optional object MatchWildcards</param>
		/// <param name="MatchSoundsLike">ref optional object MatchSoundsLike</param>
		/// <param name="MatchAllWordForms">ref optional object MatchAllWordForms</param>
		/// <param name="Forward">ref optional object Forward</param>
		/// <param name="Wrap">ref optional object Wrap</param>
		/// <param name="Format">ref optional object Format</param>
		/// <param name="ReplaceWith">ref optional object ReplaceWith</param>
		/// <param name="Replace">ref optional object Replace</param>
		/// <param name="MatchKashida">ref optional object MatchKashida</param>
		/// <param name="MatchDiacritics">ref optional object MatchDiacritics</param>
		/// <param name="MatchAlefHamza">ref optional object MatchAlefHamza</param>
		/// <param name="MatchControl">ref optional object MatchControl</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Execute(ref object findText, ref object matchCase, ref object matchWholeWord, ref object matchWildcards, ref object matchSoundsLike, ref object matchAllWordForms, ref object forward, ref object wrap, ref object format, ref object replaceWith, ref object replace, ref object matchKashida, ref object matchDiacritics, ref object matchAlefHamza, ref object matchControl)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			findText = (object)paramsArray[0];
			matchCase = (object)paramsArray[1];
			matchWholeWord = (object)paramsArray[2];
			matchWildcards = (object)paramsArray[3];
			matchSoundsLike = (object)paramsArray[4];
			matchAllWordForms = (object)paramsArray[5];
			forward = (object)paramsArray[6];
			wrap = (object)paramsArray[7];
			format = (object)paramsArray[8];
			replaceWith = (object)paramsArray[9];
			replace = (object)paramsArray[10];
			matchKashida = (object)paramsArray[11];
			matchDiacritics = (object)paramsArray[12];
			matchAlefHamza = (object)paramsArray[13];
			matchControl = (object)paramsArray[14];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 9 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Execute()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="FindText">ref object FindText</param>
		/// <param name="HighlightColor">ref optional object HighlightColor</param>
		/// <param name="TextColor">ref optional object TextColor</param>
		/// <param name="MatchCase">ref optional object MatchCase</param>
		/// <param name="MatchWholeWord">ref optional object MatchWholeWord</param>
		/// <param name="MatchPrefix">ref optional object MatchPrefix</param>
		/// <param name="MatchSuffix">ref optional object MatchSuffix</param>
		/// <param name="MatchPhrase">ref optional object MatchPhrase</param>
		/// <param name="MatchWildcards">ref optional object MatchWildcards</param>
		/// <param name="MatchSoundsLike">ref optional object MatchSoundsLike</param>
		/// <param name="MatchAllWordForms">ref optional object MatchAllWordForms</param>
		/// <param name="MatchByte">ref optional object MatchByte</param>
		/// <param name="MatchFuzzy">ref optional object MatchFuzzy</param>
		/// <param name="MatchKashida">ref optional object MatchKashida</param>
		/// <param name="MatchDiacritics">ref optional object MatchDiacritics</param>
		/// <param name="MatchAlefHamza">ref optional object MatchAlefHamza</param>
		/// <param name="MatchControl">ref optional object MatchControl</param>
		/// <param name="IgnoreSpace">ref optional object IgnoreSpace</param>
		/// <param name="IgnorePunct">ref optional object IgnorePunct</param>
		/// <param name="HanjaPhoneticHangul">ref optional object HanjaPhoneticHangul</param>
		[SupportByLibrary("Word", 12,14)]
		public bool HitHighlight(ref object findText, ref object highlightColor, ref object textColor, ref object matchCase, ref object matchWholeWord, ref object matchPrefix, ref object matchSuffix, ref object matchPhrase, ref object matchWildcards, ref object matchSoundsLike, ref object matchAllWordForms, ref object matchByte, ref object matchFuzzy, ref object matchKashida, ref object matchDiacritics, ref object matchAlefHamza, ref object matchControl, ref object ignoreSpace, ref object ignorePunct, ref object hanjaPhoneticHangul)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(findText, highlightColor, textColor, matchCase, matchWholeWord, matchPrefix, matchSuffix, matchPhrase, matchWildcards, matchSoundsLike, matchAllWordForms, matchByte, matchFuzzy, matchKashida, matchDiacritics, matchAlefHamza, matchControl, ignoreSpace, ignorePunct, hanjaPhoneticHangul);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			findText = (object)paramsArray[0];
			highlightColor = (object)paramsArray[1];
			textColor = (object)paramsArray[2];
			matchCase = (object)paramsArray[3];
			matchWholeWord = (object)paramsArray[4];
			matchPrefix = (object)paramsArray[5];
			matchSuffix = (object)paramsArray[6];
			matchPhrase = (object)paramsArray[7];
			matchWildcards = (object)paramsArray[8];
			matchSoundsLike = (object)paramsArray[9];
			matchAllWordForms = (object)paramsArray[10];
			matchByte = (object)paramsArray[11];
			matchFuzzy = (object)paramsArray[12];
			matchKashida = (object)paramsArray[13];
			matchDiacritics = (object)paramsArray[14];
			matchAlefHamza = (object)paramsArray[15];
			matchControl = (object)paramsArray[16];
			ignoreSpace = (object)paramsArray[17];
			ignorePunct = (object)paramsArray[18];
			hanjaPhoneticHangul = (object)paramsArray[19];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="FindText">ref object FindText</param>
		[SupportByLibrary("Word", 12,14)]
		public bool HitHighlight(ref object findText)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(findText);
			object returnItem = Invoker.MethodReturn(this, "HitHighlight", paramsArray);
			findText = (object)paramsArray[0];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ClearHitHighlight()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearHitHighlight", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="FindText">ref optional object FindText</param>
		/// <param name="MatchCase">ref optional object MatchCase</param>
		/// <param name="MatchWholeWord">ref optional object MatchWholeWord</param>
		/// <param name="MatchWildcards">ref optional object MatchWildcards</param>
		/// <param name="MatchSoundsLike">ref optional object MatchSoundsLike</param>
		/// <param name="MatchAllWordForms">ref optional object MatchAllWordForms</param>
		/// <param name="Forward">ref optional object Forward</param>
		/// <param name="Wrap">ref optional object Wrap</param>
		/// <param name="Format">ref optional object Format</param>
		/// <param name="ReplaceWith">ref optional object ReplaceWith</param>
		/// <param name="Replace">ref optional object Replace</param>
		/// <param name="MatchKashida">ref optional object MatchKashida</param>
		/// <param name="MatchDiacritics">ref optional object MatchDiacritics</param>
		/// <param name="MatchAlefHamza">ref optional object MatchAlefHamza</param>
		/// <param name="MatchControl">ref optional object MatchControl</param>
		/// <param name="MatchPrefix">ref optional object MatchPrefix</param>
		/// <param name="MatchSuffix">ref optional object MatchSuffix</param>
		/// <param name="MatchPhrase">ref optional object MatchPhrase</param>
		/// <param name="IgnoreSpace">ref optional object IgnoreSpace</param>
		/// <param name="IgnorePunct">ref optional object IgnorePunct</param>
		[SupportByLibrary("Word", 12,14)]
		public bool Execute2007(ref object findText, ref object matchCase, ref object matchWholeWord, ref object matchWildcards, ref object matchSoundsLike, ref object matchAllWordForms, ref object forward, ref object wrap, ref object format, ref object replaceWith, ref object replace, ref object matchKashida, ref object matchDiacritics, ref object matchAlefHamza, ref object matchControl, ref object matchPrefix, ref object matchSuffix, ref object matchPhrase, ref object ignoreSpace, ref object ignorePunct)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(findText, matchCase, matchWholeWord, matchWildcards, matchSoundsLike, matchAllWordForms, forward, wrap, format, replaceWith, replace, matchKashida, matchDiacritics, matchAlefHamza, matchControl, matchPrefix, matchSuffix, matchPhrase, ignoreSpace, ignorePunct);
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			findText = (object)paramsArray[0];
			matchCase = (object)paramsArray[1];
			matchWholeWord = (object)paramsArray[2];
			matchWildcards = (object)paramsArray[3];
			matchSoundsLike = (object)paramsArray[4];
			matchAllWordForms = (object)paramsArray[5];
			forward = (object)paramsArray[6];
			wrap = (object)paramsArray[7];
			format = (object)paramsArray[8];
			replaceWith = (object)paramsArray[9];
			replace = (object)paramsArray[10];
			matchKashida = (object)paramsArray[11];
			matchDiacritics = (object)paramsArray[12];
			matchAlefHamza = (object)paramsArray[13];
			matchControl = (object)paramsArray[14];
			matchPrefix = (object)paramsArray[15];
			matchSuffix = (object)paramsArray[16];
			matchPhrase = (object)paramsArray[17];
			ignoreSpace = (object)paramsArray[18];
			ignorePunct = (object)paramsArray[19];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool Execute2007()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Execute2007", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}