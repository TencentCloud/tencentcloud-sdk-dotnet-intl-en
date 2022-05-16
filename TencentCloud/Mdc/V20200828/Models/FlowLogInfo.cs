/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class FlowLogInfo : AbstractModel
    {
        
        /// <summary>
        /// The timestamp (seconds).
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// Whether it is an input or output.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The input or output ID.
        /// </summary>
        [JsonProperty("InputOutputId")]
        public string InputOutputId{ get; set; }

        /// <summary>
        /// The protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// The event code.
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// The event information.
        /// </summary>
        [JsonProperty("EventMessage")]
        public string EventMessage{ get; set; }

        /// <summary>
        /// The peer IP.
        /// </summary>
        [JsonProperty("RemoteIp")]
        public string RemoteIp{ get; set; }

        /// <summary>
        /// The peer port.
        /// </summary>
        [JsonProperty("RemotePort")]
        public string RemotePort{ get; set; }

        /// <summary>
        /// Whether it is a primary or backup pipeline. Valid values: 0 (primary), 1 (backup).
        /// </summary>
        [JsonProperty("Pipeline")]
        public string Pipeline{ get; set; }

        /// <summary>
        /// The input or output name.
        /// </summary>
        [JsonProperty("InputOutputName")]
        public string InputOutputName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InputOutputId", this.InputOutputId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventMessage", this.EventMessage);
            this.SetParamSimple(map, prefix + "RemoteIp", this.RemoteIp);
            this.SetParamSimple(map, prefix + "RemotePort", this.RemotePort);
            this.SetParamSimple(map, prefix + "Pipeline", this.Pipeline);
            this.SetParamSimple(map, prefix + "InputOutputName", this.InputOutputName);
        }
    }
}

