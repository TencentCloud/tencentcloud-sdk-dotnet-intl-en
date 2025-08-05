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

    public class ModifyMultiPathGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Specifies the gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Gateway name, up to 16 characters, allowed characters (a-z, A-Z, 0-9, -, _).
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// Gateway address, if GatewayType value is private (private gateway), you can fill in and modify it. When using this address, please ensure it has been entered into the Tencent cloud multi-channel security acceleration gateway system. if not entered, you need to submit a ticket or contact the architect to enter the gateway IP address into the Tencent cloud multi-channel security acceleration gateway system in advance before making API calls.
        /// </summary>
        [JsonProperty("GatewayIP")]
        public string GatewayIP{ get; set; }

        /// <summary>
        /// Gateway port, range 1-65535 (excluding 8888), supports modifying GatewayType with a value of private gateway.
        /// </summary>
        [JsonProperty("GatewayPort")]
        public long? GatewayPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "GatewayIP", this.GatewayIP);
            this.SetParamSimple(map, prefix + "GatewayPort", this.GatewayPort);
        }
    }
}

