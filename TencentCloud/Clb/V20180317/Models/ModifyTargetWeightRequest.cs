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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTargetWeightRequest : AbstractModel
    {
        
        /// <summary>
        /// CLB instance ID
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CLB listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Forwarding rule ID. When binding a real server to a layer-7 forwarding rule, you must provide either this parameter or Domain+Url
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// Target rule domain name. This parameter does not take effect if LocationId is specified
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Target rule URL. This parameter does not take effect if LocationId is specified
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// List of real servers for which to modify the weight
        /// </summary>
        [JsonProperty("Targets")]
        public Target[] Targets{ get; set; }

        /// <summary>
        /// New forwarding weight of a real server. Value range: 0-100. Default value: 10. If the Targets.Weight parameter is set, this parameter will not take effect.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

