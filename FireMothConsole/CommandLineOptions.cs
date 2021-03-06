﻿// <copyright file="CommandLineOptions.cs" company="Dark Hours Development">
// Copyright (c) Dark Hours Development. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace FireMothConsole
{
    using CommandLine;

    /// <summary>
    /// Defines options available when invoking the application via command line.
    /// </summary>
    public class CommandLineOptions
    {
        /// <summary>
        /// Gets or sets the ScanDirectory option, indicating the input directory to scan.
        /// </summary>
        [Option(
            'd',
            "directory",
            Required = true,
            HelpText = "The directory to scan.")]
        public string ScanDirectory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether subdirectories of <see cref="ScanDirectory"/>
        /// will be recursively scanned in addition to its file contents.
        /// </summary>
        [Option(
            'r',
            "recursive",
            Default = false,
            HelpText = "Recursively scan all subdirectories of the provided directory.")]
        public bool RecursiveScan { get; set; }
    }
}
