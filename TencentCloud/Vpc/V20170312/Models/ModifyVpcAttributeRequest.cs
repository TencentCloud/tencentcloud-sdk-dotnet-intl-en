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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVpcAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC instance ID, in the format of vpc-f49l6u0z.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC can be named freely, but the maximum length is 60 characters.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// Whether multicast is enabled. `true`: Enabled. `false`: Off.
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public string EnableMulticast{ get; set; }

        /// <summary>
        /// DNS address. A maximum of 4 addresses is supported. The first one is primary server by default, and the rest are secondary servers.
        /// </summary>
        [JsonProperty("DnsServers")]
        public string[] DnsServers{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Vpc association with CCN route publish policy. true enables cidr route publishing. false enables subnet route publishing. the default is subnet route publishing when creating a vpc. to use cidr route publishing, submit a ticket to add to allowlist.
        /// </summary>
        [JsonProperty("EnableRouteVpcPublish")]
        public bool? EnableRouteVpcPublish{ get; set; }

        /// <summary>
        /// Whether to publish the CDC subnet to CCN. `true`: Publish; `false`: Do not publish
        /// </summary>
        [JsonProperty("EnableCdcPublish")]
        public bool? EnableCdcPublish{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamArraySimple(map, prefix + "DnsServers.", this.DnsServers);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "EnableRouteVpcPublish", this.EnableRouteVpcPublish);
            this.SetParamSimple(map, prefix + "EnableCdcPublish", this.EnableCdcPublish);
        }
    }
}

