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

    public class ApplicationProxyRule : AbstractModel
    {
        
        /// <summary>
        /// Protocol. Valid values:
        /// <li>TCP: TCP protocol;</li>
        /// <li>UDP: UDP protocol.</li>
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// Port. Supported formats:
        /// <li>A single port, such as 80.</li>
        /// <li>A port range, such as 81-82, indicating two ports 81 and 82.</li>
        /// Note: Up to 20 ports can be input for each rule.
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// Origin server type. Valid values:
        /// <li>custom: manually added;</li>
        /// <li>loadbalancer: cloud load balancer;</li>
        /// <li>origins: origin server group.</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server information.
        /// <li>When OriginType is custom, it indicates one or more origin servers, such as `["8.8.8.8","9.9.9.9"]` or `OriginValue=["test.com"]`;</li>
        /// <li>When OriginType is loadbalancer, it indicates a cloud load balancer, such as ["lb-xdffsfasdfs"];</li>
        /// <li>When OriginType is origins, it requires one and only one element, indicating the origin server group ID, such as ["origin-537f5b41-162a-11ed-abaa-525400c5da15"].</li>
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Status. Valid values:
        /// <li>online: enabled;</li>
        /// <li>offline: disabled;</li>
        /// <li>progress: deploying;</li>
        /// <li>stopping: disabling;</li>
        /// <li>fail: deployment or disabling failed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Passing the client IP address. Valid values:
        /// <li>TOA: passing via TOA, available only when Proto = TCP;</li>
        /// <li>PPV1: passing via Proxy Protocol V1, available only when Proto = TCP;</li>
        /// <li>PPV2: passing via Proxy Protocol V2;</li>
        /// <li>OFF: no passing.</li>Default value: OFF.
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// Whether to enable session persistence. Valid values:
        /// <li>true: Enable;</li>
        /// <li>false: Disable.</li>Default value: false.
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }

        /// <summary>
        /// Duration for session persistence. the value takes effect only when SessionPersist is true.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Origin server port. Supported formats:
        /// <li>A single port, such as 80.</li>
        /// <li>A port range, such as 81-82, indicating two ports 81 and 82.</li>
        /// </summary>
        [JsonProperty("OriginPort")]
        public string OriginPort{ get; set; }

        /// <summary>
        /// Tag of the rule.
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "OriginPort", this.OriginPort);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
        }
    }
}

