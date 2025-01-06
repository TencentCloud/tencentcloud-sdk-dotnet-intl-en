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

    public class EndpointService : AbstractModel
    {
        
        /// <summary>
        /// Specifies the forwarding target IP network access type.
        /// CLB: Specifies that the forwarding IP is the private CLB VIP.
        /// CCN: Specifies forwarding IP through CCN routing.
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// Specifies the forwarding target IP address.
        /// </summary>
        [JsonProperty("Pip")]
        public string Pip{ get; set; }

        /// <summary>
        /// Specifies the forwarding IP port number.
        /// </summary>
        [JsonProperty("Pport")]
        public long? Pport{ get; set; }

        /// <summary>
        /// Specifies the unique VPC ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Specifies the forwarding target IP proxy IP.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Specifies the forwarding target IP proxy port.
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// Specifies the forwarding target IP protocol.
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// Specifies the unique subnet ID.
        /// Required if the access type is CCN.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// ccn id
        /// Required if the access type is CCN.
        /// </summary>
        [JsonProperty("AccessGatewayId")]
        public string AccessGatewayId{ get; set; }

        /// <summary>
        /// The SNAT CIDR block of the outbound endpoint.
        /// </summary>
        [JsonProperty("SnatVipCidr")]
        public string SnatVipCidr{ get; set; }

        /// <summary>
        /// The SNAT IP list of the outbound endpoint.
        /// </summary>
        [JsonProperty("SnatVipSet")]
        public string SnatVipSet{ get; set; }

        /// <summary>
        /// The region of the outbound endpoint service.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Pip", this.Pip);
            this.SetParamSimple(map, prefix + "Pport", this.Pport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "AccessGatewayId", this.AccessGatewayId);
            this.SetParamSimple(map, prefix + "SnatVipCidr", this.SnatVipCidr);
            this.SetParamSimple(map, prefix + "SnatVipSet", this.SnatVipSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

