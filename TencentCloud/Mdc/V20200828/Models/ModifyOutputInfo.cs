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
        /// Id of the Output to be modified.
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

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
        /// Output type: Internet/TencentCSS/StreamLive
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// Output module type, including Pinpoint (single-point output, supports up to four concurrent outputs); MultiMesh (multiple outputs, supports more than four concurrent outputs, currently up to 200). The default type is Pinpoint output. For a single Flow, only one MultiMesh output is allowed in one zone.
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

        /// <summary>
        /// Configuration of the relayed SRT.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateOutputSrtSettings SRTSettings{ get; set; }

        /// <summary>
        /// Configuration of the relayed RTP.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateOutputInfoRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// Configuration for relaying RTMP.
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public CreateOutputRTMPSettings RTMPSettings{ get; set; }

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
        /// ID of the bound security group. Only one security group can be associated.	
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// AZ.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Relay RIST configuration.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateOutputRistSettings RISTSettings{ get; set; }

        /// <summary>
        /// For streams with multiple audio/video tracks, you can specify the track to be used.
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// For streams with multiple audio/video tracks, you can specify the track to be used.
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

