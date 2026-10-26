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

    public class UpdateRecordBackupPlanModify : AbstractModel
    {
        
        /// <summary>
        /// Recording cloud migration plan name (supports only Chinese, English, digits, _, and -, length not exceeding 32 characters. The plan name must be globally unique and cannot be empty or repeated. This field is not required if the name is not modified.)
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Recording template ID (obtain from the ListRecordBackupTemplates API for querying the video recording upload template list. This field is not required if the template ID is not modified)
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Recording cloud migration plan description (only supports Chinese, English, numbers, _, -, length not exceeding 128 characters. This field is not required if the description is not modified)
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// Lifecycle (lifecycle settings for video recording files, managing the time when files are in cold or hot storage. This field is not required if you do not modify the lifecycle)
        /// </summary>
        [JsonProperty("LifeCycle")]
        public LifeCycleData LifeCycle{ get; set; }

        /// <summary>
        /// Device channels to be added (Json array; not required when no channels are added; the total number of channels added at once cannot exceed 5000, including the number of channels under the organizational directory)
        /// </summary>
        [JsonProperty("Add")]
        public ChannelInfo[] Add{ get; set; }

        /// <summary>
        /// Device channel to delete (Json array containing the IDs of device channels to delete. Not required if no device channel is deleted)
        /// </summary>
        [JsonProperty("Del")]
        public string[] Del{ get; set; }

        /// <summary>
        /// Add the channels of all devices under the organizational unit (Json array, can be empty, and the total number of channels no more than 5000, including the number of channels in the Add field)
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string[] OrganizationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamObj(map, prefix + "LifeCycle.", this.LifeCycle);
            this.SetParamArrayObj(map, prefix + "Add.", this.Add);
            this.SetParamArraySimple(map, prefix + "Del.", this.Del);
            this.SetParamArraySimple(map, prefix + "OrganizationId.", this.OrganizationId);
        }
    }
}

