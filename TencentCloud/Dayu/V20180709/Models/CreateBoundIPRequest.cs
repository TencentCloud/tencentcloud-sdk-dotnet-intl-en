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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBoundIPRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgp`: Anti-DDoS Pro (Single IP); `bgp-multip`: Anti-DDoS Pro (Multi-IP)
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Array of IPs to be bound to the Anti-DDoS instance. For Anti-DDoS Pro Single IP instance, this array can contain only one IP. If there are no IPs to bind, it can be empty; however, either `BoundDevList` or `UnBoundDevList` must not be empty;
        /// </summary>
        [JsonProperty("BoundDevList")]
        public BoundIpInfo[] BoundDevList{ get; set; }

        /// <summary>
        /// Array of IPs to be unbound from Anti-DDoS instance. For Anti-DDoS Pro Single IP instance, this array can contain only one IP; if there are no IPs to unbind, it can be empty; however, either `BoundDevList` or `UnBoundDevList` must not be empty;
        /// </summary>
        [JsonProperty("UnBoundDevList")]
        public BoundIpInfo[] UnBoundDevList{ get; set; }

        /// <summary>
        /// [Disused]
        /// </summary>
        [JsonProperty("CopyPolicy")]
        public string CopyPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "BoundDevList.", this.BoundDevList);
            this.SetParamArrayObj(map, prefix + "UnBoundDevList.", this.UnBoundDevList);
            this.SetParamSimple(map, prefix + "CopyPolicy", this.CopyPolicy);
        }
    }
}

