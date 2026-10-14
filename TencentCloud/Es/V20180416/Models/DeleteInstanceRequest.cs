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

    public class DeleteInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Recycle bin lock settings. If true, it cannot be manually terminated and will be automatically destroyed after the preset time.</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("LockEnabled")]
        public bool? LockEnabled{ get; set; }

        /// <summary>
        /// <p>Lock time after being put into the recycle bin</p><p>Value range: [1, 7]</p><p>Unit: day</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("LockDuration")]
        public long? LockDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LockEnabled", this.LockEnabled);
            this.SetParamSimple(map, prefix + "LockDuration", this.LockDuration);
        }
    }
}

