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

    public class XForwardedForConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to get the CLB instance ID through the ALB-ID header field.
        /// - **true**: Yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XForwardedForAlbIdEnabled")]
        public bool? XForwardedForAlbIdEnabled{ get; set; }

        /// <summary>
        /// Whether to obtain the port of the client accessing the load balancing instance through the X-Forwarded-Client-srcport header field.
        /// - **true**: Yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XForwardedForClientSrcPortEnabled")]
        public bool? XForwardedForClientSrcPortEnabled{ get; set; }

        /// <summary>
        /// Whether to enable obtaining the client domain name that accesses the load balancing instance through the X-Forwarded-Host header field.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XForwardedForHostEnabled")]
        public bool? XForwardedForHostEnabled{ get; set; }

        /// <summary>
        /// Specify how to handle the X-Forwarded-For (XFF) HTTP header field.
        /// - **append**: Append mode (default). Appends the real IP of the client to the end of the X-Forwarded-For header, retaining the original XFF link information.
        /// -**remove**: Deletion mode. Remove the X-Forwarded-For header field and do not pass this header to the real server.
        /// - **passthrough**: Passthrough mode. The X-Forwarded-For header remains unchanged and is directly passed through to the real server without any modification.
        /// </summary>
        [JsonProperty("XForwardedForMode")]
        public string XForwardedForMode{ get; set; }

        /// <summary>
        /// Whether to obtain the listening port of the load balancing instance through the X-Forwarded-Port header field.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XForwardedForPortEnabled")]
        public bool? XForwardedForPortEnabled{ get; set; }

        /// <summary>
        /// Whether to obtain the listening protocol of the load balancing instance through the X-Forwarded-Proto header field.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XForwardedForProtoEnabled")]
        public bool? XForwardedForProtoEnabled{ get; set; }

        /// <summary>
        /// Whether to access the issuer of the client certificate $ssl_client_i_dn through the X-Tencent-Client-IDN header.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XTencentClientIDNEnabled")]
        public bool? XTencentClientIDNEnabled{ get; set; }

        /// <summary>
        /// Whether to access the subject of the client certificate $ssl_client_s_dn through the X-Tencent-Client-SDN header.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XTencentClientSDNEnabled")]
        public bool? XTencentClientSDNEnabled{ get; set; }

        /// <summary>
        /// Whether to access the serial number $ssl_client_serial of the client certificate through the X-Tencent-Client-Serial header.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XTencentClientSerialEnabled")]
        public bool? XTencentClientSerialEnabled{ get; set; }

        /// <summary>
        /// Access the verification result $ssl_client_verify of the client certificate through the X-Tencent-Client-Verify header.
        /// - **true**: yes.
        /// - **false**: No.
        /// </summary>
        [JsonProperty("XTencentClientVerifyEnabled")]
        public bool? XTencentClientVerifyEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "XForwardedForAlbIdEnabled", this.XForwardedForAlbIdEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForClientSrcPortEnabled", this.XForwardedForClientSrcPortEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForHostEnabled", this.XForwardedForHostEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForMode", this.XForwardedForMode);
            this.SetParamSimple(map, prefix + "XForwardedForPortEnabled", this.XForwardedForPortEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForProtoEnabled", this.XForwardedForProtoEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientIDNEnabled", this.XTencentClientIDNEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientSDNEnabled", this.XTencentClientSDNEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientSerialEnabled", this.XTencentClientSerialEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientVerifyEnabled", this.XTencentClientVerifyEnabled);
        }
    }
}

