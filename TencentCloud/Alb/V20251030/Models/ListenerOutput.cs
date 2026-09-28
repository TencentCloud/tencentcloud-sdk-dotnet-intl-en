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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListenerOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether mutual authentication is enabled.</p>
        /// </summary>
        [JsonProperty("CaEnable")]
        public bool? CaEnable{ get; set; }

        /// <summary>
        /// <p>Creation time of the listener instance. Format: ISO 8601 (for example, 2025-01-01T08:30:00+08:00)</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Whether to enable Gzip compression.</p>
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// <p>Whether to enable http/2.</p>
        /// </summary>
        [JsonProperty("Http2Enable")]
        public bool? Http2Enable{ get; set; }

        /// <summary>
        /// <p>Idle timeout period.</p>
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// <p>Listener ID, format: lst- followed by 8 alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Listener name.</p>
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// <p>Listener port.</p>
        /// </summary>
        [JsonProperty("ListenerPort")]
        public ulong? ListenerPort{ get; set; }

        /// <summary>
        /// <p>Listener protocol.</p>
        /// </summary>
        [JsonProperty("ListenerProtocol")]
        public string ListenerProtocol{ get; set; }

        /// <summary>
        /// <p>Listener status. Value:</p><ul><li><strong>Active</strong>: Running.</li><li><strong>Provisioning</strong>: Creating.</li><li><strong>Configuring</strong>: Modifying configuration.</li><li><strong>ProvisionFailed</strong>: Creation failed</li></ul>
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public string ListenerStatus{ get; set; }

        /// <summary>
        /// <p>Last change time of the listener instance. Format: ISO 8601 (for example, 2025-01-01T08:30:00+08:00)</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>Connection request timeout period.</p>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Security policy ID.</p>
        /// </summary>
        [JsonProperty("TlsSecurityPolicyId")]
        public string TlsSecurityPolicyId{ get; set; }

        /// <summary>
        /// <p>XForwardedFor configuration.</p>
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaEnable", this.CaEnable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enable", this.Http2Enable);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "ListenerProtocol", this.ListenerProtocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TlsSecurityPolicyId", this.TlsSecurityPolicyId);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
        }
    }
}

