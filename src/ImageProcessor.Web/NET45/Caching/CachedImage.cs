﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CachedImage.cs" company="James South">
//   Copyright (c) James South.
//   Licensed under the Apache License, Version 2.0.
// </copyright>
// <summary>
//   Describes a cached image
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ImageProcessor.Web.Caching
{
    #region Using
    using System;
    #endregion

    /// <summary>
    /// Describes a cached image 
    /// </summary>
    internal sealed class CachedImage
    {
        /// <summary>
        /// Gets or sets the key identifying the cached image.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the value of the cached image.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the last write time of the cached image.
        /// </summary>
        public DateTime LastWriteTimeUtc { get; set; }
    }
}
