﻿using System;
using NetRuntimeSystem = System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Win32;
using System.ComponentModel;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Attributes;
using NetOffice.Tools;
using Visio = NetOffice.VisioApi;

namespace NetOffice.VisioApi.Tools
{
    /// <summary>
    /// NetOffice MS-Visio COM Addin
    /// </summary>
    public abstract class COMAddin : COMAddinBase, ICOMAddin
    {
        #region Fields

        /// <summary>
        /// MS-Visio Registry Path
        /// </summary>
        private static readonly string _addinOfficeRegistryKey  = "Software\\Microsoft\\Office\\Visio\\Addins\\";

        /// <summary>
        /// Instance factory to avoid trouble with addins in same appdomain
        /// </summary>
        private Core _factory;

        #endregion

        #region Ctor

        /// <summary>
        /// Creates an instance of the class
        /// </summary>
        public COMAddin()
        {
            _factory = RaiseCreateFactory();
            if (null == _factory)
                _factory = Core.Default;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Host Application Instance
        /// </summary>
        public Visio.Application Application { get; private set; }

        /// <summary>
        /// Custom addin object if created
        /// </summary>
        protected internal object CustomObject { get; private set; }

        /// <summary>
        /// Cached Error Method Delegate
        /// </summary>
        private MethodInfo ErrorMethod { get; set; }

		/// <summary>
        /// Cached Register Error Method Delegate
        /// </summary>
		private static MethodInfo RegisterErrorMethod { get; set; }

        #endregion

        #region COMAddinBase

        /// <summary>
        /// Generic Host Application Instance
        /// </summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override ICOMObject AppInstance
        {
            get { return Application; }
        }

        /// <summary>
        /// The used factory core
        /// </summary>
        public override Core Factory
        {
            get
            {
                return _factory;
            }
        }

        /// <summary>
        /// Returns an enumerable sequence with instance managed com objects on root level
        /// </summary>
        /// <returns>ICOMObject enumerator</returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        protected internal virtual IEnumerable<ICOMObject> OnCreateRoots()
        {
            List<ICOMObject> result = new List<ICOMObject>();
            result.Add(Application);

            return result.ToArray();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create the used factory. The method was called as first in the base ctor
        /// </summary>
        /// <returns>new Settings instance</returns>
        protected virtual Core CreateFactory()
        {
            Core core = new Core();
            ForceInitializeAttribute attribute = AttributeReflector.GetForceInitializeAttribute(Type);
            if (null != attribute)
            {
                core.Settings.EnableMoreDebugOutput = attribute.EnableMoreDebugOutput;
                core.CheckInitialize();
            }
            return core;
        }

        /// <summary>
        /// Returns an instance to publish them as addin custom object.
        /// External code like vba can access this object if instance is available as COM component.
        /// This object is available as Appplication.COMAddins(?).Object
        /// </summary>
        /// <returns>addin instance object or null(Nothing in Visual Basic)</returns>
        protected virtual object OnCreateObjectInstance()
        {
            return null;
        }

        /// <summary>
        /// Try to create a custom addin object instance
        /// </summary>
        /// <param name="addInInst">given instance from OnConnection event</param>
        private void TryCreateCustomObject(object addInInst)
        {
            try
            {
                CustomObject = OnCreateObjectInstance();
                if (null != CustomObject)
                {
                    object[] param = new object[1];
                    param[0] = CustomObject;
                    addInInst.GetType().InvokeMember("Object", NetRuntimeSystem.Reflection.BindingFlags.SetProperty, null, addInInst, param);
                }
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.CreateCustomAddinInstance, exception);
            }
        }

        /// <summary>
        /// Create the necessary factory and was called in the first line in base ctor
        /// </summary>
        /// <returns></returns>
        private Core RaiseCreateFactory()
        {
            try
            {
                return CreateFactory();
            }
            catch (NetRuntimeSystem.Exception exception)
            {
                NetOffice.DebugConsole.Default.WriteException(exception);
                OnError(ErrorMethodKind.CreateFactory, exception);
                return null;
            }
        }

        #endregion

        #region IDTExtensibility2 Events

        /// <summary>
        /// The OnStartupComplete event occurs when the host application completes its startup routines, in the case where the COM add-in loads at startup.
        /// If the add-in is not loaded when the application loads, the OnStartupComplete event does not occur —
        /// even when the user loads the add-in in the COM Add-ins dialog box. When this event does occur, it occurs after the OnConnection event.
        /// You can use the OnStartupComplete  event procedure to run code that interacts with the application and that should not be run until the application has finished loading.
        /// For example, if you want to display a form that gives users a choice of documents to create when they start the application,
        /// you can put that code in the OnStartupComplete event procedure.
        /// </summary>
        public event OnStartupCompleteEventHandler OnStartupComplete;

        /// <summary>
        /// The Shutdown event occurs when the COM add-in is unloaded.
        /// You can use the OnDisconnection event procedure to run code that restores any changes made to the application by the add-in and to perform general clean-up operations.
        /// An add-in can be unloaded in one of the following ways:
        /// - The user clears the check box next to the add-in in the COM Add-ins dialog box.
        /// - The host application closes. If the add-in is loaded when the application closes, it is unloaded.
        ///   If the add-in's load behavior is set to Startup, it is reloaded when the application starts again.
        /// - The Connect property of the corresponding COMAddIn object is set to False.
        /// </summary>
        public event OnDisconnectionEventHandler OnDisconnection;

        /// <summary>
        /// The OnConnection event occurs when the COM add-in is loaded (connected). An add-in can be loaded in one of the following ways:
        /// The user starts the host application and the add-in's load behavior is specified to load when the application starts.
        /// The user loads the add-in in the COM Add-ins dialog box.
        /// The Connect property of the corresponding COMAddIn object is set to True.
        /// For more information about the COMAddIn object, search the Microsoft® Office Visual Basic Reference Help index for "COMAddIn object."
        /// </summary>
        public event OnConnectionEventHandler OnConnection;

        /// <summary>
        /// The OnAddInsUpdate event occurs when the set of loaded COM add-ins changes.
        /// When an add-in is loaded or unloaded, the OnAddInsUpdate event occurs in any other loaded add-ins.
        /// For example, if add-ins A and B both are loaded currently, and then add-in C is loaded,
        /// the OnAddInsUpdate event occurs in add-ins A and B. If C is unloaded, the OnAddInsUpdate event occurs again in add-ins A and B.
        /// </summary>
        public event OnAddInsUpdateEventHandler OnAddInsUpdate;

        /// <summary>
        /// The OnBeginShutdown event occurs when the host application begins its shutdown routines,
        /// in the case where the application closes while the COM add-in is still loaded.
        /// If the add-in is not loaded when the application closes,
        /// the OnBeginShutdown event does not occur. When this event does occur, it occurs before the OnDisconnection event.
        /// You can use the OnBeginShutdown event procedure to run code when the user closes the application. For example, you can run code that saves form data to a file.
        /// </summary>
        public event OnBeginShutdownEventHandler OnBeginShutdown;

        /// <summary>
        /// Raise the OnStartupComplete event
        /// </summary>
        /// <param name="custom">custom arguments</param>
        protected internal virtual void RaiseOnStartupComplete(ref Array custom)
        {
            try
            {
                var handler = OnStartupComplete;
                if (null != handler)
                    handler(ref custom);
            }
            catch (NetRuntimeSystem.Exception exception)
            {
				Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnStartupComplete, exception);
            }
        }

