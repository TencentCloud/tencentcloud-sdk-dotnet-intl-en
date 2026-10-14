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

    public class CreateOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// Output name.
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// Output description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Output relay protocol. Supports SRT, RTP, RTMP, RTMP_PULL, RTSP_PULL, and RIST.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Output region.
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// Configuration of the output SRT.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateOutputSrtSettings SRTSettings{ get; set; }

        /// <summary>
        /// Configuration of the output RTMP.
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public CreateOutputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// Configuration of the output RTP.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateOutputInfoRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// IP whitelist list in CIDR format, for example, 0.0.0.0/0.
        /// Valid when Protocol is RTMP_PULL. If empty, it represents no limit on client IP.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// Maximum number of concurrent stream pulls. Maximum value: 4. Default value: 4.
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// ID of the bound input security group.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Availability zone. output supports a maximum of one user-submitted input availability zone.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Output type: Internet/TencentCSS/StreamLive
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// Output RIST configuration.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateOutputRistSettings RISTSettings{ get; set; }

        /// <summary>
        /// For streams with multiple audio/video tracks, you can specify the track to be used
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// Output module type, including Pinpoint (single-point output, supports up to four concurrent outputs); MultiMesh (multiple streams output, supports more than four concurrent outputs, currently up to 200). The default type is Pinpoint output. For a single Flow, only one MultiMesh output is allowed per zone.
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

        /// <summary>
        /// For streams with multiple audio/video tracks, you can specify the track to be used
        /// </summary>
        [JsonProperty("StreamSelector")]
        public StreamSelector StreamSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "OutputRegion", this.OutputRegion);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamObj(map, prefix + "PidSelector.", this.PidSelector);
            this.SetParamSimple(map, prefix + "OutputKind", this.OutputKind);
            this.SetParamObj(map, prefix + "StreamSelector.", this.StreamSelector);
        }
    }
}

