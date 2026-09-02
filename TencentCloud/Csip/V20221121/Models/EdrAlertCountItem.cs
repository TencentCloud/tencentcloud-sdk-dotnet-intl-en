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

    public class EdrAlertCountItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Query instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Total number of alarms</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>Number of viruses and trojans (VIRUS_TROJAN)</p>
        /// </summary>
        [JsonProperty("VirusTrojanCount")]
        public long? VirusTrojanCount{ get; set; }

        /// <summary>
        /// <p>Number of abnormal logins (ABNORMAL_LOGIN)</p>
        /// </summary>
        [JsonProperty("AbnormalLoginCount")]
        public long? AbnormalLoginCount{ get; set; }

        /// <summary>
        /// <p>Number of server behaviors (HOST_BEHAVIOR)</p>
        /// </summary>
        [JsonProperty("HostBehaviorCount")]
        public long? HostBehaviorCount{ get; set; }

        /// <summary>
        /// <p>Number of network behaviors (NETWORK_BEHAVIOR)</p>
        /// </summary>
        [JsonProperty("NetworkBehaviorCount")]
        public long? NetworkBehaviorCount{ get; set; }

        /// <summary>
        /// <p>Number of hosts with alarms (only available in GlobalCount mode)</p>
        /// </summary>
        [JsonProperty("InstancesCount")]
        public ulong? InstancesCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "VirusTrojanCount", this.VirusTrojanCount);
            this.SetParamSimple(map, prefix + "AbnormalLoginCount", this.AbnormalLoginCount);
            this.SetParamSimple(map, prefix + "HostBehaviorCount", this.HostBehaviorCount);
            this.SetParamSimple(map, prefix + "NetworkBehaviorCount", this.NetworkBehaviorCount);
            this.SetParamSimple(map, prefix + "InstancesCount", this.InstancesCount);
        }
    }
}

