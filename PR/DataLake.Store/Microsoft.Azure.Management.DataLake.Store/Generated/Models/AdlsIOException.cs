// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A WebHDFS exception thrown indicating there was an IO (read or write)
    /// error. Thrown when a 403 error response code is returned (forbidden).
    /// </summary>
    [JsonObject("IOException")]
    public partial class AdlsIOException : AdlsRemoteException
    {
        /// <summary>
        /// Initializes a new instance of the AdlsIOException class.
        /// </summary>
        public AdlsIOException() { }

        /// <summary>
        /// Initializes a new instance of the AdlsIOException class.
        /// </summary>
        public AdlsIOException(string javaClassName = default(string), string message = default(string))
            : base(javaClassName, message)
        {
        }

    }
}
