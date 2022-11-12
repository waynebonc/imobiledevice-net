﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="InstallationProxyErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.InstallationProxy
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class InstallationProxyErrorExtensions
    {
        
        public static void ThrowOnError(this InstallationProxyError value)
        {
            if ((value != InstallationProxyError.Success))
            {
                throw new InstallationProxyException(value);
            }
        }
        
        public static void ThrowOnError(this InstallationProxyError value, string message)
        {
            if ((value != InstallationProxyError.Success))
            {
                throw new InstallationProxyException(value, message);
            }
        }
        
        public static bool IsError(this InstallationProxyError value)
        {
            return (value != InstallationProxyError.Success);
        }
    }
}
