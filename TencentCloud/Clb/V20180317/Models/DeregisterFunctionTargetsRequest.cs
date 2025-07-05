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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeregisterFunctionTargetsRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB listener ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// List of functions to be unbound
        /// </summary>
        [JsonProperty("FunctionTargets")]
        public FunctionTarget[] FunctionTargets{ get; set; }

        /// <summary>
        /// The ID of target forwarding rule. To unbind a function from an L7 forwarding rule, either `LocationId` or `Domain+Url` is required. 
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// Domain name of the target forwarding rule. It is ignored if `LocationId` is specified. 
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// URL of the target forwarding rule. It is ignored if `LocationId` is specified. 
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArrayObj(map, prefix + "FunctionTargets.", this.FunctionTargets);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

