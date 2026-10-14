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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateIndexRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ES cluster ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Updated index type. auto: autonomous index; normal: general index</p>
        /// </summary>
        [JsonProperty("IndexType")]
        public string IndexType{ get; set; }

        /// <summary>
        /// <p>Updated index name</p>
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// <p>Updated JSON-formatted index metadata, such as mappings and settings</p>
        /// </summary>
        [JsonProperty("UpdateMetaJson")]
        public string UpdateMetaJson{ get; set; }

        /// <summary>
        /// <p>Cluster access username.</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Cluster access password</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Whether to scroll the backup index</p>
        /// </summary>
        [JsonProperty("RolloverBackingIndex")]
        public bool? RolloverBackingIndex{ get; set; }

        /// <summary>
        /// <p>Whether to retrieve the full uninstall index</p>
        /// </summary>
        [JsonProperty("MountIndex")]
        public bool? MountIndex{ get; set; }

        /// <summary>
        /// <p>Index Uuid</p>
        /// </summary>
        [JsonProperty("IndexUuid")]
        public string IndexUuid{ get; set; }

        /// <summary>
        /// <p>Backing index name</p>
        /// </summary>
        [JsonProperty("BackingIndexName")]
        public string BackingIndexName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "IndexType", this.IndexType);
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "UpdateMetaJson", this.UpdateMetaJson);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "RolloverBackingIndex", this.RolloverBackingIndex);
            this.SetParamSimple(map, prefix + "MountIndex", this.MountIndex);
            this.SetParamSimple(map, prefix + "IndexUuid", this.IndexUuid);
            this.SetParamSimple(map, prefix + "BackingIndexName", this.BackingIndexName);
        }
    }
}

