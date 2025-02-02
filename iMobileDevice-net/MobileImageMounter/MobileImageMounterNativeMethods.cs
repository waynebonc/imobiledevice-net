//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="MobileImageMounterNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022-2024 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.MobileImageMounter
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class MobileImageMounterNativeMethods
    {
        
        public const string LibraryName = "libimobiledevice";
        
        static MobileImageMounterNativeMethods()
        {
            LibraryResolver.EnsureRegistered();
        }
        
        /// <summary>
        /// Connects to the mobile_image_mounter service on the specified device.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="service">
        /// The service descriptor returned by lockdownd_start_service.
        /// </param>
        /// <param name="client">
        /// Pointer that will be set to a newly allocated
        /// mobile_image_mounter_client_t upon successful return.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// MOBILE_IMAGE_MOUNTER_E_INVALID_ARG if device is NULL,
        /// or MOBILE_IMAGE_MOUNTER_E_CONN_FAILED if the connection to the
        /// device could not be established.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_new", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_new(iDeviceHandle device, LockdownServiceDescriptorHandle service, out MobileImageMounterClientHandle client);
        
        /// <summary>
        /// Starts a new mobile_image_mounter service on the specified device and connects to it.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will point to a newly allocated
        /// mobile_image_mounter_t upon successful return. Must be freed using
        /// mobile_image_mounter_free() after use.
        /// </param>
        /// <param name="label">
        /// The label to use for communication. Usually the program name.
        /// Pass NULL to disable sending the label in requests to lockdownd.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success, or an MOBILE_IMAGE_MOUNTER_E_* error
        /// code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_start_service", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_start_service(iDeviceHandle device, out MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string label);
        
        /// <summary>
        /// Disconnects a mobile_image_mounter client from the device and frees up the
        /// mobile_image_mounter client data.
        /// </summary>
        /// <param name="client">
        /// The mobile_image_mounter client to disconnect and free.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or MOBILE_IMAGE_MOUNTER_E_INVALID_ARG if client is NULL.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_free", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_free(System.IntPtr client);
        
        /// <summary>
        /// Tells if the image of ImageType is already mounted.
        /// </summary>
        /// <param name="client">
        /// The client use
        /// </param>
        /// <param name="imageType">
        /// The type of the image to look up
        /// </param>
        /// <param name="result">
        /// Pointer to a plist that will receive the result of the
        /// operation.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success, or an error code on error
        /// </returns>
        /// <remarks>
        /// This function may return MOBILE_IMAGE_MOUNTER_E_SUCCESS even if the
        /// operation has failed. Check the resulting plist for further information.
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_lookup_image", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_lookup_image(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, out PlistHandle result);
        
        /// <summary>
        /// Uploads an image with an optional signature to the device.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imageType">
        /// Type of image that is being uploaded.
        /// </param>
        /// <param name="imageSize">
        /// Total size of the image.
        /// </param>
        /// <param name="signature">
        /// Buffer with a signature of the image being uploaded. If
        /// NULL, no signature will be used.
        /// </param>
        /// <param name="signatureSize">
        /// Total size of the image signature buffer. If 0, no
        /// signature will be used.
        /// </param>
        /// <param name="uploadCallBack">
        /// Callback function that gets the data chunks for uploading
        /// the image.
        /// </param>
        /// <param name="userdata">
        /// User defined data for the upload callback function.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on succes, or a
        /// MOBILE_IMAGE_MOUNTER_E_* error code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_upload_image", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_upload_image(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, uint imageSize, byte[] signature, uint signatureSize, MobileImageMounterUploadCallBack uploadCallBack, System.IntPtr userdata);
        
        /// <summary>
        /// Mounts an image on the device.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imagePath">
        /// The absolute path of the image to mount. The image must
        /// be present before calling this function.
        /// </param>
        /// <param name="signature">
        /// Pointer to a buffer holding the images' signature
        /// </param>
        /// <param name="signatureSize">
        /// Length of the signature image_signature points to
        /// </param>
        /// <param name="imageType">
        /// Type of image to mount
        /// </param>
        /// <param name="options">
        /// A dictionary containing additional key/value pairs to add
        /// </param>
        /// <param name="result">
        /// Pointer to a plist that will receive the result of the
        /// operation.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// MOBILE_IMAGE_MOUNTER_E_INVALID_ARG if on ore more parameters are
        /// invalid, or another error code otherwise.
        /// </returns>
        /// <remarks>
        /// This function may return MOBILE_IMAGE_MOUNTER_E_SUCCESS even if the
        /// operation has failed. Check the resulting plist for further information.
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_mount_image_with_options", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_mount_image_with_options(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imagePath, byte[] signature, uint signatureSize, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, PlistHandle options, out PlistHandle result);
        
        /// <summary>
        /// Mounts an image on the device.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imagePath">
        /// The absolute path of the image to mount. The image must
        /// be present before calling this function.
        /// </param>
        /// <param name="signature">
        /// Pointer to a buffer holding the images' signature
        /// </param>
        /// <param name="signatureSize">
        /// Length of the signature image_signature points to
        /// </param>
        /// <param name="imageType">
        /// Type of image to mount
        /// </param>
        /// <param name="result">
        /// Pointer to a plist that will receive the result of the
        /// operation.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// MOBILE_IMAGE_MOUNTER_E_INVALID_ARG if on ore more parameters are
        /// invalid, or another error code otherwise.
        /// </returns>
        /// <remarks>
        /// This function may return MOBILE_IMAGE_MOUNTER_E_SUCCESS even if the
        /// operation has failed. Check the resulting plist for further information.
        /// </remarks>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_mount_image", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_mount_image(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imagePath, byte[] signature, uint signatureSize, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, out PlistHandle result);
        
        /// <summary>
        /// Unmount a mounted image at given path on the device.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="mountPath">
        /// The mount path of the mounted image on the device.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_unmount_image", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_unmount_image(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string mountPath);
        
        /// <summary>
        /// Hangs up the connection to the mobile_image_mounter service.
        /// This functions has to be called before freeing up a mobile_image_mounter
        /// instance. If not, errors appear in the device's syslog.
        /// </summary>
        /// <param name="client">
        /// The client to hang up
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// MOBILE_IMAGE_MOUNTER_E_INVALID_ARG if client is invalid,
        /// or another error code otherwise.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_hangup", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_hangup(MobileImageMounterClientHandle client);
        
        /// <summary>
        /// Query the developer mode status of the given device.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="result">
        /// A pointer to a plist_t that will be set to the resulting developer mode status dictionary.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_query_developer_mode_status", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_query_developer_mode_status(MobileImageMounterClientHandle client, out PlistHandle result);
        
        /// <summary>
        /// Query a personalization nonce for the given image type, used for personalized disk images (iOS 17+).
        /// This nonce is supposed to be added to the TSS request for the corresponding image.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imageType">
        /// The image_type to get the personalization nonce for, usually `DeveloperDiskImage`.
        /// </param>
        /// <param name="nonce">
        /// Pointer that will be set to an allocated buffer with the nonce value.
        /// </param>
        /// <param name="nonceSize">
        /// Pointer to an unsigned int that will receive the size of the nonce value.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_query_nonce", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_query_nonce(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, ref System.IntPtr nonce, ref uint nonceSize);
        
        /// <summary>
        /// Query personalization identitifers for the given image_type.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imageType">
        /// The image_type to get the personalization identifiers for. Can be NULL.
        /// </param>
        /// <param name="result">
        /// A pointer to a plist_t that will be set to the resulting identifier dictionary.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_query_personalization_identifiers", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_query_personalization_identifiers(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, out PlistHandle result);
        
        /// 
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <param name="imageType">
        /// The image_type to get the personalization identifiers for. Can be NULL.
        /// </param>
        /// <param name="signature">
        /// The signature of the corresponding personalized image.
        /// </param>
        /// <param name="signatureSize">
        /// The size of signature.
        /// </param>
        /// <param name="manifest">
        /// Pointer that will be set to an allocated buffer with the manifest data.
        /// </param>
        /// <param name="manifestSize">
        /// Pointer to an unsigned int that will be set to the size of the manifest data.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_query_personalization_manifest", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_query_personalization_manifest(MobileImageMounterClientHandle client, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)] string imageType, byte[] signature, uint signatureSize, ref System.IntPtr manifest, ref uint manifestSize);
        
        /// <summary>
        /// Roll the personalization nonce.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_roll_personalization_nonce", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_roll_personalization_nonce(MobileImageMounterClientHandle client);
        
        /// <summary>
        /// Roll the Cryptex nonce.
        /// </summary>
        /// <param name="client">
        /// The connected mobile_image_mounter client.
        /// </param>
        /// <returns>
        /// MOBILE_IMAGE_MOUNTER_E_SUCCESS on success,
        /// or a MOBILE_IMAGE_MOUNTER_E_* error code on error.
        /// </returns>
        [System.Runtime.InteropServices.DllImportAttribute(MobileImageMounterNativeMethods.LibraryName, EntryPoint="mobile_image_mounter_roll_cryptex_nonce", CallingConvention=System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static extern MobileImageMounterError mobile_image_mounter_roll_cryptex_nonce(MobileImageMounterClientHandle client);
    }
}
