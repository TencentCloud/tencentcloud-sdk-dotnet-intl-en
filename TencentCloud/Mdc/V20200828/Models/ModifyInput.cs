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

    public class ModifyInput : AbstractModel
    {
        
        /// <summary>
        /// The input ID.
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// The input name.
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// The description of the input.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The IP addresses (CIDR) allowed to push streams.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// The SRT configuration information.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// The RTP configuration information.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// The input protocol. Valid values: SRT, RTP, RTMP.
        /// If there is an RTP input, the output must be RTP.
        /// If there is an RTMP input, the output must be SRT or RTMP.
        /// If there is an SRT input, the output must be SRT.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Whether to enable input failover. Valid values: OPEN, CLOSE.
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Configuration information for RTMP_PULL.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public CreateInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// Configuration information of RTSP_PULL.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public CreateInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// HLS_PULL configuration information.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public CreateInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// Delayed broadcast smooth streaming configuration information.
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// The ID of the input security group to bind. Only one security group can be associated.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Availability zone, optional, supports up to two availability zones. For interfaces that need to be changed, the second availability zone will participate in resource allocation. This is effective if disaster recovery is enabled for input or RTSP_PULL protocol switching is involved (addresses will be reallocated).
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputId", this.InputId);
            this.SetParamSimple(map, prefix + "InputName", this.InputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
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

