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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7RuleEntry : AbstractModel
    {
        
        /// <summary>
        /// Forwarding protocol. Valid values: [http, https]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Forwarding domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Forwarding method. Valid values: [1 (forwarding via domain name), 2 (forwarding via IP)]
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// Session persistence duration in seconds
        /// </summary>
        [JsonProperty("KeepTime")]
        public ulong? KeepTime{ get; set; }

        /// <summary>
        /// Forward list
        /// </summary>
        [JsonProperty("SourceList")]
        public L4RuleSource[] SourceList{ get; set; }

        /// <summary>
        /// Load balancing method. Valid value: [1 (weighted round robin)]
        /// </summary>
        [JsonProperty("LbType")]
        public ulong? LbType{ get; set; }

        /// <summary>
        /// Session persistence status. Valid values: [0 (disabled), 1 (enabled)]
        /// </summary>
        [JsonProperty("KeepEnable")]
        public ulong? KeepEnable{ get; set; }

        /// <summary>
        /// Rule ID, which is optional when adding a new rule but required when modifying or deleting a rule;
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Certificate source, which is required if the forwarding protocol is HTTPS. Valid value: [2 (Tencent Cloud-hosted certificate)]. If the forwarding protocol is HTTP, 0 can be entered for this field
        /// </summary>
        [JsonProperty("CertType")]
        public ulong? CertType{ get; set; }

        /// <summary>
        /// If the certificate is a Tencent Cloud-hosted certificate, this field must be entered with the hosted certificate ID
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// If the certificate is an external certificate, this field must be entered with the certificate content. (As external certificates are no longer supported, this field has been disused and does not need to be entered)
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// If the certificate is an external certificate, this field must be entered with the certificate key. (As external certificates are no longer supported, this field has been disused and does not need to be entered)
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule status. Valid values: [0 (successfully configured rule), 1 (rule configuration taking effect), 2 (rule configuration failed), 3 (rule deletion taking effect), 5 (rule deletion failed), 6 (rule waiting for configuration), 7 (rule waiting for deletion), 8 (rule waiting for certificate configuration)]
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// CC protection status. Valid values: [0 (disabled), 1 (enabled)]
        /// </summary>
        [JsonProperty("CCStatus")]
        public ulong? CCStatus{ get; set; }

        /// <summary>
        /// HTTPS CC protection status. Valid values: [0 (disabled), 1 (enabled)]
        /// </summary>
        [JsonProperty("CCEnable")]
        public ulong? CCEnable{ get; set; }

        /// <summary>
        /// HTTPS CC protection threshold
        /// </summary>
        [JsonProperty("CCThreshold")]
        public ulong? CCThreshold{ get; set; }

        /// <summary>
        /// HTTPS CC protection level
        /// </summary>
        [JsonProperty("CCLevel")]
        public string CCLevel{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HttpsToHttpEnable")]
        public ulong? HttpsToHttpEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
            this.SetParamArrayObj(map, prefix + "SourceList.", this.SourceList);
            this.SetParamSimple(map, prefix + "LbType", this.LbType);
            this.SetParamSimple(map, prefix + "KeepEnable", this.KeepEnable);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CCStatus", this.CCStatus);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
            this.SetParamSimple(map, prefix + "CCThreshold", this.CCThreshold);
            this.SetParamSimple(map, prefix + "CCLevel", this.CCLevel);
            this.SetParamSimple(map, prefix + "HttpsToHttpEnable", this.HttpsToHttpEnable);
        }
    }
}

