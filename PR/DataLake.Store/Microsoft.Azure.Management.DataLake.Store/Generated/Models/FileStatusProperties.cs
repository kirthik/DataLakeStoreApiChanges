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
    /// Data Lake Store file or directory information.
    /// </summary>
    public partial class FileStatusProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties() { }

        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties(long? accessTime = default(long?), long? blockSize = default(long?), long? childrenNum = default(long?), string group = default(string), long? length = default(long?), long? modificationTime = default(long?), string owner = default(string), string pathSuffix = default(string), string permission = default(string), FileType? type = default(FileType?))
        {
            AccessTime = accessTime;
            BlockSize = blockSize;
            ChildrenNum = childrenNum;
            Group = group;
            Length = length;
            ModificationTime = modificationTime;
            Owner = owner;
            PathSuffix = pathSuffix;
            Permission = permission;
            Type = type;
        }

        /// <summary>
        /// Gets the last access time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "accessTime")]
        public long? AccessTime { get; private set; }

        /// <summary>
        /// Gets the block size for the file.
        /// </summary>
        [JsonProperty(PropertyName = "blockSize")]
        public long? BlockSize { get; private set; }

        /// <summary>
        /// Gets the number of children in the directory.
        /// </summary>
        [JsonProperty(PropertyName = "childrenNum")]
        public long? ChildrenNum { get; private set; }

        /// <summary>
        /// Gets the group owner.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; private set; }

        /// <summary>
        /// Gets the number of bytes in a file.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public long? Length { get; private set; }

        /// <summary>
        /// Gets the modification time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "modificationTime")]
        public long? ModificationTime { get; private set; }

        /// <summary>
        /// Gets the user who is the owner.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; private set; }

        /// <summary>
        /// Gets the path suffix.
        /// </summary>
        [JsonProperty(PropertyName = "pathSuffix")]
        public string PathSuffix { get; private set; }

        /// <summary>
        /// Gets the permission represented as an string.
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; private set; }

        /// <summary>
        /// Gets the type of the path object. Possible values include: 'FILE',
        /// 'DIRECTORY'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FileType? Type { get; private set; }

    }
}
