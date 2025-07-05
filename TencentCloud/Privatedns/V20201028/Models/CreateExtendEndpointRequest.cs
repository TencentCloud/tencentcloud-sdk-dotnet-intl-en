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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExtendEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// Outbound endpoint name.
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// The region of the outbound endpoint must be consistent with the region of the forwarding target VIP.
        /// </summary>
        [JsonProperty("EndpointRegion")]
        public string EndpointRegion{ get; set; }

        /// <summary>
        /// Forwarding target.
        /// </summary>
        [JsonProperty("ForwardIp")]
        public ForwardIp ForwardIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "EndpointRegion", this.EndpointRegion);
            this.SetParamObj(map, prefix + "ForwardIp.", this.ForwardIp);
        }
    }
}

