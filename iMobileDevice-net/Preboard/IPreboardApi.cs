//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="IPreboardApi.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022-2024 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Preboard
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial interface IPreboardApi
    {
        
        /// <summary>
        /// Gets or sets the <see cref="ILibiMobileDeviceApi"/> which owns this <see cref="Preboard"/>.
        /// </summary>
        ILibiMobileDevice Parent
        {
            get;
        }
        
        /// <summary>
        /// Connects to the preboard service on the specified device.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="service">
        /// The service descriptor returned by lockdownd_start_service.
        /// </param>
        /// <param name="client">
        /// Pointer that will point to a newly allocated
        /// preboard_client_t upon successful return. Must be freed using
        /// preboard_client_free() after use.
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success, PREBOARD_E_INVALID_ARG when
        /// client is NULL, or an PREBOARD_E_* error code otherwise.
        /// </returns>
        PreboardError preboard_client_new(iDeviceHandle device, LockdownServiceDescriptorHandle service, out PreboardClientHandle client);
        
        /// <summary>
        /// Starts a new preboard service on the specified device and connects to it.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will point to a newly allocated
        /// preboard_client_t upon successful return. Must be freed using
        /// preboard_client_free() after use.
        /// </param>
        /// <param name="label">
        /// The label to use for communication. Usually the program name.
        /// Pass NULL to disable sending the label in requests to lockdownd.
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success, or a PREBOARD_E_* error
        /// code otherwise.
        /// </returns>
        PreboardError preboard_client_start_service(iDeviceHandle device, out PreboardClientHandle client, string label);
        
        /// <summary>
        /// Disconnects a preboard client from the device and frees up the
        /// preboard client data.
        /// </summary>
        /// <param name="client">
        /// The preboard client to disconnect and free.
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success, PREBOARD_E_INVALID_ARG when
        /// client is NULL, or a PREBOARD_E_* error code otherwise.
        /// </returns>
        PreboardError preboard_client_free(System.IntPtr client);
        
        /// <summary>
        /// Sends a plist to the service.
        /// </summary>
        /// <param name="client">
        /// The preboard client
        /// </param>
        /// <param name="plist">
        /// The plist to send
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success,
        /// PREBOARD_E_INVALID_ARG when client or plist is NULL,
        /// or a PREBOARD_E_* error code on error
        /// </returns>
        PreboardError preboard_send(PreboardClientHandle client, PlistHandle plist);
        
        /// <summary>
        /// Receives a plist from the service.
        /// </summary>
        /// <param name="client">
        /// The preboard client
        /// </param>
        /// <param name="plist">
        /// Pointer to a plist_t what will be set to the received plist
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success,
        /// PREBOARD_E_INVALID_ARG when client or plist is NULL,
        /// PREBOARD_E_TIMEOUT when no data was received after 5 seconds,
        /// or a PREBOARD_E_* error code on error
        /// </returns>
        PreboardError preboard_receive(PreboardClientHandle client, out PlistHandle plist);
        
        /// <summary>
        /// Receives a plist from the service with the specified timeout.
        /// </summary>
        /// <param name="client">
        /// The preboard client
        /// </param>
        /// <param name="plist">
        /// Pointer to a plist_t what will be set to the received plist
        /// </param>
        /// <param name="timeoutMs">
        /// Timeout in milliseconds
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS on success,
        /// PREBOARD_E_INVALID_ARG when client or plist is NULL,
        /// PREBOARD_E_TIMEOUT when no data was received after the given timeout,
        /// or a PREBOARD_E_* error code on error.
        /// </returns>
        PreboardError preboard_receive_with_timeout(PreboardClientHandle client, out PlistHandle plist, uint timeoutMs);
        
        /// <summary>
        /// Tells the preboard service to create a stashbag. This will make the device
        /// show a passcode entry so it can generate and store a token that is later
        /// used during restore.
        /// The callback or following preboard_receive* invocations will usually
        /// receive a dictionary with:
        /// { ShowDialog: true }
        /// If the user does not enter a passcode, after 2 minutes a timeout is reached
        /// and the device sends a dictionary with:
        /// { Timeout: true }
        /// followed by { HideDialog: true }
        /// If the user aborts the passcode entry, the device sends a dictionary:
        /// { Error: 1, ErrorString:
        /// <
        /// error string
        /// >
        /// }
        /// followed by { HideDialog: true }
        /// </summary>
        /// <param name="client">
        /// The preboard client
        /// </param>
        /// <param name="manifest">
        /// An optional manifest
        /// </param>
        /// <param name="statusCallBack">
        /// Callback function that will receive status and error messages.
        /// Can be NULL if you want to handle receiving messages in your own code.
        /// </param>
        /// <param name="userData">
        /// User data for callback function or NULL.
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS if the command was successfully submitted,
        /// PREBOARD_E_INVALID_ARG when client is invalid,
        /// or a PREBOARD_E_* error code on error.
        /// </returns>
        PreboardError preboard_create_stashbag(PreboardClientHandle client, PlistHandle manifest, PreboardStatusCallBack statusCallBack, System.IntPtr userData);
        
        /// <summary>
        /// Instructs the preboard service to commit a previously created stashbag.
        /// The callback or following preboard_receive* invocations will usually
        /// receive a dictionary with:
        /// { StashbagCommitComplete: true }
        /// or in case of an error:
        /// { StashbagCommitComplete: 0, Error: 1,
        /// <
        /// optional
        /// >
        /// ErrorString:
        /// <
        /// error string
        /// >
        /// }
        /// </summary>
        /// <param name="client">
        /// The preboard client to use for receiving
        /// </param>
        /// <param name="manifest">
        /// An optional manifest
        /// </param>
        /// <param name="statusCallBack">
        /// Callback function that will receive status and error messages
        /// Can be NULL if you want to handle receiving messages in your own code.
        /// </param>
        /// <param name="userData">
        /// User data for callback function or NULL.
        /// </param>
        /// <returns>
        /// PREBOARD_E_SUCCESS if the command was successfully submitted,
        /// PREBOARD_E_INVALID_ARG when client is invalid,
        /// or a PREBOARD_E_* error code on error.
        /// </returns>
        PreboardError preboard_commit_stashbag(PreboardClientHandle client, PlistHandle manifest, PreboardStatusCallBack statusCallBack, System.IntPtr userData);
    }
}