        /// <summary>
        /// Raise the OnDisconnection event
        /// </summary>
        /// <param name="RemoveMode">kind of remove</param>
        /// <param name="custom">custom arguments</param>
        protected internal virtual void RaiseOnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                var handler = OnDisconnection;
                if (null != handler)
                    handler(RemoveMode, ref custom);
            }
            catch (NetRuntimeSystem.Exception exception)
            {
				Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnDisconnection, exception);
            }
        }

        /// <summary>
        /// Raise the OnConnection event
        /// </summary>
        /// <param name="Application">application host instance</param>
        /// <param name="ConnectMode">kind of connect</param>
        /// <param name="AddInInst">addin instance</param>
        /// <param name="custom">custom arguments</param>
        protected internal virtual void RaiseOnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                var handler = OnConnection;
                if (null != handler)
                    handler(Application, ConnectMode, AddInInst, ref custom);
            }
            catch (NetRuntimeSystem.Exception exception)
            {
				Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnConnection, exception);
            }
        }

        /// <summary>
        /// Raise the OnAddInsUpdate event
        /// </summary>
        /// <param name="custom">custom arguments</param>
        protected internal virtual void RaiseOnAddInsUpdate(ref Array custom)
        {
            try
            {
                var handler = OnAddInsUpdate;
                if (null != handler)
                    handler(ref custom);
            }
            catch (NetRuntimeSystem.Exception exception)
            {
				Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnAddInsUpdate, exception);
            }
        }

        /// <summary>
        /// Raise the OnBeginShutdown event
        /// </summary>
        /// <param name="custom">custom arguments</param>
        protected internal virtual void RaiseOnBeginShutdown(ref Array custom)
        {
            try
            {
                var handler = OnBeginShutdown;
                if (null != handler)
                    handler(ref custom);
            }
            catch (NetRuntimeSystem.Exception exception)
            {
				Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnBeginShutdown, exception);
            }
        }

        #endregion

        #region IDTExtensibility2

        void NetOffice.Tools.Native.IDTExtensibility2.OnStartupComplete(ref Array custom)
        {
            try
            {
                LoadingTimeElapsed = (DateTime.Now - _creationTime);
                Roots = OnCreateRoots();
                RaiseOnStartupComplete(ref custom);
            }
            catch (Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnStartupComplete, exception);
            }
        }

        void NetOffice.Tools.Native.IDTExtensibility2.OnConnection(object application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                this.Application = Factory.CreateKnownObjectFromComProxy<Visio.Application>(null, application, typeof(Visio.Application));
                TryCreateCustomObject(AddInInst);
                RaiseOnConnection(this.Application, ConnectMode, AddInInst, ref custom);
            }
            catch (System.Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnConnection, exception);
            }
        }

        void NetOffice.Tools.Native.IDTExtensibility2.OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            try
            {
                try
                {
                    RaiseOnDisconnection(RemoveMode, ref custom);
                }
                catch (NetRuntimeSystem.Exception exception)
                {
                    Factory.Console.WriteException(exception);
                }

                try
                {
                    if (!Application.IsDisposed)
                        Application.Dispose();
                }
                catch (NetRuntimeSystem.Exception exception)
                {
                    Factory.Console.WriteException(exception);
                }

                try
                {
                    CleanUp();
                }
                catch (NetRuntimeSystem.Exception exception)
                {
                    Factory.Console.WriteException(exception);
                }
            }
            catch (System.Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnDisconnection, exception);
            }
        }

        void NetOffice.Tools.Native.IDTExtensibility2.OnAddInsUpdate(ref Array custom)
        {
            try
            {
                RaiseOnAddInsUpdate(ref custom);
            }
            catch (System.Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnAddInsUpdate, exception);
            }
        }

        void NetOffice.Tools.Native.IDTExtensibility2.OnBeginShutdown(ref Array custom)
        {
            try
            {
                RaiseOnBeginShutdown(ref custom);
            }
            catch (System.Exception exception)
            {
                Factory.Console.WriteException(exception);
                OnError(ErrorMethodKind.OnBeginShutdown, exception);
            }
        }

        #endregion

        #region ErrorHandler

        /// <summary>
        /// Custom error handler
        /// </summary>
        /// <param name="methodKind">origin method where the error comes from</param>
        /// <param name="exception">occured exception</param>
        protected virtual void OnError(ErrorMethodKind methodKind, NetRuntimeSystem.Exception exception)
        {

        }

        #endregion

        #region COM Register Functions

        /// <summary>
        /// Called from regasm while register
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComRegisterFunctionAttribute, Browsable(false), EditorBrowsable( EditorBrowsableState.Never)]
        public static void RegisterFunction(Type type)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            COMAddinRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, InstallScope.System, OfficeRegisterKeyState.NeedToCreate);
        }

        /// <summary>
        /// Called from regasm while ungregister
        /// </summary>
        /// <param name="type">Type information for the class</param>
        [ComUnregisterFunctionAttribute, Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public static void UnregisterFunction(Type type)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            COMAddinUnRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, InstallScope.System, OfficeUnRegisterKeyState.NeedToDelete);
        }

        /// <summary>
        /// Called from RegAddin while register
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeRegisterKeyState enum value</param>
        [ComRegisterCall]
        private static void OptimizedRegisterFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            InstallScope currentScope = (InstallScope)scope;
            OfficeRegisterKeyState currentKeyState = (OfficeRegisterKeyState)keyState;

            COMAddinRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
        }

        /// <summary>
        /// Called from RegAddin while unregister
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeUnRegisterKeyState enum value</param>
        [ComUnregisterCall]
        private static void OptimizedUnregisterFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            if (null != type.GetCustomAttribute<DontRegisterAddinAttribute>())
                return;

            InstallScope currentScope = (InstallScope)scope;
            OfficeUnRegisterKeyState currentKeyState = (OfficeUnRegisterKeyState)keyState;

            COMAddinUnRegisterHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
        }

        /// <summary>
        /// Called from RegAddin while export registry informations
        /// </summary>
        /// <param name="type">Type information for the class</param>
        /// <param name="scope">NetOffice.Tools.InstallScope enum value</param>
        /// <param name="keyState">NetOffice.Tools.OfficeRegisterKeyState enum value</param>
        /// <returns>Registry keys/values to be add in the registry export or null</returns>
        [ComRegExportCall]
        private static RegExport RegExportFunction(Type type, int scope, int keyState)
        {
            if (null == type)
                throw new ArgumentNullException("type");
            InstallScope currentScope = (InstallScope)scope;
            OfficeRegisterKeyState currentKeyState = (OfficeRegisterKeyState)keyState;

            return RegExportHandler.Proceed(type, new string[] { _addinOfficeRegistryKey }, currentScope, currentKeyState);
        }

        #endregion
    }
}