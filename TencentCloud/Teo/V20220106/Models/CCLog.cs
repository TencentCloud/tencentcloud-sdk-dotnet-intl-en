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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCLog : AbstractModel
    {
        
        /// <summary>
        /// Attack time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackTime")]
        public ulong? AttackTime{ get; set; }

        /// <summary>
        /// Attack source IP
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackSip")]
        public string AttackSip{ get; set; }

        /// <summary>
        /// Attack domain name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AttackDomain")]
        public string AttackDomain{ get; set; }

        /// <summary>
        /// Request URI
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestUri")]
        public string RequestUri{ get; set; }

        /// <summary>
        /// Number of hits
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HitCount")]
        public ulong? HitCount{ get; set; }

        /// <summary>
        /// IP country/region
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SipCountryCode")]
        public string SipCountryCode{ get; set; }

        /// <summary>
        /// Event ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// Processing method
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DisposalMethod")]
        public string DisposalMethod{ get; set; }

        /// <summary>
        /// http_log
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpLog")]
        public string HttpLog{ get; set; }

        /// <summary>
        /// Rule number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Risk grade
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttackTime", this.AttackTime);
            this.SetParamSimple(map, prefix + "AttackSip", this.AttackSip);
            this.SetParamSimple(map, prefix + "AttackDomain", this.AttackDomain);
            this.SetParamSimple(map, prefix + "RequestUri", this.RequestUri);
            this.SetParamSimple(map, prefix + "HitCount", this.HitCount);
            this.SetParamSimple(map, prefix + "SipCountryCode", this.SipCountryCode);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "DisposalMethod", this.DisposalMethod);
            this.SetParamSimple(map, prefix + "HttpLog", this.HttpLog);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
        }
    }
}

