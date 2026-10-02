// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Xml.Linq;

namespace NuGet.Common
{
    public static class XmlUtility
    {
        /// <summary>
        /// Creates a new <see cref="System.Xml.Linq.XDocument"/> from a file.
        /// </summary>
        /// <param name="path">The complete file path to be read into a new <see cref="System.Xml.Linq.XDocument"/>.</param>
        /// <returns>An <see cref="System.Xml.Linq.XDocument"/> that contains the contents of the specified file.</returns>
        public static XDocument Load(string path)
            => Shared.XmlUtility.Load(path);
    }
}
