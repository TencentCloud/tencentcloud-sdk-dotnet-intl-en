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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSRule : AbstractModel
    {
        
        /// <summary>
        /// The DDoS mitigation level. If it is null, the setting that was last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSStatusInfo")]
        public DDoSStatusInfo DDoSStatusInfo{ get; set; }

        /// <summary>
        /// The regional blocking settings. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSGeoIp")]
        public DDoSGeoIp DDoSGeoIp{ get; set; }

        /// <summary>
        /// The IP blocklist/allowlist. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSAllowBlock")]
        public DDoSAllowBlock DDoSAllowBlock{ get; set; }

        /// <summary>
        /// The protocol and connection protection settings. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSAntiPly")]
        public DDoSAntiPly DDoSAntiPly{ get; set; }

        /// <summary>
        /// The feature filtering settings. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSPacketFilter")]
        public DDoSPacketFilter DDoSPacketFilter{ get; set; }

        /// <summary>
        /// The port filtering settings. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSAcl")]
        public DDoSAcl DDoSAcl{ get; set; }

        /// <summary>
        /// Whether to enable DDoS mitigation. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>If it is null, the setting that was last configured will be used.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Whether to enable UDP fragmentation. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>It is required only when used as an output parameter.
        /// </summary>
        [JsonProperty("UdpShardOpen")]
        public string UdpShardOpen{ get; set; }

        /// <summary>
        /// The settings of the rate limiting rule. If it is null, the settings that were last configured will be used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSSpeedLimit")]
        public DDoSSpeedLimit DDoSSpeedLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DDoSStatusInfo.", this.DDoSStatusInfo);
            this.SetParamObj(map, prefix + "DDoSGeoIp.", this.DDoSGeoIp);
            this.SetParamObj(map, prefix + "DDoSAllowBlock.", this.DDoSAllowBlock);
            this.SetParamObj(map, prefix + "DDoSAntiPly.", this.DDoSAntiPly);
            this.SetParamObj(map, prefix + "DDoSPacketFilter.", this.DDoSPacketFilter);
            this.SetParamObj(map, prefix + "DDoSAcl.", this.DDoSAcl);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "UdpShardOpen", this.UdpShardOpen);
            this.SetParamObj(map, prefix + "DDoSSpeedLimit.", this.DDoSSpeedLimit);
        }
    }
}

