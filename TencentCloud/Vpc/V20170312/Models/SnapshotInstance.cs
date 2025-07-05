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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotInstance : AbstractModel
    {
        
        /// <summary>
        /// ID of the instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Type of associated resource. Values: `securitygroup`
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance region
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// Snapshot policy IDs
        /// </summary>
        [JsonProperty("SnapshotPolicyId")]
        public string SnapshotPolicyId{ get; set; }

        /// <summary>
        /// The instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "SnapshotPolicyId", this.SnapshotPolicyId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
        }
    }
}

