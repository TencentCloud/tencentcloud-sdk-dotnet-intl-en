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

    public class SecurityHeadersToOrigin : AbstractModel
    {
        
        /// <summary>
        /// <p>Configuration of origin request headers for Bot identification information. Valid values:<ul><li>`EO-Bot-Botnet-ID`: Identifier generated based on Bot request characteristics.</li></ul></p>
        /// </summary>
        [JsonProperty("BotIdentificationHeaders")]
        public string[] BotIdentificationHeaders{ get; set; }

        /// <summary>
        /// <p>Configuration of origin request headers for identification results from the Advanced Bot Management module. Valid values:<ul><li>`EO-Bot-Client-Attestation`: Advanced Bot Management - Authentication ticket verification result from the Client Attestation module;</li><li>`EO-Bot-Client-Risk`: Advanced Bot Management - Device risk assessment result from the Client Attestation module;</li><li>`EO-Bot-Intelligence`: Advanced Bot Management - Identification result from the Bot Intelligence Analysis module;</li><li>`EO-Bot-IP-Reputation`: Advanced Bot Management - Identification result from Client Reputation module;</li><li>`EO-Bot-Known-Tool`: Advanced Bot Management - Basic Feature Management - Identification result from the UA Feature Rule module;</li><li>`EO-Bot-Search-Engine`: Advanced Bot Management - Basic Feature Management - Identification result from the Search Engine Rule module;</li><li>`EO-Bot-Source-IDC`: Advanced Bot Management - Basic Feature Management - Identification result from the IDC Rule module;</li><li>`EO-Bot-User-Risk`: Advanced Bot Management - Account risk assessment result from the Client Attestation module.</li></ul></p>
        /// </summary>
        [JsonProperty("BotManagementHeaders")]
        public string[] BotManagementHeaders{ get; set; }

        /// <summary>
        /// <p>Configuration of origin request headers for client fingerprint information. Valid values:<ul><li>`EO-Bot-Fingerprint`: Client fingerprint information.</li></ul></p>
        /// </summary>
        [JsonProperty("ClientFingerprintHeaders")]
        public string[] ClientFingerprintHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BotIdentificationHeaders.", this.BotIdentificationHeaders);
            this.SetParamArraySimple(map, prefix + "BotManagementHeaders.", this.BotManagementHeaders);
            this.SetParamArraySimple(map, prefix + "ClientFingerprintHeaders.", this.ClientFingerprintHeaders);
        }
    }
}

