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

    public class UpdateRecordPlanData : AbstractModel
    {
        
        /// <summary>
        /// Cloud migration plan name, supporting only Chinese, English, digits, _, -, with a length not exceeding 32 characters. The plan name must be globally unique and cannot be empty or duplicated. This field is not required if the name is not modified.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Cloud template ID. This field is not required if the template ID is not modified.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Usage plan description. It can contain only Chinese characters, English letters, digits, underscores (_), and hyphens (-), with a length not exceeding 128 characters. This field is not required if you do not modify the description.
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Stream type. default: The stream type is not specified, and the default push type of the device is used. main: main stream. sub: substream. Other: custom based on the device capability set. The length cannot exceed 32 bytes.
        /// </summary>
        [JsonProperty("StreamType")]
        public string StreamType{ get; set; }

        /// <summary>
        /// Lifecycle, file lifecycle settings, the time when cold and hot storage of files is managed. This field is not required if lifecycle is not modified.
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// Device channels to be added. Json array. This field is not required when no channels are added. The total number of channels added at once cannot exceed 5,000, including the number of channels under the organization directory.
        /// </summary>
        [JsonProperty("Add")]
        public ChannelInfo[] Add{ get; set; }

        /// <summary>
        /// Device channels to delete. Json array. The content is the IDs of the device channels to delete. This field is not required if no device channel is deleted.
        /// </summary>
        [JsonProperty("Del")]
        public string[] Del{ get; set; }

        /// <summary>
        /// Organizational directory ID. Add all device channels under the organizational directory. Json array. Can be empty. And the total number of channels is no more than 5,000 (including the number of channels added in the Add field).
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string[] OrganizationId{ get; set; }

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
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamArrayObj(map, prefix + "Add.", this.Add);
            this.SetParamArraySimple(map, prefix + "Del.", this.Del);
            this.SetParamArraySimple(map, prefix + "OrganizationId.", this.OrganizationId);
            this.SetParamSimple(map, prefix + "RepairMode", this.RepairMode);
        }
    }
}

