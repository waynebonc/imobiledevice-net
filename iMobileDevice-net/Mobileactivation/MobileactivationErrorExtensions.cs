﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="MobileactivationErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022-2024 Wayne Bonnici.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1570
#pragma warning disable 1572
#pragma warning disable 1573
#pragma warning disable 1574

namespace iMobileDevice.Mobileactivation
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class MobileactivationErrorExtensions
    {
        
        public static void ThrowOnError(this MobileactivationError value)
        {
            if ((value != MobileactivationError.Success))
            {
                throw new MobileactivationException(value);
            }
        }
        
        public static void ThrowOnError(this MobileactivationError value, string message)
        {
            if ((value != MobileactivationError.Success))
            {
                throw new MobileactivationException(value, message);
            }
        }
        
        public static bool IsError(this MobileactivationError value)
        {
            return (value != MobileactivationError.Success);
        }
    }
}
