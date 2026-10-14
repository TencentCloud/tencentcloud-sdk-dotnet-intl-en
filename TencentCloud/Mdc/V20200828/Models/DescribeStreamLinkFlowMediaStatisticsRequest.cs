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

    public class DescribeStreamLinkFlowMediaStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// Transport stream ID.
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// Input or output type. Valid values: `input`, `output`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Input or output Id.
        /// </summary>
        [JsonProperty("InputOutputId")]
        public string InputOutputId{ get; set; }

        /// <summary>
        /// Primary or backup channel. Valid values: 0 and 1.
        /// </summary>
        [JsonProperty("Pipeline")]
        public string Pipeline{ get; set; }

        /// <summary>
        /// Query interval. Options: [5s|1min|5min|15min].
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// Start time for statistics. Default value: last hour. You can query data from the last 7 days at most.
        /// UTC time, for example, '2020-01-01T12:00:00Z'.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time for statistics. Defaults to one hour after `StartTime`. You can query the data of up to 24 hours.
        /// UTC time, for example, '2020-01-01T12:00:00Z'.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Peer IP address.
        /// </summary>
        [JsonProperty("RemoteIp")]
        public string RemoteIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InputOutputId", this.InputOutputId);
            this.SetParamSimple(map, prefix + "Pipeline", this.Pipeline);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RemoteIp", this.RemoteIp);
        }
    }
}

