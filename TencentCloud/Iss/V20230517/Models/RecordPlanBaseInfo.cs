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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordPlanBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// Cloud migration plan ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Cloud migration plan name
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Cloud template ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Cloud migration plan description
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Stream type. default: default stream type of the device. main: main stream. sub: substream. Other stream types can be customized based on the device capacity.
        /// </summary>
        [JsonProperty("StreamType")]
        public string StreamType{ get; set; }

        /// <summary>
        /// Cloud file lifecycle
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// Recording schedule status. 1: In normal use. 0: Deleting, cannot be used.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Total number of channels
        /// </summary>
        [JsonProperty("ChannelCount")]
        public long? ChannelCount{ get; set; }

        /// <summary>
        /// Video recording supplement mode (0: not enabled, 1: enabled)
        /// </summary>
        [JsonProperty("RepairMode")]
        public long? RepairMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ChannelCount", this.ChannelCount);
            this.SetParamSimple(map, prefix + "RepairMode", this.RepairMode);
        }
    }
}

