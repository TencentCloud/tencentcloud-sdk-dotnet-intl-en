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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// Activity ID
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }

        /// <summary>
        /// Compute node ID
        /// </summary>
        [JsonProperty("ComputeNodeId")]
        public string ComputeNodeId{ get; set; }

        /// <summary>
        /// Compute node activity type: creation or termination
        /// </summary>
        [JsonProperty("ComputeNodeActivityType")]
        public string ComputeNodeActivityType{ get; set; }

        /// <summary>
        /// Compute environment ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// Cause
        /// </summary>
        [JsonProperty("Cause")]
        public string Cause{ get; set; }

        /// <summary>
        /// Active status
        /// </summary>
        [JsonProperty("ActivityState")]
        public string ActivityState{ get; set; }

        /// <summary>
        /// State reason
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// Activity start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Activity end time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// CVM instance ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ComputeNodeId", this.ComputeNodeId);
            this.SetParamSimple(map, prefix + "ComputeNodeActivityType", this.ComputeNodeActivityType);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Cause", this.Cause);
            this.SetParamSimple(map, prefix + "ActivityState", this.ActivityState);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

