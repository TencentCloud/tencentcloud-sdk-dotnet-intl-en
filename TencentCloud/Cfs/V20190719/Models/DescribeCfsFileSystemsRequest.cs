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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfsFileSystemsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>File system ID.</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Virtual Private Cloud (VPC) ID.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Offset for pagination. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Limit for page size. Default value: 10.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>User-defined name.</p>
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// <p>Filter conditions.<br><br><li>Protocol - Array of String - optional - (Filter condition) Filters by protocol. (NFS | CIFS | TURBO) </li><br><br><li>StorageType - Array of String - optional - (Filter condition) Filters by storage type. (SD | HP | TB | TP | THP) </li><br><br><li>LifeCycleState - Array of String - optional - (Filter condition) Filters by lifecycle state. (creating | create_failed | available | deleting | delete_failed | upgrading | unserviced | expanding) </li><br><br><li>Zone - Array of String - optional - (Filter condition) Filters by AZ. (For example: ap-guangzhou-3) </li><br><br><li>IpAddress - Array of String - optional - (Filter condition) Filters by export point IP address. (For example: 10.0.0.3) </li><br><br><li>PGroupId - Array of String - optional - (Filter condition) Filters by permission group ID. (For example: pgroup-xxxxxrxt) </li><br><br><li>PGroupName - Array of String - optional - (Filter condition) Filters by permission group name. (For example: default permission group) </li><br><br><li>Scenario- Array of String - optional - (Filter condition) Filters by permission group name. (For example: AgentSandbox) </li></p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

