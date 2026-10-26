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

    public class AddRecordBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Recording template ID (template ID associated with the recording schedule, obtained from the ListRecordBackupTemplates API for querying the video cloud template list)
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Recording schedule name (supports Chinese, English, digits, _ and -. The length cannot exceed 32 characters. The plan name must be globally unique and cannot be empty or duplicated.)
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Video recording plan description (only supports Chinese, English, digits, _, -, length not exceeding 128 characters)
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Lifecycle (video recording file lifecycle settings, the time when cold and hot storage is managed for files)
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// Channel and the device to which the channel belongs (channel information of the device to which a video recording is added. Add no more than 5,000 channels at a time, including the number of channels under the organizational unit directory).
        /// </summary>
        [JsonProperty("Channels")]
        public ChannelInfo[] Channels{ get; set; }

        /// <summary>
        /// Add all device channels under the organizational unit directory (Json array, can be empty, total number of channels no more than 5000, including the number of Channel fields)
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string[] OrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamArrayObj(map, prefix + "Channels.", this.Channels);
            this.SetParamArraySimple(map, prefix + "OrganizationId.", this.OrganizationId);
        }
    }
}

