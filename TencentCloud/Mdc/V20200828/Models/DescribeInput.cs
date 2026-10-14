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

    public class DescribeInput : AbstractModel
    {
        
        /// <summary>
        /// Input Id.
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// Input name.
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// Input description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Input protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Input the address list.
        /// </summary>
        [JsonProperty("InputAddressList")]
        public InputAddress[] InputAddressList{ get; set; }

        /// <summary>
        /// Input the IP whitelist list.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// SRT configuration information of the input.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public DescribeInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// Input RTP configuration message.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public DescribeInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// Input region.
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// Input RTMP configuration message.
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public DescribeInputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// Primary/replica switch input.
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Availability zone configuration. In the current situation with disaster recovery enabled, there can be up to two, corresponding to pipeline 0 and 1 in sequence. Otherwise, there is only one availability zone.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Input RTMP_PULL configuration message.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public DescribeInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// Input RTSP_PULL configuration message.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public DescribeInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// Input HLS_PULL configuration message.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public DescribeInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// Configuration message for smooth streaming during delayed broadcasting.
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// Bound input security group ID.	
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Input RIST configuration message.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public DescribeInputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// Input URL information related to module settings, including the provided streaming address or the configured third-party source stream URL.
        /// </summary>
        [JsonProperty("StreamUrls")]
        public StreamUrlDetail[] StreamUrls{ get; set; }

        /// <summary>
        /// Disaster recovery configuration item
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
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "InputAddressList.", this.InputAddressList);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamObj(map, prefix + "RTMPPullSettings.", this.RTMPPullSettings);
            this.SetParamObj(map, prefix + "RTSPPullSettings.", this.RTSPPullSettings);
            this.SetParamObj(map, prefix + "HLSPullSettings.", this.HLSPullSettings);
            this.SetParamObj(map, prefix + "ResilientStream.", this.ResilientStream);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamArrayObj(map, prefix + "StreamUrls.", this.StreamUrls);
            this.SetParamObj(map, prefix + "FailOverOption.", this.FailOverOption);
        }
    }
}

