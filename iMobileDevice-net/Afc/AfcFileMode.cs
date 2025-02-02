//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="AfcFileMode.cs" company="Quamotion">
// Copyright (c) 2016-2021 Quamotion. All rights reserved.
// Copyright (c) 2022-2024 Wayne Bonnici.
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
    
    
    /// <summary>
    /// Flags for afc_file_open 
    /// </summary>
    public enum AfcFileMode : int
    {
        
        FopenRdonly = 1,
        
        FopenRw = 2,
        
        FopenWronly = 3,
        
        FopenWr = 4,
        
        FopenAppend = 5,
        
        /// <summary>
        /// a+  O_RDWR   | O_APPEND | O_CREAT 
        /// </summary>
        FopenRdappend = 6,
    }
}
