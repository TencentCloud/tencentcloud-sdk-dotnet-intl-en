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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Resource group ID</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>Resource group name.</p>
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>Resource group status</p><p>Parameter format: 0 // not specified 1 // to be created 2 // creating 3 // running 4 // stopped 5 // stopping 6 // starting 7 // updating 8 // deleting 9 // deleted 10 // user proactive start / automatic startup (task submitted and auto start/stop enabled) 11 // available: unique to data computing 12 // unavailable: unique to data computing 13 // failure</p>
        /// </summary>
        [JsonProperty("ResourceGroupStatus")]
        public string ResourceGroupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "ResourceGroupStatus", this.ResourceGroupStatus);
        }
    }
}

