﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.PowerPointApi;

namespace NetOffice.PowerPointApi.Behind
{
	/// <summary>
	/// DispatchInterface _Slide 
	/// SupportByVersion PowerPoint, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), BaseType]
 	public class _Slide : COMObject, NetOffice.PowerPointApi._Slide
	{
		#pragma warning disable

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
                    _contractType = typeof(NetOffice.PowerPointApi._Slide);
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

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Slide);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _Slide() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746682.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Application>(this, "Application", typeof(NetOffice.PowerPointApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff743863.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745594.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Shapes Shapes
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Shapes>(this, "Shapes", typeof(NetOffice.PowerPointApi.Shapes));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745667.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.HeadersFooters HeadersFooters
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.HeadersFooters>(this, "HeadersFooters", typeof(NetOffice.PowerPointApi.HeadersFooters));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746096.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.SlideShowTransition SlideShowTransition
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.SlideShowTransition>(this, "SlideShowTransition", typeof(NetOffice.PowerPointApi.SlideShowTransition));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744626.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ColorScheme ColorScheme
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.ColorScheme>(this, "ColorScheme", typeof(NetOffice.PowerPointApi.ColorScheme));
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "ColorScheme", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745541.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.ShapeRange Background
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.ShapeRange>(this, "Background", typeof(NetOffice.PowerPointApi.ShapeRange));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744041.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public string Name
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745767.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 SlideID
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "SlideID");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746006.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 PrintSteps
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "PrintSteps");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745137.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Enums.PpSlideLayout Layout
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.PowerPointApi.Enums.PpSlideLayout>(this, "Layout");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Layout", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744290.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Tags Tags
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Tags>(this, "Tags", typeof(NetOffice.PowerPointApi.Tags));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745524.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 SlideIndex
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "SlideIndex");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745198.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public Int32 SlideNumber
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "SlideNumber");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745734.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState DisplayMasterShapes
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "DisplayMasterShapes");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "DisplayMasterShapes", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744255.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState FollowMasterBackground
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "FollowMasterBackground");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "FollowMasterBackground", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745577.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.SlideRange NotesPage
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.SlideRange>(this, "NotesPage", typeof(NetOffice.PowerPointApi.SlideRange));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746300.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		[BaseResult]
		public NetOffice.PowerPointApi._Master Master
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBaseReferencePropertyGet<NetOffice.PowerPointApi._Master>(this, "Master");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744004.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Hyperlinks Hyperlinks
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Hyperlinks>(this, "Hyperlinks", typeof(NetOffice.PowerPointApi.Hyperlinks));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Scripts Scripts
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.Scripts>(this, "Scripts", typeof(NetOffice.OfficeApi.Scripts));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744578.aspx </remarks>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Comments Comments
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Comments>(this, "Comments", typeof(NetOffice.PowerPointApi.Comments));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746079.aspx </remarks>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.Design Design
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.Design>(this, "Design", typeof(NetOffice.PowerPointApi.Design));
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "Design", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745382.aspx </remarks>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.TimeLine TimeLine
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.TimeLine>(this, "TimeLine", typeof(NetOffice.PowerPointApi.TimeLine));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public Int32 SectionNumber
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "SectionNumber");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff743997.aspx </remarks>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public NetOffice.PowerPointApi.CustomLayout CustomLayout
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.CustomLayout>(this, "CustomLayout", typeof(NetOffice.PowerPointApi.CustomLayout));
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "CustomLayout", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745904.aspx </remarks>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.ThemeColorScheme ThemeColorScheme
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ThemeColorScheme>(this, "ThemeColorScheme", typeof(NetOffice.OfficeApi.ThemeColorScheme));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745019.aspx </remarks>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex BackgroundStyle
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoBackgroundStyleIndex>(this, "BackgroundStyle");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "BackgroundStyle", value);
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744791.aspx </remarks>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public NetOffice.PowerPointApi.CustomerData CustomerData
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.PowerPointApi.CustomerData>(this, "CustomerData", typeof(NetOffice.PowerPointApi.CustomerData));
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744800.aspx </remarks>
		[SupportByVersion("PowerPoint", 14,15,16)]
		public Int32 sectionIndex
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "sectionIndex");
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744983.aspx </remarks>
		[SupportByVersion("PowerPoint", 14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasNotesPage
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "HasNotesPage");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745571.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Select()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Select");
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff743868.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Cut()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Cut");
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744537.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Copy()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Copy");
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745804.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public NetOffice.PowerPointApi.SlideRange Duplicate()
		{
			return InvokerService.InvokeInternal.ExecuteKnownReferenceMethodGet<NetOffice.PowerPointApi.SlideRange>(this, "Duplicate", typeof(NetOffice.PowerPointApi.SlideRange));
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744142.aspx </remarks>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Delete()
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746030.aspx </remarks>
		/// <param name="fileName">string fileName</param>
		/// <param name="filterName">string filterName</param>
		/// <param name="scaleWidth">optional Int32 ScaleWidth = 0</param>
		/// <param name="scaleHeight">optional Int32 ScaleHeight = 0</param>
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string fileName, string filterName, object scaleWidth, object scaleHeight)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Export", fileName, filterName, scaleWidth, scaleHeight);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746030.aspx </remarks>
		/// <param name="fileName">string fileName</param>
		/// <param name="filterName">string filterName</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string fileName, string filterName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Export", fileName, filterName);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746030.aspx </remarks>
		/// <param name="fileName">string fileName</param>
		/// <param name="filterName">string filterName</param>
		/// <param name="scaleWidth">optional Int32 ScaleWidth = 0</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 9,10,11,12,14,15,16)]
		public void Export(string fileName, string filterName, object scaleWidth)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "Export", fileName, filterName, scaleWidth);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745962.aspx </remarks>
		/// <param name="toPos">Int32 toPos</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public void MoveTo(Int32 toPos)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "MoveTo", toPos);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff746644.aspx </remarks>
		/// <param name="fileName">string fileName</param>
		[SupportByVersion("PowerPoint", 10,11,12,14,15,16)]
		public void ApplyTemplate(string fileName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "ApplyTemplate", fileName);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745232.aspx </remarks>
		/// <param name="themeName">string themeName</param>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public void ApplyTheme(string themeName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "ApplyTheme", themeName);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff744388.aspx </remarks>
		/// <param name="themeColorSchemeName">string themeColorSchemeName</param>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public void ApplyThemeColorScheme(string themeColorSchemeName)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "ApplyThemeColorScheme", themeColorSchemeName);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745310.aspx </remarks>
		/// <param name="slideLibraryUrl">string slideLibraryUrl</param>
		/// <param name="overwrite">optional bool Overwrite = false</param>
		/// <param name="useSlideOrder">optional bool UseSlideOrder = false</param>
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public void PublishSlides(string slideLibraryUrl, object overwrite, object useSlideOrder)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "PublishSlides", slideLibraryUrl, overwrite, useSlideOrder);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745310.aspx </remarks>
		/// <param name="slideLibraryUrl">string slideLibraryUrl</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public void PublishSlides(string slideLibraryUrl)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "PublishSlides", slideLibraryUrl);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745310.aspx </remarks>
		/// <param name="slideLibraryUrl">string slideLibraryUrl</param>
		/// <param name="overwrite">optional bool Overwrite = false</param>
		[CustomMethod]
		[SupportByVersion("PowerPoint", 12,14,15,16)]
		public void PublishSlides(string slideLibraryUrl, object overwrite)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "PublishSlides", slideLibraryUrl, overwrite);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff745283.aspx </remarks>
		/// <param name="toSection">Int32 toSection</param>
		[SupportByVersion("PowerPoint", 14,15,16)]
		public void MoveToSectionStart(Int32 toSection)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "MoveToSectionStart", toSection);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 15,16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230161.aspx </remarks>
		/// <param name="fileName">string fileName</param>
		/// <param name="variant">string variant</param>
		[SupportByVersion("PowerPoint", 15, 16)]
		public void ApplyTemplate2(string fileName, string variant)
		{
			 InvokerService.InvokeInternal.ExecuteMethod(this, "ApplyTemplate2", fileName, variant);
		}

		#endregion

		#pragma warning restore
	}
}


