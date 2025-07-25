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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployRecord : AbstractModel
    {
        
        /// <summary>
        /// Details about the released version.
        /// </summary>
        [JsonProperty("ConfigGroupVersionInfos")]
        public ConfigGroupVersionInfo[] ConfigGroupVersionInfos{ get; set; }

        /// <summary>
        /// Release time. The time format follows the ISO 8601 standard and is represented in Coordinated Universal Time (UTC).
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// Release status. Valid values: 
        /// <li>deploying: Being released.</li>
        /// <li>failure: Release failed.</li>
        /// <li>success: Released successfully. </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Release result information.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Release record ID. 
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Change description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ConfigGroupVersionInfos.", this.ConfigGroupVersionInfos);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

