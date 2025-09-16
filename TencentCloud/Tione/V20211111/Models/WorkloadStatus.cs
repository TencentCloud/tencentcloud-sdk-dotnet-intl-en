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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadStatus : AbstractModel
    {
        
        /// <summary>
        /// Number of current instances.
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// Number of updated instances.
        /// </summary>
        [JsonProperty("UpdatedReplicas")]
        public long? UpdatedReplicas{ get; set; }

        /// <summary>
        /// Number of ready instances.
        /// </summary>
        [JsonProperty("ReadyReplicas")]
        public long? ReadyReplicas{ get; set; }

        /// <summary>
        /// Number of available instances.
        /// </summary>
        [JsonProperty("AvailableReplicas")]
        public long? AvailableReplicas{ get; set; }

        /// <summary>
        /// Number of unavailable instances.
        /// </summary>
        [JsonProperty("UnavailableReplicas")]
        public long? UnavailableReplicas{ get; set; }

        /// <summary>
        /// Normal: running.Abnormal: service abnormalities, such as container startup failure.Waiting: service waiting, such as container image pulling.Stopped: stopped.Pending: starting.Stopping: stopping.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Workload status information.
        /// </summary>
        [JsonProperty("StatefulSetCondition")]
        [System.Obsolete]
        public StatefulSetCondition[] StatefulSetCondition{ get; set; }

        /// <summary>
        /// Status information of workload history.
        /// </summary>
        [JsonProperty("Conditions")]
        public StatefulSetCondition[] Conditions{ get; set; }

        /// <summary>
        /// Display the reason when the status is abnormal.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "UpdatedReplicas", this.UpdatedReplicas);
            this.SetParamSimple(map, prefix + "ReadyReplicas", this.ReadyReplicas);
            this.SetParamSimple(map, prefix + "AvailableReplicas", this.AvailableReplicas);
            this.SetParamSimple(map, prefix + "UnavailableReplicas", this.UnavailableReplicas);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "StatefulSetCondition.", this.StatefulSetCondition);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

