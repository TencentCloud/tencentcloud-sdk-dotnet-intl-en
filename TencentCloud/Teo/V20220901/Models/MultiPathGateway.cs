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
        /// Gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Gateway name.
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// Gateway type. Valid values:
        /// <li> cloud: Cloud Gateway, a gateway created and managed by Tencent Cloud.</li>
        /// <li> private: private gateway, a Private Gateway deployed by the user.</li>
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Gateway port. Range: 1–65535 (excluding 8888).
        /// </summary>
        [JsonProperty("GatewayPort")]
        public long? GatewayPort{ get; set; }

        /// <summary>
        /// Gateway status. Valid values:
        /// <li> creating : Creating;</li>
        /// <li> online : Online;</li>
        /// <li> offline : Offline;</li>
        /// <li> disable : disabled.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Gateway IP in IPv4 format.
        /// </summary>
        [JsonProperty("GatewayIP")]
        public string GatewayIP{ get; set; }

        /// <summary>
        /// Gateway region ID. You can obtain the RegionId list through the DescribeMultiPathGatewayRegions API.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Line information. It will be returned when querying gateway information details via DescribeMultiPathGateway, but not when querying the gateway list via DescribeMultiPathGateways.
        /// </summary>
        [JsonProperty("Lines")]
        public MultiPathGatewayLine[] Lines{ get; set; }

        /// <summary>
        /// Whether the origin-pull IP list of the gateway has changed and needs confirmation. Valid values: <li>true: The origin-pull IP list has changed and needs confirmation;</li><li>false: The origin-pull IP list has not changed and does not need confirmation.</li>
        /// </summary>
        [JsonProperty("NeedConfirm")]
        public string NeedConfirm{ get; set; }


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
            this.SetParamSimple(map, prefix + "NeedConfirm", this.NeedConfirm);
        }
    }
}

