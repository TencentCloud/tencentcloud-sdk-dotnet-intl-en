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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceProductVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Target product type for the update.</p><p>Enumeration values:</p><ul><li>localv2: General Type II</li></ul>
        /// </summary>
        [JsonProperty("TargetProductVersion")]
        public string TargetProductVersion{ get; set; }

        /// <summary>
        /// <p>Switch time.</p><ul><li>1: Switch during maintenance window.</li><li>2: Switch immediately.</li></ul>
        /// </summary>
        [JsonProperty("SwitchOption")]
        public long? SwitchOption{ get; set; }

        /// <summary>
        /// <p>Specifies the instance ID. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis#/">Redis console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetProductVersion", this.TargetProductVersion);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

