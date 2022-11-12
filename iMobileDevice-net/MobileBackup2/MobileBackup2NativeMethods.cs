//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="MobileBackup2NativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.MobileBackup2
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class MobileBackup2NativeMethods
    {
        
        public const string LibraryName = "imobiledevice";
        
        static MobileBackup2NativeMethods()
        {
            LibraryResolver.EnsureRegistered();
        }
        
        /// <summary>
        /// Connects to the mobilebackup2 service on the specified device.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="service">
        /// The service descriptor returned by lockdownd_start_service.
        /// </param>
        /// <param name="client">
        /// Pointer that will be set to a newly allocated
        /// mobilebackup2_client_t upon successful return.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS on success, MOBILEBACKUP2_E_INVALID ARG
        /// if one or more parameter is invalid, or MOBILEBACKUP2_E_BAD_VERSION
        /// if the mobilebackup2 version on the device is newer.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_client_new", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_client_new(iDeviceHandle device, LockdownServiceDescriptorHandle service, out MobileBackup2ClientHandle client);
        
        /// <summary>
        /// Starts a new mobilebackup2 service on the specified device and connects to it.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will point to a newly allocated
        /// mobilebackup2_client_t upon successful return. Must be freed using
        /// mobilebackup2_client_free() after use.
        /// </param>
        /// <param name="label">
        /// The label to use for communication. Usually the program name.
        /// Pass NULL to disable sending the label in requests to lockdownd.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS on success, or an MOBILEBACKUP2_E_* error
        /// code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_client_start_service", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_client_start_service(iDeviceHandle device, out MobileBackup2ClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label);
        
        /// <summary>
        /// Disconnects a mobilebackup2 client from the device and frees up the
        /// mobilebackup2 client data.
        /// </summary>
        /// <param name="client">
        /// The mobilebackup2 client to disconnect and free.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS on success, or MOBILEBACKUP2_E_INVALID_ARG
        /// if client is NULL.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_client_free", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_client_free(System.IntPtr client);
        
        /// <summary>
        /// Sends a backup message plist.
        /// </summary>
        /// <param name="client">
        /// The connected MobileBackup client to use.
        /// </param>
        /// <param name="message">
        /// The message to send. This will be inserted into the request
        /// plist as value for MessageName. If this parameter is NULL,
        /// the plist passed in the options parameter will be sent directly.
        /// </param>
        /// <param name="options">
        /// Additional options as PLIST_DICT to add to the request.
        /// The MessageName key with the value passed in the message parameter
        /// will be inserted into this plist before sending it. This parameter
        /// can be NULL if message is not NULL.
        /// </param>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_send_message", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_send_message(MobileBackup2ClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string message, PlistHandle options);
        
        /// <summary>
        /// Receives a DL* message plist from the device.
        /// This function is a wrapper around device_link_service_receive_message.
        /// </summary>
        /// <param name="client">
        /// The connected MobileBackup client to use.
        /// </param>
        /// <param name="msg_plist">
        /// Pointer to a plist that will be set to the contents of the
        /// message plist upon successful return.
        /// </param>
        /// <param name="dlmessage">
        /// A pointer that will be set to a newly allocated char*
        /// containing the DL* string from the given plist. It is up to the caller
        /// to free the allocated memory. If this parameter is NULL
        /// it will be ignored.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS if a DL* message was received,
        /// MOBILEBACKUP2_E_INVALID_ARG if client or message is invalid,
        /// MOBILEBACKUP2_E_PLIST_ERROR if the received plist is invalid
        /// or is not a DL* message plist, or MOBILEBACKUP2_E_MUX_ERROR if
        /// receiving from the device failed.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_receive_message", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_receive_message(MobileBackup2ClientHandle client, out PlistHandle msgPlist, out System.IntPtr dlmessage);
        
        /// <summary>
        /// Send binary data to the device.
        /// </summary>
        /// <param name="client">
        /// The MobileBackup client to send to.
        /// </param>
        /// <param name="data">
        /// Pointer to the data to send
        /// </param>
        /// <param name="length">
        /// Number of bytes to send
        /// </param>
        /// <param name="bytes">
        /// Number of bytes actually sent
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS if any data was successfully sent,
        /// MOBILEBACKUP2_E_INVALID_ARG if one of the parameters is invalid,
        /// or MOBILEBACKUP2_E_MUX_ERROR if sending of the data failed.
        /// </returns>
        /// <remarks>
        /// This function returns MOBILEBACKUP2_E_SUCCESS even if less than the
        /// requested length has been sent. The fourth parameter is required and
        /// must be checked to ensure if the whole data has been sent.
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_send_raw", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_send_raw(MobileBackup2ClientHandle client, byte[] data, uint length, ref uint bytes);
        
        /// <summary>
        /// Receive binary from the device.
        /// </summary>
        /// <param name="client">
        /// The MobileBackup client to receive from.
        /// </param>
        /// <param name="data">
        /// Pointer to a buffer that will be filled with the received data.
        /// </param>
        /// <param name="length">
        /// Number of bytes to receive. The data buffer needs to be large
        /// enough to store this amount of data.
        /// </param>
        /// <param name="bytes">
        /// Number of bytes actually received.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS if any or no data was received,
        /// MOBILEBACKUP2_E_INVALID_ARG if one of the parameters is invalid,
        /// or MOBILEBACKUP2_E_MUX_ERROR if receiving the data failed.
        /// </returns>
        /// <remarks>
        /// This function returns MOBILEBACKUP2_E_SUCCESS even if no data
        /// has been received (unless a communication error occurred).
        /// The fourth parameter is required and must be checked to know how
        /// many bytes were actually received.
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_receive_raw", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_receive_raw(MobileBackup2ClientHandle client, byte[] data, uint length, ref uint bytes);
        
        /// <summary>
        /// Performs the mobilebackup2 protocol version exchange.
        /// </summary>
        /// <param name="client">
        /// The MobileBackup client to use.
        /// </param>
        /// <param name="local_versions">
        /// An array of supported versions to send to the remote.
        /// </param>
        /// <param name="count">
        /// The number of items in local_versions.
        /// </param>
        /// <param name="remote_version">
        /// Holds the protocol version of the remote on success.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS on success, or a MOBILEBACKUP2_E_* error
        /// code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_version_exchange", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_version_exchange(MobileBackup2ClientHandle client, System.IntPtr localVersions, sbyte count, ref double remoteVersion);
        
        /// <summary>
        /// Send a request to the connected mobilebackup2 service.
        /// </summary>
        /// <param name="request">
        /// The request to send to the backup service.
        /// Currently, this is one of "Backup", "Restore", "Info", or "List".
        /// </param>
        /// <param name="target_identifier">
        /// UDID of the target device.
        /// </param>
        /// <param name="source_identifier">
        /// UDID of backup data?
        /// </param>
        /// <param name="options">
        /// Additional options in a plist of type PLIST_DICT.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS if the request was successfully sent,
        /// or a MOBILEBACKUP2_E_* error value otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_send_request", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_send_request(MobileBackup2ClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string request, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string targetIdentifier, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string sourceIdentifier, PlistHandle options);
        
        /// <summary>
        /// Sends a DLMessageStatusResponse to the device.
        /// </summary>
        /// <param name="client">
        /// The MobileBackup client to use.
        /// </param>
        /// <param name="status_code">
        /// The status code to send.
        /// </param>
        /// <param name="status1">
        /// A status message to send. Can be NULL if not required.
        /// </param>
        /// <param name="status2">
        /// An additional status plist to attach to the response.
        /// Can be NULL if not required.
        /// </param>
        /// <returns>
        /// MOBILEBACKUP2_E_SUCCESS on success, MOBILEBACKUP2_E_INVALID_ARG
        /// if client is invalid, or another MOBILEBACKUP2_E_* otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileBackup2NativeMethods.LibraryName, EntryPoint="mobilebackup2_send_status_response", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileBackup2Error mobilebackup2_send_status_response(MobileBackup2ClientHandle client, int statusCode, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string status1, PlistHandle status2);
    }
}
