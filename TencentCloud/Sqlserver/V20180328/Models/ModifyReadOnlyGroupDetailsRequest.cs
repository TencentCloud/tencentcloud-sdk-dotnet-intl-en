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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyReadOnlyGroupDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// Primary instance ID, in the format of mssql-3l3fgqn7.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Read-only group ID.
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// Read-only group name. The modification is not performed if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// Whether to enable the delayed read-only instance removal feature. 0 - disabled; 1 - enabled. The modification is not performed if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("IsOfflineDelay")]
        public long? IsOfflineDelay{ get; set; }

        /// <summary>
        /// Timeout threshold used after the delayed read-only instance removal feature is enabled. The modification is not performed if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("ReadOnlyMaxDelayTime")]
        public long? ReadOnlyMaxDelayTime{ get; set; }

        /// <summary>
        /// Minimum number of retained read-only replicas in the read-only group, after the delayed read-only instance removal feature is enabled. The modification is not performed if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("MinReadOnlyInGroup")]
        public long? MinReadOnlyInGroup{ get; set; }

        /// <summary>
        /// Collection of read-only group instance weight modification. The modification is not performed if this parameter is left unspecified.
        /// </summary>
        [JsonProperty("WeightPairs")]
        public ReadOnlyInstanceWeightPair[] WeightPairs{ get; set; }

        /// <summary>
        /// 0 - user-defined weight (adjust according to WeightPairs); 1 - automatically assigned weight by the system (invalid WeightPairs). The default value is 0.
        /// </summary>
        [JsonProperty("AutoWeight")]
        public long? AutoWeight{ get; set; }

        /// <summary>
        /// 0 - not rebalance the load; 1 - rebalance the load. The default value is 0.
        /// </summary>
        [JsonProperty("BalanceWeight")]
        public long? BalanceWeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "IsOfflineDelay", this.IsOfflineDelay);
            this.SetParamSimple(map, prefix + "ReadOnlyMaxDelayTime", this.ReadOnlyMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinReadOnlyInGroup", this.MinReadOnlyInGroup);
            this.SetParamArrayObj(map, prefix + "WeightPairs.", this.WeightPairs);
            this.SetParamSimple(map, prefix + "AutoWeight", this.AutoWeight);
            this.SetParamSimple(map, prefix + "BalanceWeight", this.BalanceWeight);
        }
    }
}

