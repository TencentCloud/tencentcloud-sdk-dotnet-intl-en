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

    public class DescribeStreamLinkFlowLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Transport stream Id.</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// <p>Start time for statistics, defaults to the last hour, supports querying up to the last 7 days.<br>UTC time, for example, '2020-01-01T12:00:00Z'.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time for statistics, defaulting to one hour after StartTime, with support for querying up to 24 hours of data.<br>UTC time, for example, '2020-01-01T12:00:00Z'.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Input or output type. Valid values: `input`, `output`.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// <p>Primary or backup channel. Option [0|1].</p>
        /// </summary>
        [JsonProperty("Pipeline")]
        public string[] Pipeline{ get; set; }

        /// <summary>
        /// <p>Size per page. Default value: 100. Value range: [1, 1000].</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Sort by Timestamp in ascending or descending order. The default is descending order. Options: [desc|asc].</p>
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// <p>Page number. Default value: 1. Value range: [1, 1000].</p>
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "Pipeline.", this.Pipeline);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
        }
    }
}

