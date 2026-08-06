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

    public class ModifyOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// The ID of the output to modify.
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

        /// <summary>
        /// The output name.
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// The description of the output.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The output protocol. Valid values: SRT, RTP, RTMP.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Output Type: Internet/Tencent CSS/StreamLive
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// Output module types include Pinpoint (single-point output, supporting up to four concurrent outputs) and MultiMesh (multi-output, supporting concurrent outputs exceeding four, currently capable of reaching 200 channels). The default type is Pinpoint output. For a single Flow, only one MultiMesh output can be assigned per region.
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

        /// <summary>
        /// The SRT relay configuration.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateOutputSrtSettings SRTSettings{ get; set; }

        /// <summary>
        /// The RTP relay configuration.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateOutputInfoRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// The RTMP relay configuration.
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public CreateOutputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// IP whitelist, in CIDR format, such as 0.0.0.0/0. This is valid when Protocol is RTMP_PULL, and empty means no restriction on client IP.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// The maximum number of concurrent stream pulls is 4, and the default value is 4.
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// The bound security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Availability Zone
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Transfer the configuration of RIST.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateOutputRistSettings RISTSettings{ get; set; }

        /// <summary>
        /// For streams containing multiple audio/video tracks, you can specify the tracks that need to be used
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// For streams containing multiple audio/video tracks, you can specify the tracks that need to be used
        /// </summary>
        [JsonProperty("StreamSelector")]
        public StreamSelector StreamSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputId", this.OutputId);
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "OutputKind", this.OutputKind);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamObj(map, prefix + "PidSelector.", this.PidSelector);
            this.SetParamObj(map, prefix + "StreamSelector.", this.StreamSelector);
        }
    }
}

