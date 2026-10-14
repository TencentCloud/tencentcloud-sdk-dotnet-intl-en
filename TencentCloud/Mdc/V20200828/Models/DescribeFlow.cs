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

    public class DescribeFlow : AbstractModel
    {
        
        /// <summary>
        /// Stream Id.
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// Stream status. Valid values: IDLE, RUNNING.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Maximum bandwidth.
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// Input group.
        /// </summary>
        [JsonProperty("InputGroup")]
        public DescribeInput[] InputGroup{ get; set; }

        /// <summary>
        /// Output group.
        /// </summary>
        [JsonProperty("OutputGroup")]
        public DescribeOutput[] OutputGroup{ get; set; }

        /// <summary>
        /// EventId of the media transmission event associated with this Flow.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// Creation time of the Flow in UTC format.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Input protocols that can be created for this Flow.
        /// </summary>
        [JsonProperty("AllowedInputProtocols")]
        public string[] AllowedInputProtocols{ get; set; }

        /// <summary>
        /// Output protocols allowed to be created by this Flow
        /// </summary>
        [JsonProperty("AllowedOutputProtocols")]
        public string[] AllowedOutputProtocols{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamArrayObj(map, prefix + "InputGroup.", this.InputGroup);
            this.SetParamArrayObj(map, prefix + "OutputGroup.", this.OutputGroup);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "AllowedInputProtocols.", this.AllowedInputProtocols);
            this.SetParamArraySimple(map, prefix + "AllowedOutputProtocols.", this.AllowedOutputProtocols);
        }
    }
}

