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

    public class CreateStreamLinkFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// Flow name
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// Maximum bandwidth in bps. Valid values: `10000000`, `20000000`, `50000000`
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// Flow input group
        /// </summary>
        [JsonProperty("InputGroup")]
        public CreateInput[] InputGroup{ get; set; }

        /// <summary>
        /// The media transmission event ID associated with the Flow. Each flow can only be associated with one event.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamArrayObj(map, prefix + "InputGroup.", this.InputGroup);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

