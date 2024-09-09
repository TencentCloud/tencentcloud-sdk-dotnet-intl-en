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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInput : AbstractModel
    {
        
        /// <summary>
        /// Input name, which can contain 1 to 32 letters, digits, and underscores.
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// Input protocol. Valid values: `SRT`, `RTP`, `RTMP`, `RTMP_PULL`, `RTSP_PULL `, `HLS_PULL`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Input description. Length: [0, 255].
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Allowlist of input IPs in CIDR format.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// SRT configuration information of input.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// RTP configuration information of input.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// Input failover. Valid values: `OPEN`, `CLOSE` (default)
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Input RTMP_PULL configuration information.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public CreateInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// Input RTSP_PULL configuration information.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public CreateInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// Input HLS_PULL configuration information.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public CreateInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// Delayed broadcast smooth streaming configuration information.
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// The bound security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Availability zone, optional. If disaster recovery is enabled, you must enter two different availability zones. Otherwise, you can only enter one availability zone at most.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputName", this.InputName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamObj(map, prefix + "RTMPPullSettings.", this.RTMPPullSettings);
            this.SetParamObj(map, prefix + "RTSPPullSettings.", this.RTSPPullSettings);
            this.SetParamObj(map, prefix + "HLSPullSettings.", this.HLSPullSettings);
            this.SetParamObj(map, prefix + "ResilientStream.", this.ResilientStream);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
        }
    }
}

