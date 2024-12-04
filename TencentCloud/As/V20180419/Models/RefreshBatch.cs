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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RefreshBatch : AbstractModel
    {
        
        /// <summary>
        /// Refresh batch number. For example, a value of 2 indicates that the current batch of instances will be refreshed in the second batch.
        /// </summary>
        [JsonProperty("RefreshBatchNum")]
        public ulong? RefreshBatchNum{ get; set; }

        /// <summary>
        /// Refresh batch status. Valid values: <li>WAITING: pending refresh;</li> <li>INIT: initializing;</li> <li>RUNNING: refreshing;</li> <li>FAILED: refresh failed;</li> <li>PARTIALLY_SUCCESSFUL: partially successful in the batch;</li> <li>CANCELLED: cancelled;</li> <li>SUCCESSFUL: refresh successful.</li>
        /// </summary>
        [JsonProperty("RefreshBatchStatus")]
        public string RefreshBatchStatus{ get; set; }

        /// <summary>
        /// List of instances linked to a refresh batch.
        /// </summary>
        [JsonProperty("RefreshBatchRelatedInstanceSet")]
        public RefreshBatchRelatedInstance[] RefreshBatchRelatedInstanceSet{ get; set; }

        /// <summary>
        /// Refresh batch start time.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Refresh batch end time.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RefreshBatchNum", this.RefreshBatchNum);
            this.SetParamSimple(map, prefix + "RefreshBatchStatus", this.RefreshBatchStatus);
            this.SetParamArrayObj(map, prefix + "RefreshBatchRelatedInstanceSet.", this.RefreshBatchRelatedInstanceSet);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

