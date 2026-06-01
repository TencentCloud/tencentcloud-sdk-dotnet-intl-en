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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoGroupAttr : AbstractModel
    {
        
        /// <summary>
        /// RO group name.
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// Maximum delay threshold for the RO instance. Unit: seconds, minimum value is 1. Range: [1,10000], integer.
        /// Note: The RO group must have enabled the instance latency removal policy for this value to be valid.
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// Whether to enable instance removal. Valid values: 1 (enabled), 0 (not enabled). Please note that if instance removal is enabled, the delay threshold parameter (`RoMaxDelayTime`) must be set.
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// Minimum reserved instances. Can be set to any value ≤ the number of instances in the RO group. Default value: 1.
        /// Note: If the set value is larger than the RO instance count, do not remove. If set to 0, all instances with delay above the limit will be excluded.
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// Weighting mode. Supported values include `system` (automatically assigned by the system) and `custom` (defined by user). Please note that if the `custom` mode is selected, the RO instance weight configuration parameter (RoWeightValues) must be set.
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Delayed replication time. Unit: second, range: 1 - 259200 seconds, not required to enable delayed replication for the instance.
        /// </summary>
        [JsonProperty("ReplicationDelayTime")]
        public long? ReplicationDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupName", this.RoGroupName);
            this.SetParamSimple(map, prefix + "RoMaxDelayTime", this.RoMaxDelayTime);
            this.SetParamSimple(map, prefix + "RoOfflineDelay", this.RoOfflineDelay);
            this.SetParamSimple(map, prefix + "MinRoInGroup", this.MinRoInGroup);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "ReplicationDelayTime", this.ReplicationDelayTime);
        }
    }
}

