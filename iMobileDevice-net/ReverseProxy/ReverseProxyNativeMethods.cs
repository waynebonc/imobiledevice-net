//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="ReverseProxyNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.ReverseProxy
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class ReverseProxyNativeMethods
    {
        
        public const string LibraryName = "imobiledevice";
        
        static ReverseProxyNativeMethods()
        {
            LibraryResolver.EnsureRegistered();
        }
        
        /// <summary>
        /// Create a reverse proxy client using com.apple.PurpleReverseProxy.Ctrl and
        /// com.apple.PurpleReverseProxy.Conn lockdown services. This will open a port
        /// 1083 on the device that iOS apps could connect to;
        /// that is
        /// only allowed if an app has the com.apple.private.PurpleReverseProxy.allowed
        /// entitlement, which currently only
        /// holds.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will be set to a newly allocated #reverse_proxy_client_t
        /// upon successful return.
        /// </param>
        /// <param name="label">
        /// A label to pass to lockdownd when creating the service
        /// connections, usually the program name.
        /// </param>
        /// <returns>
        /// REVERSE_PROXY_E_SUCCESS on success,
        /// or a REVERSE_PROXY_E_* error code otherwise.
        /// </returns>
        /// <remarks>
        /// This function only creates and initializes the reverse proxy;
        /// to make it operational, call reverse_proxy_client_start_proxy().
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_create_with_service", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ReverseProxyError reverse_proxy_client_create_with_service(iDeviceHandle device, out ReverseProxyClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label);
        
        /// <summary>
        /// Create a reverse proxy client using an open port on the device. This is
        /// used during firmware restores with the default port REVERSE_PROXY_DEFAULT_PORT (1082).
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will be set to a newly allocated reverse_proxy_client_t
        /// upon successful return.
        /// </param>
        /// <param name="device_port">
        /// An open port on the device. Unless it's being used for
        /// a custom implementation, pass REVERSE_PROXY_DEFAULT_PORT here.
        /// </param>
        /// <returns>
        /// REVERSE_PROXY_E_SUCCESS on success,
        /// or a REVERSE_PROXY_E_* error code otherwise.
        /// </returns>
        /// <remarks>
        /// This function only creates and initializes the reverse proxy;
        /// to make it operational, call reverse_proxy_client_start_proxy().
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_create_with_port", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ReverseProxyError reverse_proxy_client_create_with_port(iDeviceHandle device, out ReverseProxyClientHandle client, ushort devicePort);
        
        /// <summary>
        /// Disconnects a reverse proxy client and frees up the client data.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client to disconnect and free.
        /// </param>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_free", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ReverseProxyError reverse_proxy_client_free(System.IntPtr client);
        
        /// <summary>
        /// Make an initialized reverse proxy client operational, i.e. start the actual proxy.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client to start.
        /// </param>
        /// <param name="control_protocol_version">
        /// The control protocol version to use.
        /// This is either 1 or 2. Recent devices use 2.
        /// </param>
        /// <returns>
        /// REVERSE_PROXY_E_SUCCESS on success,
        /// or a REVERSE_PROXY_E_* error code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_start_proxy", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ReverseProxyError reverse_proxy_client_start_proxy(ReverseProxyClientHandle client, int controlProtocolVersion);
        
        /// <summary>
        /// Set a status callback function. This allows to report the status of the
        /// reverse proxy, like Ready, Connect Request, Connected, etc.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client
        /// </param>
        /// <param name="callback">
        /// The status callback function that will be called
        /// when the status of the reverse proxy changes.
        /// </param>
        /// <param name="user_data">
        /// A pointer that will be passed to the callback function.
        /// </param>
        /// <remarks>
        /// Set the callback before calling reverse_proxy_client_start_proxy().
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_set_status_callback", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void reverse_proxy_client_set_status_callback(ReverseProxyClientHandle client, ReverseProxyStatusCallBack callback, System.IntPtr userData);
        
        /// <summary>
        /// Set a log callback function. Useful for debugging or verbosity.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client
        /// </param>
        /// <param name="callback">
        /// The log callback function that will be called
        /// when the reverse proxy logs something.
        /// </param>
        /// <param name="user_data">
        /// A pointer that will be passed to the callback function.
        /// </param>
        /// <remarks>
        /// Set the callback before calling reverse_proxy_client_start_proxy().
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_set_log_callback", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void reverse_proxy_client_set_log_callback(ReverseProxyClientHandle client, ReverseProxyLogCallBack callback, System.IntPtr userData);
        
        /// <summary>
        /// Set a data callback function. Useful for debugging or extra verbosity.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client
        /// </param>
        /// <param name="callback">
        /// The status callback function that will be called
        /// when the status of the reverse proxy changes.
        /// </param>
        /// <param name="user_data">
        /// A pointer that will be passed to the callback function.
        /// </param>
        /// <remarks>
        /// Set the callback before calling reverse_proxy_client_start_proxy().
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_client_set_data_callback", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern void reverse_proxy_client_set_data_callback(ReverseProxyClientHandle client, ReverseProxyDataCallBack callback, System.IntPtr userData);
        
        /// <summary>
        /// Helper function to return the type of a given reverse proxy client, which
        /// is either RP_TYPE_CTRL or RP_TYPE_CONN. Useful for callback functions.
        /// </summary>
        /// <param name="client">
        /// The reverse proxy client
        /// </param>
        /// <returns>
        /// The type of the rerverse proxy client
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(ReverseProxyNativeMethods.LibraryName, EntryPoint="reverse_proxy_get_type", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern ReverseProxyClientType reverse_proxy_get_type(ReverseProxyClientHandle client);
    }
}
