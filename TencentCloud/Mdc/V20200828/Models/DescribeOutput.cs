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
        /// Output ID.
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

        /// <summary>
        /// Output name.
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// Output type.
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// Output description.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Output protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Output destination address information list.
        /// </summary>
        [JsonProperty("OutputAddressList")]
        public OutputAddress[] OutputAddressList{ get; set; }

        /// <summary>
        /// Output region.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// SRT configuration information of output.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public DescribeOutputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// RTP configuration information of output.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public DescribeOutputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// RTMP configuration information of output.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public DescribeOutputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// RTMP pull configuration of the output
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public DescribeOutputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// CIDR Whitelist List. Effective when Protocol is RTMP_PULL. Empty means no restriction on client IP.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// The output RTSP streaming configuration information.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public DescribeOutputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// Output the HLS streaming configuration information.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public DescribeOutputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// The maximum number of concurrent streams is 4, with a default of 4.
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// The bound security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// The available zone currently only supports a maximum of one output.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Output RIST configuration information.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public DescribeOutputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// For streams containing multiple audio/video tracks, you can specify the tracks that need to be used
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// Output module types, including Pinpoint (single point output, supporting up to four concurrent outputs); MultiMesh (Multi output, supports concurrent outputs greater than four, currently up to 200). The default type is Pinpoint output. For a single Flow, a region can only have a maximum of one MultiMesh output.
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

        /// <summary>
        /// Output module configuration, relevant URLs, including provided streaming addresses or configured output to third-party forwarding addresses
        /// </summary>
        [JsonProperty("StreamUrls")]
        public StreamUrlDetail[] StreamUrls{ get; set; }

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
        }
    }
}

