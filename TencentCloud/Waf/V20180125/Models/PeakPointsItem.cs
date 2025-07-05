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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PeakPointsItem : AbstractModel
    {
        
        /// <summary>
        /// Second-level Timestamp
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// QPS
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// Upstream bandwidth peak, unit: B
        /// </summary>
        [JsonProperty("Up")]
        public ulong? Up{ get; set; }

        /// <summary>
        /// Downstream bandwidth peak, unit: B
        /// </summary>
        [JsonProperty("Down")]
        public ulong? Down{ get; set; }

        /// <summary>
        /// Web attack count
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// CC attack count
        /// </summary>
        [JsonProperty("Cc")]
        public ulong? Cc{ get; set; }

        /// <summary>
        /// Bot qps
        /// </summary>
        [JsonProperty("BotAccess")]
        public ulong? BotAccess{ get; set; }

        /// <summary>
        /// Number of 5xx status codes returned by WAF to client
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusServerError")]
        public ulong? StatusServerError{ get; set; }

        /// <summary>
        /// Number of times WAF returned 4xx status codes to client
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusClientError")]
        public ulong? StatusClientError{ get; set; }

        /// <summary>
        /// WAF Returned to Client Status Code 302 Count
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusRedirect")]
        public ulong? StatusRedirect{ get; set; }

        /// <summary>
        /// Number of Times WAF Returns Status Code 202 to Client
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusOk")]
        public ulong? StatusOk{ get; set; }

        /// <summary>
        /// Number of Times the Origin Server Returned 5xx Status Codes to WAF
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamServerError")]
        public ulong? UpstreamServerError{ get; set; }

        /// <summary>
        /// Number of times the origin server returned 4xx status codes to WAF
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamClientError")]
        public ulong? UpstreamClientError{ get; set; }

        /// <summary>
        /// Number of times the original server returns status code 302 to WAF
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamRedirect")]
        public ulong? UpstreamRedirect{ get; set; }

        /// <summary>
        /// Blocklist Count
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlackIP")]
        public ulong? BlackIP{ get; set; }

        /// <summary>
        /// Tamper-Proof Attempts
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tamper")]
        public ulong? Tamper{ get; set; }

        /// <summary>
        /// Information Leakage Prevention Count
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Leak")]
        public ulong? Leak{ get; set; }

        /// <summary>
        /// Access control
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ACL")]
        public ulong? ACL{ get; set; }

        /// <summary>
        /// Mini Program QPS
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WxAccess")]
        public ulong? WxAccess{ get; set; }

        /// <summary>
        /// Number of mini program requests
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WxCount")]
        public ulong? WxCount{ get; set; }

        /// <summary>
        /// Peak upstream bandwidth of the mini program. Unit: B
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WxUp")]
        public ulong? WxUp{ get; set; }

        /// <summary>
        /// Peak downstream bandwidth of the mini program. Unit: B
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WxDown")]
        public ulong? WxDown{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "Up", this.Up);
            this.SetParamSimple(map, prefix + "Down", this.Down);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Cc", this.Cc);
            this.SetParamSimple(map, prefix + "BotAccess", this.BotAccess);
            this.SetParamSimple(map, prefix + "StatusServerError", this.StatusServerError);
            this.SetParamSimple(map, prefix + "StatusClientError", this.StatusClientError);
            this.SetParamSimple(map, prefix + "StatusRedirect", this.StatusRedirect);
            this.SetParamSimple(map, prefix + "StatusOk", this.StatusOk);
            this.SetParamSimple(map, prefix + "UpstreamServerError", this.UpstreamServerError);
            this.SetParamSimple(map, prefix + "UpstreamClientError", this.UpstreamClientError);
            this.SetParamSimple(map, prefix + "UpstreamRedirect", this.UpstreamRedirect);
            this.SetParamSimple(map, prefix + "BlackIP", this.BlackIP);
            this.SetParamSimple(map, prefix + "Tamper", this.Tamper);
            this.SetParamSimple(map, prefix + "Leak", this.Leak);
            this.SetParamSimple(map, prefix + "ACL", this.ACL);
            this.SetParamSimple(map, prefix + "WxAccess", this.WxAccess);
            this.SetParamSimple(map, prefix + "WxCount", this.WxCount);
            this.SetParamSimple(map, prefix + "WxUp", this.WxUp);
            this.SetParamSimple(map, prefix + "WxDown", this.WxDown);
        }
    }
}

