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

    public class FlowRealtimeStatusItem : AbstractModel
    {
        
        /// <summary>
        /// Type. Valid values: `Input`, `Output`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Input Id. If Type is Input, this field is not empty.
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// Output Id. If Type is Output, this field is not empty.
        /// </summary>
        [JsonProperty("OutputId")]
        public string OutputId{ get; set; }

        /// <summary>
        /// Stream Id.
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// Protocol. SRT | RTMP.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Common status information.
        /// </summary>
        [JsonProperty("CommonStatus")]
        public FlowRealtimeStatusCommon CommonStatus{ get; set; }

        /// <summary>
        /// If it is the SRT Protocol, this field will be present.
        /// </summary>
        [JsonProperty("SRTStatus")]
        public FlowRealtimeStatusSRT SRTStatus{ get; set; }

        /// <summary>
        /// If it is the RTMP protocol, this field exists.
        /// </summary>
        [JsonProperty("RTMPStatus")]
        public FlowRealtimeStatusRTMP RTMPStatus{ get; set; }

        /// <summary>
        /// Server IP address.
        /// </summary>
        [JsonProperty("ConnectServerIP")]
        public string ConnectServerIP{ get; set; }

        /// <summary>
        /// If it is the RTP protocol, this field exists.
        /// </summary>
        [JsonProperty("RTPStatus")]
        public FlowRealtimeStatusRTP RTPStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InputId", this.InputId);
            this.SetParamSimple(map, prefix + "OutputId", this.OutputId);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "CommonStatus.", this.CommonStatus);
            this.SetParamObj(map, prefix + "SRTStatus.", this.SRTStatus);
            this.SetParamObj(map, prefix + "RTMPStatus.", this.RTMPStatus);
            this.SetParamSimple(map, prefix + "ConnectServerIP", this.ConnectServerIP);
            this.SetParamObj(map, prefix + "RTPStatus.", this.RTPStatus);
        }
    }
}

