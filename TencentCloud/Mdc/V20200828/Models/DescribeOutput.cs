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
        /// CIDR allowlist
        /// This parameter is valid if `Protocol` is set to `RTMP_PULL`. If this parameter is left empty, there is no restriction on clients’ IP addresses.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public DescribeOutputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public DescribeOutputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// The bound security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


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
        }
    }
}

