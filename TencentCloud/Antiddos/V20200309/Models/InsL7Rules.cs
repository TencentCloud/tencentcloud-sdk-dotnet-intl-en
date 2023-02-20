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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InsL7Rules : AbstractModel
    {
        
        /// <summary>
        /// Rules can only be modified when the status is `0`, `2`, or `8`.
        /// Rule status. Values: `0` (Normal), `1` (Being configured), `2` (Configuration failed), `3` (Being deleted), `5` (Failed to be deleted), `6` (Pending add), `7` (Pending delete), `8` (Pending certificate upload), `9` (Associated resource not exist), `10` (Pending modify), `11` (Being modified).
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Protocol
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InsId")]
        public string InsId{ get; set; }

        /// <summary>
        /// User App ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// High-defense port
        /// </summary>
        [JsonProperty("VirtualPort")]
        public string VirtualPort{ get; set; }

        /// <summary>
        /// Certificate ID
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InsId", this.InsId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "VirtualPort", this.VirtualPort);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
        }
    }
}

