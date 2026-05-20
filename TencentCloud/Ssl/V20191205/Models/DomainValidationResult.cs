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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainValidationResult : AbstractModel
    {
        
        /// <summary>
        /// Domain names bound to the certificate.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain name validation type. Value is DNS, FILE, DNS_AUTO, DNS_PROXY, or FILE_PROXY.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// Tencent Cloud detection result, Value: 1 (verified); -1 (rate limited or txt record not found); -2 (txt record not match); -3 (ns record not found); -4 (file not found); -5 (file not match); -6 (cname record not found); -7 (cname record not match); -8 (ns record not found); -9 (file not found); -10 (file not match).
        /// </summary>
        [JsonProperty("LocalCheck")]
        public long? LocalCheck{ get; set; }

        /// <summary>
        /// CA check result. Value: -1 (detection failed); 2 (detection passed).
        /// </summary>
        [JsonProperty("CaCheck")]
        public long? CaCheck{ get; set; }

        /// <summary>
        /// Check failure reasons. Description of the LocalCheck status.
        /// </summary>
        [JsonProperty("LocalCheckFailReason")]
        public string LocalCheckFailReason{ get; set; }

        /// <summary>
        /// Detected value.
        /// </summary>
        [JsonProperty("CheckValue")]
        public string[] CheckValue{ get; set; }

        /// <summary>
        /// Whether the request is rate-limited. Valid values: false (not rate-limited); true (rate-limited).
        /// </summary>
        [JsonProperty("Frequently")]
        public bool? Frequently{ get; set; }

        /// <summary>
        /// Whether the certificate has been issued. Value: false (not issued); true (issued).
        /// </summary>
        [JsonProperty("Issued")]
        public bool? Issued{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "LocalCheck", this.LocalCheck);
            this.SetParamSimple(map, prefix + "CaCheck", this.CaCheck);
            this.SetParamSimple(map, prefix + "LocalCheckFailReason", this.LocalCheckFailReason);
            this.SetParamArraySimple(map, prefix + "CheckValue.", this.CheckValue);
            this.SetParamSimple(map, prefix + "Frequently", this.Frequently);
            this.SetParamSimple(map, prefix + "Issued", this.Issued);
        }
    }
}

