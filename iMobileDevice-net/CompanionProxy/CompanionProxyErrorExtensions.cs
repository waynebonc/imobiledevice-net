﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="CompanionProxyErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.CompanionProxy
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class CompanionProxyErrorExtensions
    {
        
        public static void ThrowOnError(this CompanionProxyError value)
        {
            if ((value != CompanionProxyError.Success))
            {
                throw new CompanionProxyException(value);
            }
        }
        
        public static void ThrowOnError(this CompanionProxyError value, string message)
        {
            if ((value != CompanionProxyError.Success))
            {
                throw new CompanionProxyException(value, message);
            }
        }
        
        public static bool IsError(this CompanionProxyError value)
        {
            return (value != CompanionProxyError.Success);
        }
    }
}
