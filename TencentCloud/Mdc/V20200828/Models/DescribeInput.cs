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
        /// Input ID.
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
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Input protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Input address list.
        /// </summary>
        [JsonProperty("InputAddressList")]
        public InputAddress[] InputAddressList{ get; set; }

        /// <summary>
        /// Input IP allowlist.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// SRT configuration information of input.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SRTSettings")]
        public DescribeInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// RTP configuration information of input.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RTPSettings")]
        public DescribeInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// Input region.
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// RTMP configuration information of an input
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public DescribeInputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// Input failover
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Available Zone Configuration: Under disaster recovery conditions, up to two are supported, corresponding to pipeline 0 and 1 in order. Otherwise, only one available zone is allowed.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// The input RTMP_PULL configuration information.
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public DescribeInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// The RTSP_PULL configuration information entered.
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public DescribeInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// The input HLS-PULL configuration information.
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public DescribeInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// Extended smooth streaming configuration information.
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// The bound security group ID.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// The input RIST configuration information.
        /// </summary>
        [JsonProperty("RISTSettings")]
        public DescribeInputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// Enter URL information related to module configuration, including the provided streaming address or the configured third-party source address
        /// </summary>
        [JsonProperty("StreamUrls")]
        public StreamUrlDetail[] StreamUrls{ get; set; }

        /// <summary>
        /// Disaster recovery configuration items
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

