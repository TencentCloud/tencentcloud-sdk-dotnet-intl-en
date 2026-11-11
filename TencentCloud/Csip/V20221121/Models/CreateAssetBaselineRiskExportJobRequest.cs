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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAssetBaselineRiskExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique asset identifier (UUID), used with AssetType to locate a specific asset.</p>
        /// </summary>
        [JsonProperty("AssetUniqueID")]
        public string AssetUniqueID{ get; set; }

        /// <summary>
        /// <p>Asset type. Parameter Value: HOST (host), CLUSTER (cluster).</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>appid of asset ownership</p>
        /// </summary>
        [JsonProperty("AssetAppID")]
        public ulong? AssetAppID{ get; set; }

        /// <summary>
        /// <p>Export task name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Universal Filter Criteria. Supported fields: ItemName (detection item name, blurry), PolicyName (baseline name, blurry), InstanceName (host name, blurry), InstanceID (instance ID, exact), IP (IP, blurry). Different Names are in an AND relationship with each other, while multiple Values under the same Name are in an OR relationship.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetUniqueID", this.AssetUniqueID);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetAppID", this.AssetAppID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

