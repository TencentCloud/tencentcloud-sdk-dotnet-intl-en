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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEndpointGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Listener ID.</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Node group type.</p><p>Enumeration values:</p><ul><li>VIRTUAL: custom endpoint node group</li><li>DEFAULT: default terminal node group</li></ul>
        /// </summary>
        [JsonProperty("EndpointGroupType")]
        public string EndpointGroupType{ get; set; }

        /// <summary>
        /// <p>Terminal node group configuration.</p>
        /// </summary>
        [JsonProperty("EndpointGroupConfiguration")]
        public EndpointGroupConfiguration EndpointGroupConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "EndpointGroupType", this.EndpointGroupType);
            this.SetParamObj(map, prefix + "EndpointGroupConfiguration.", this.EndpointGroupConfiguration);
        }
    }
}

