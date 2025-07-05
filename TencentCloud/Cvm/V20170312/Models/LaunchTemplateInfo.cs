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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance launch template version number.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestVersionNumber")]
        public ulong? LatestVersionNumber{ get; set; }

        /// <summary>
        /// Instance launch template ID.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// Instance launch template name.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LaunchTemplateName")]
        public string LaunchTemplateName{ get; set; }

        /// <summary>
        /// Default instance launch template version number.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultVersionNumber")]
        public ulong? DefaultVersionNumber{ get; set; }

        /// <summary>
        /// Total number of versions that the instance launch template contains.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LaunchTemplateVersionCount")]
        public ulong? LaunchTemplateVersionCount{ get; set; }

        /// <summary>
        /// UIN of the user who created the template.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// Creation time of the template.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LatestVersionNumber", this.LatestVersionNumber);
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamSimple(map, prefix + "LaunchTemplateName", this.LaunchTemplateName);
            this.SetParamSimple(map, prefix + "DefaultVersionNumber", this.DefaultVersionNumber);
            this.SetParamSimple(map, prefix + "LaunchTemplateVersionCount", this.LaunchTemplateVersionCount);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
        }
    }
}

