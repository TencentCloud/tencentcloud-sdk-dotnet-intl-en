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

    public class AddRecordPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Real-time cloud migration plan name. It supports Chinese, English, digits, _, and -, with a length not exceeding 32 characters. The plan name must be globally unique and cannot be empty or repeated.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Real-time cloud template ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Lifecycle
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// Cloud plan description. Supports only Chinese, English, digits, _, and -. Length not exceeding 128 characters.
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Stream type. default: The stream type is not specified, and the default push type of the device is used. main: Main stream. sub: Substream. Other values are customized based on the device capacity. If not specified, the default type is used. The length cannot exceed 32 bytes.
        /// </summary>
        [JsonProperty("StreamType")]
        public string StreamType{ get; set; }

        /// <summary>
        /// Channel information of the device to which video recording is added. You can add no more than 5000 channels only once, including the number of channels under the organizational unit directory.
        /// </summary>
        [JsonProperty("Channels")]
        public ChannelInfo[] Channels{ get; set; }

        /// <summary>
        /// Add all device channels under the organization. Json array, can be empty. The total number of channels cannot exceed 5,000 (including the number of Channel fields).
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string[] OrganizationId{ get; set; }

        /// <summary>
        /// Video recording supplement mode (0: disabled, 1: enabled). If this field is not specified, it is not enabled by default.
        /// </summary>
        [JsonProperty("RepairMode")]
        public long? RepairMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamArrayObj(map, prefix + "Channels.", this.Channels);
            this.SetParamArraySimple(map, prefix + "OrganizationId.", this.OrganizationId);
            this.SetParamSimple(map, prefix + "RepairMode", this.RepairMode);
        }
    }
}

