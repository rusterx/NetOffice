//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface DataLabels SupportByLibrary "PowerPoint", 14
	///</summary>
	[SupportByLibrary("PowerPoint", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DataLabels : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataLabels(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataLabels(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataLabels(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataLabels()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
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
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ChartBorder Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				NetOffice.PowerPointApi.ChartBorder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ChartBorder;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Interior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				NetOffice.PowerPointApi.Interior newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Interior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ChartFillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.PowerPointApi.ChartFillFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ChartFillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ChartFont Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				NetOffice.PowerPointApi.ChartFont newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ChartFont;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object HorizontalAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalAlignment", paramsArray);
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
				Invoker.PropertySet(this, "HorizontalAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
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
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object VerticalAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalAlignment", paramsArray);
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
				Invoker.PropertySet(this, "VerticalAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public Int32 ReadingOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingOrder", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object AutoScaleFont
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoScaleFont", paramsArray);
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
				Invoker.PropertySet(this, "AutoScaleFont", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool AutoText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoText", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public string NumberFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberFormat", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool NumberFormatLinked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberFormatLinked", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NumberFormatLinked", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object NumberFormatLocal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NumberFormatLocal", paramsArray);
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
				Invoker.PropertySet(this, "NumberFormatLocal", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowLegendKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowLegendKey", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowLegendKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
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
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Enums.XlDataLabelPosition Position
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Position", paramsArray);
				return (NetOffice.PowerPointApi.Enums.XlDataLabelPosition)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Position", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowSeriesName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSeriesName", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSeriesName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowCategoryName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowCategoryName", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowCategoryName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowValue", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowPercentage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowPercentage", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowPercentage", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public bool ShowBubbleSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowBubbleSize", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowBubbleSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object Separator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Separator", paramsArray);
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
				Invoker.PropertySet(this, "Separator", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
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
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.ChartFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				NetOffice.PowerPointApi.ChartFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ChartFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
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
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object Select()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Select", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		[SupportByLibrary("PowerPoint", 14)]
		public object Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("PowerPoint", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.DataLabel this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.DataLabel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DataLabel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("PowerPoint", 14)]
		public NetOffice.PowerPointApi.DataLabel _Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.PowerPointApi.DataLabel newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.DataLabel;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("PowerPoint", 14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
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