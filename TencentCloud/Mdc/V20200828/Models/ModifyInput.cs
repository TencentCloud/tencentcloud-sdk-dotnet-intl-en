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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInput : AbstractModel
    {
        
        /// <summary>
        /// Input Id.
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// Enter a name.
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// Input description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// IPs allowed for push, in CIDR format.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// Configuration of SRT.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// Configuration message of RTP.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// Input protocol. Options: SRT, RTP, RTMP, RTMP_PULL, RTSP_PULL, RIST.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Input primary/replica switch. Option: [OPEN|CLOSE].
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Configuration message of RTMP_PULL.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public CreateInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// Configuration message of RTSP_PULL.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public CreateInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// Configuration message of HLS_PULL.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public CreateInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// Configuration message for smooth stream output during delayed playback.
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// ID of the bound input security group. Only one security group can be associated.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Availability zone. Optional. input limit: two availability zones. For this API, only the second availability zone participates in resource allocation. It is valid if disaster recovery is enabled or the RTSP_PULL protocol is involved during switching. The address will be reallocated.	
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Configuration information of RIST.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateInputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// Region of the input node.
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// Hot/cold backup related
        /// </summary>
        [JsonProperty("FailOverOption")]
        public FailOverOption FailOverOption{ get; set; }


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
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamObj(map, prefix + "FailOverOption.", this.FailOverOption);
        }
    }
}

