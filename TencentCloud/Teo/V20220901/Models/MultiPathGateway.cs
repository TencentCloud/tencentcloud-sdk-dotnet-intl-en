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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiPathGateway : AbstractModel
    {
        
        /// <summary>
        /// Specifies the gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Gateway name.
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// Gateway type. valid values:
        /// <Li>Cloud: cloud gateway,  created and managed by Tencent cloud.</li>
        /// <Li>Private: private gateway, deployed by cutomer.</li>
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Gateway port. value range: 1-65535 (excluding 8888).
        /// </summary>
        [JsonProperty("GatewayPort")]
        public long? GatewayPort{ get; set; }

        /// <summary>
        /// Gateway status. valid values:
        /// <Li>creating: The gateway is being created. </li>
        /// <Li>online: The gateway is online and operational.</li>
        /// <Li>offline: The gateway is offline and unavailable.</li>
        /// <Li>disabled: The gateway has been disabled.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Gateway IP, in IPv4 format.
        /// </summary>
        [JsonProperty("GatewayIP")]
        public string GatewayIP{ get; set; }

        /// <summary>
        /// Gateway region Id. which can be obtained from the DescribeMultiPathGatewayRegions API.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Line information. The line information will be returned when querying gateway information with DescribeMultiPathGateway ande not returned when querying the gateway list with DescribeMultiPathGateways.
        /// </summary>
        [JsonProperty("Lines")]
        public MultiPathGatewayLine[] Lines{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayPort", this.GatewayPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GatewayIP", this.GatewayIP);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamArrayObj(map, prefix + "Lines.", this.Lines);
        }
    }
}

