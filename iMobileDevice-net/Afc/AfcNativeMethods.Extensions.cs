//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="AfcNativeMethods.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Afc
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class AfcNativeMethods
    {
        
        public static AfcError afc_get_device_info(AfcClientHandle client, out System.Collections.ObjectModel.ReadOnlyCollection<string> deviceInformation)
        {
            System.Runtime.InteropServices.ICustomMarshaler deviceInformationMarshaler = AfcDictionaryMarshaler.GetInstance(null);
            System.IntPtr deviceInformationNative = System.IntPtr.Zero;
            AfcError returnValue = AfcNativeMethods.afc_get_device_info(client, out deviceInformationNative);
            deviceInformation = ((System.Collections.ObjectModel.ReadOnlyCollection<string>)deviceInformationMarshaler.MarshalNativeToManaged(deviceInformationNative));
            deviceInformationMarshaler.CleanUpNativeData(deviceInformationNative);
            return returnValue;
        }
        
        public static AfcError afc_read_directory(AfcClientHandle client, string path, out System.Collections.ObjectModel.ReadOnlyCollection<string> directoryInformation)
        {
            System.Runtime.InteropServices.ICustomMarshaler directoryInformationMarshaler = AfcDictionaryMarshaler.GetInstance(null);
            System.IntPtr directoryInformationNative = System.IntPtr.Zero;
            AfcError returnValue = AfcNativeMethods.afc_read_directory(client, path, out directoryInformationNative);
            directoryInformation = ((System.Collections.ObjectModel.ReadOnlyCollection<string>)directoryInformationMarshaler.MarshalNativeToManaged(directoryInformationNative));
            directoryInformationMarshaler.CleanUpNativeData(directoryInformationNative);
            return returnValue;
        }
        
        public static AfcError afc_get_file_info(AfcClientHandle client, string path, out System.Collections.ObjectModel.ReadOnlyCollection<string> fileInformation)
        {
            System.Runtime.InteropServices.ICustomMarshaler fileInformationMarshaler = AfcDictionaryMarshaler.GetInstance(null);
            System.IntPtr fileInformationNative = System.IntPtr.Zero;
            AfcError returnValue = AfcNativeMethods.afc_get_file_info(client, path, out fileInformationNative);
            fileInformation = ((System.Collections.ObjectModel.ReadOnlyCollection<string>)fileInformationMarshaler.MarshalNativeToManaged(fileInformationNative));
            fileInformationMarshaler.CleanUpNativeData(fileInformationNative);
            return returnValue;
        }
        
        public static AfcError afc_get_device_info_key(AfcClientHandle client, string key, out string value)
        {
            System.Runtime.InteropServices.ICustomMarshaler valueMarshaler = NativeStringMarshaler.GetInstance(null);
            System.IntPtr valueNative = System.IntPtr.Zero;
            AfcError returnValue = AfcNativeMethods.afc_get_device_info_key(client, key, out valueNative);
            value = ((string)valueMarshaler.MarshalNativeToManaged(valueNative));
            valueMarshaler.CleanUpNativeData(valueNative);
            return returnValue;
        }
    }
}
