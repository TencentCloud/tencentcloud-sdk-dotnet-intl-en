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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchTemplateVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance launch template version number.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LaunchTemplateVersion")]
        public ulong? LaunchTemplateVersion{ get; set; }

        /// <summary>
        /// Details of instance launch template versions.
        /// </summary>
        [JsonProperty("LaunchTemplateVersionData")]
        public LaunchTemplateVersionData LaunchTemplateVersionData{ get; set; }

        /// <summary>
        /// Creation time of the instance launch template version.
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Instance launch template ID.
        /// </summary>
        [JsonProperty("LaunchTemplateId")]
        public string LaunchTemplateId{ get; set; }

        /// <summary>
        /// Specifies whether it’s the default launch template version.
        /// </summary>
        [JsonProperty("IsDefaultVersion")]
        public bool? IsDefaultVersion{ get; set; }

        /// <summary>
        /// Information of instance launch template version description.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LaunchTemplateVersionDescription")]
        public string LaunchTemplateVersionDescription{ get; set; }

        /// <summary>
        /// Creator account
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchTemplateVersion", this.LaunchTemplateVersion);
            this.SetParamObj(map, prefix + "LaunchTemplateVersionData.", this.LaunchTemplateVersionData);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LaunchTemplateId", this.LaunchTemplateId);
            this.SetParamSimple(map, prefix + "IsDefaultVersion", this.IsDefaultVersion);
            this.SetParamSimple(map, prefix + "LaunchTemplateVersionDescription", this.LaunchTemplateVersionDescription);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
        }
    }
}

