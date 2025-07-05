/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileSystem : AbstractModel
    {
        
        /// <summary>
        /// Resource owner `AppId`
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// File system name
        /// </summary>
        [JsonProperty("FileSystemName")]
        public string FileSystemName{ get; set; }

        /// <summary>
        /// File system description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// File system ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// File system block size (in bytes)
        /// </summary>
        [JsonProperty("BlockSize")]
        public ulong? BlockSize{ get; set; }

        /// <summary>
        /// File system capacity (in bytes)
        /// </summary>
        [JsonProperty("CapacityQuota")]
        public ulong? CapacityQuota{ get; set; }

        /// <summary>
        /// File system status (1: creating; 2: created successfully; 3: failed to create)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// List of superuser names
        /// </summary>
        [JsonProperty("SuperUsers")]
        public string[] SuperUsers{ get; set; }

        /// <summary>
        /// POSIX permission control
        /// </summary>
        [JsonProperty("PosixAcl")]
        public bool? PosixAcl{ get; set; }

        /// <summary>
        /// Whether to enable verification of Ranger service addresses
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EnableRanger")]
        public bool? EnableRanger{ get; set; }

        /// <summary>
        /// List of Ranger service addresses
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RangerServiceAddresses")]
        public string[] RangerServiceAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "FileSystemName", this.FileSystemName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BlockSize", this.BlockSize);
            this.SetParamSimple(map, prefix + "CapacityQuota", this.CapacityQuota);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SuperUsers.", this.SuperUsers);
            this.SetParamSimple(map, prefix + "PosixAcl", this.PosixAcl);
            this.SetParamSimple(map, prefix + "EnableRanger", this.EnableRanger);
            this.SetParamArraySimple(map, prefix + "RangerServiceAddresses.", this.RangerServiceAddresses);
        }
    }
}

