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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutboundEndpoint : AbstractModel
    {
        
        /// <summary>
        /// Outbound endpoint ID.
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// Outbound endpoint name.
        /// </summary>
        [JsonProperty("EndpointName")]
        public string EndpointName{ get; set; }

        /// <summary>
        /// The region of the outbound endpoint.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Outbound endpoint information.
        /// Returned only when the forwarding architecture is V2R.
        /// </summary>
        [JsonProperty("EndpointServiceSet")]
        public EndpointService[] EndpointServiceSet{ get; set; }

        /// <summary>
        /// Forwarding link architecture.
        /// V2V: privatelink
        /// V2R: jnsgw
        /// </summary>
        [JsonProperty("ForwardLinkArch")]
        public string ForwardLinkArch{ get; set; }

        /// <summary>
        /// Endpoint service ID.
        /// 
        /// Returned only when the forwarding architecture is V2V.
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// VIP list of the endpoint.
        /// 
        /// Returned only when the forwarding architecture is V2V.
        /// </summary>
        [JsonProperty("EndPointVipSet")]
        public string[] EndPointVipSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "EndpointName", this.EndpointName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "EndpointServiceSet.", this.EndpointServiceSet);
            this.SetParamSimple(map, prefix + "ForwardLinkArch", this.ForwardLinkArch);
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamArraySimple(map, prefix + "EndPointVipSet.", this.EndPointVipSet);
        }
    }
}

