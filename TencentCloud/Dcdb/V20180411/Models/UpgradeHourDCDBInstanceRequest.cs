/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeHourDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID to be upgraded in the format of dcdbt-ow728lmc, which can be obtained through the `DescribeDCDBInstances` API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Upgrade type. Valid values: 
        /// <li> `ADD`: Add a new shard </li> 
        ///  <li> `EXPAND`: Upgrade the existing shads</li> 
        ///  <li> `SPLIT`: Split data of the existing shads to the new ones</li>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public string UpgradeType{ get; set; }

        /// <summary>
        /// Add shards when `UpgradeType` is `ADD`.
        /// </summary>
        [JsonProperty("AddShardConfig")]
        public AddShardConfig AddShardConfig{ get; set; }

        /// <summary>
        /// Expand shard when `UpgradeType` is `EXPAND`.
        /// </summary>
        [JsonProperty("ExpandShardConfig")]
        public ExpandShardConfig ExpandShardConfig{ get; set; }

        /// <summary>
        /// Split shard when `UpgradeType` is `SPLIT`.
        /// </summary>
        [JsonProperty("SplitShardConfig")]
        public SplitShardConfig SplitShardConfig{ get; set; }

        /// <summary>
        /// Switch start time in the format of "2019-12-12 07:00:00", which is no less than one hour and within 3 days from the current time.
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// Switch end time in the format of "2019-12-12 07:15:00", which must be later than the start time.
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }

        /// <summary>
        /// Whether to retry automatically. Valid values: `0` (no), `1` (yes).
        /// </summary>
        [JsonProperty("SwitchAutoRetry")]
        public long? SwitchAutoRetry{ get; set; }

        /// <summary>
        /// The list of new AZs specified in deployment modification. The first one is the source AZ, and the rest are replica AZs.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UpgradeType", this.UpgradeType);
            this.SetParamObj(map, prefix + "AddShardConfig.", this.AddShardConfig);
            this.SetParamObj(map, prefix + "ExpandShardConfig.", this.ExpandShardConfig);
            this.SetParamObj(map, prefix + "SplitShardConfig.", this.SplitShardConfig);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
            this.SetParamSimple(map, prefix + "SwitchAutoRetry", this.SwitchAutoRetry);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
        }
    }
}

