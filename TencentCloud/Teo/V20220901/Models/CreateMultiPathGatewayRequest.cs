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

    public class CreateMultiPathGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Gateway type. valid values:
        /// <Li> Cloud: cloud gateway, a gateway created and managed by Tencent cloud;</li>
        /// <Li>Private: private gateway, a user-deployed private gateway.</li>
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Gateway name: up to 16 characters, allowed characters (a-z, A-Z, 0-9, -, _).
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// Gateway port: value range: 1-65535 (excluding 8888).
        /// </summary>
        [JsonProperty("GatewayPort")]
        public long? GatewayPort{ get; set; }

        /// <summary>
        /// Gateway region: GatewayType value is cloud (cloud gateway). required. RegionId list can be obtained from the DescribeMultiPathGatewayRegions API.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Gateway address (required when GatewayType=private):
        /// Before using this address, ensure it has been registered in the Tencent Cloud Multi-Path Security Acceleration Gateway system. 
        /// If not registered, submit a support ticket or contact your architect to pre-register the gateway IP address in the system before API invocation.
        /// </summary>
        [JsonProperty("GatewayIP")]
        public string GatewayIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "GatewayPort", this.GatewayPort);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "GatewayIP", this.GatewayIP);
        }
    }
}

