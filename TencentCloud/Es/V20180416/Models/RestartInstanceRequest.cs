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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Whether to force restart<li>true: force restart</li><li>false: do not force restart</li>Default value: false</p>
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// <p>Restart mode: 0 rolling restart; 1 full restart</p>
        /// </summary>
        [JsonProperty("RestartMode")]
        public long? RestartMode{ get; set; }

        /// <summary>
        /// <p>Select whether to upgrade the kernel patch version upon restart</p>
        /// </summary>
        [JsonProperty("UpgradeKernel")]
        public bool? UpgradeKernel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamSimple(map, prefix + "RestartMode", this.RestartMode);
            this.SetParamSimple(map, prefix + "UpgradeKernel", this.UpgradeKernel);
        }
    }
}

