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

    public class DescribeOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>Output Id.</p>
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

        /// <summary>
        /// <p>Output name.</p>
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// <p>Output type.</p>
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// <p>Output description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Output protocol.</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>List of output egress address information.</p>
        /// </summary>
        [JsonProperty("OutputAddressList")]
        public OutputAddress[] OutputAddressList{ get; set; }

        /// <summary>
        /// <p>Output region.</p>
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// <p>SRT configuration information of the output.</p>
        /// </summary>
        [JsonProperty("SRTSettings")]
        public DescribeOutputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// <p>Output RTP configuration message.</p>
        /// </summary>
        [JsonProperty("RTPSettings")]
        public DescribeOutputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// <p>Output RTMP configuration message.</p>
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public DescribeOutputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// <p>Output RTMP pull configuration message.</p>
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public DescribeOutputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// <p>CIDR allowlist.<br>Valid when Protocol is RTMP_PULL. If empty, it represents no limit on client IP.</p>
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// <p>Output RTSP pull stream configuration message.</p>
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public DescribeOutputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// <p>Output HLS pull configuration message.</p>
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public DescribeOutputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// <p>Maximum number of concurrent stream pulls. Maximum value: 4. Default value: 4.</p>
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// <p>ID of the bound security group.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Availability zone. output currently supports a maximum of one.</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>Output RIST configuration message.</p>
        /// </summary>
        [JsonProperty("RISTSettings")]
        public DescribeOutputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// <p>For streams with multiple audio/video tracks, you can specify the track to be used</p>
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// <p>Output module type, including Pinpoint (single-point output, supports up to four concurrent outputs); MultiMesh (multiple streams output, supports more than four concurrent outputs, currently up to 200). The default type is Pinpoint output. For one Flow, only one MultiMesh output is allowed in one zone.</p>
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

        /// <summary>
        /// <p>Output module configuration, related URLs, including the provided pull stream address or the configured relay address for output to a third party</p>
        /// </summary>
        [JsonProperty("StreamUrls")]
        public StreamUrlDetail[] StreamUrls{ get; set; }

        /// <summary>
        /// <p>For streams with multiple audio/video tracks, you can specify the track to be used</p>
        /// </summary>
        [JsonProperty("StreamSelector")]
        public StreamSelector StreamSelector{ get; set; }

        /// <summary>
        /// <p>Output status.</p><p>Enumeration values:</p><ul><li>DISABLED</li><li>ENABLED</li></ul>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputId", this.OutputId);
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "OutputAddressList.", this.OutputAddressList);
            this.SetParamSimple(map, prefix + "OutputRegion", this.OutputRegion);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamObj(map, prefix + "RTMPPullSettings.", this.RTMPPullSettings);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamObj(map, prefix + "RTSPPullSettings.", this.RTSPPullSettings);
            this.SetParamObj(map, prefix + "HLSPullSettings.", this.HLSPullSettings);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamObj(map, prefix + "PidSelector.", this.PidSelector);
            this.SetParamSimple(map, prefix + "OutputKind", this.OutputKind);
            this.SetParamArrayObj(map, prefix + "StreamUrls.", this.StreamUrls);
            this.SetParamObj(map, prefix + "StreamSelector.", this.StreamSelector);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

