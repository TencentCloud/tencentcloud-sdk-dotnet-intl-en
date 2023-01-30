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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecLogVasInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Purchase status
        /// `Pending`: To be purchased.
        /// `Normal`: Purchased.
        /// `Isolate`: Isolated.
        /// </summary>
        [JsonProperty("BuyStatus")]
        public string BuyStatus{ get; set; }

        /// <summary>
        /// Storage period in months
        /// </summary>
        [JsonProperty("LogSaveMonth")]
        public long? LogSaveMonth{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Storage capacity (GB)
        /// </summary>
        [JsonProperty("LogCapacity")]
        public ulong? LogCapacity{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// Whether it has been purchased before. Valid values: `false` (no); `true` (yes).
        /// </summary>
        [JsonProperty("IsPurchased")]
        public bool? IsPurchased{ get; set; }

        /// <summary>
        /// Trial storage capacity (GB)
        /// </summary>
        [JsonProperty("TrialCapacity")]
        public ulong? TrialCapacity{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "LogSaveMonth", this.LogSaveMonth);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LogCapacity", this.LogCapacity);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "IsPurchased", this.IsPurchased);
            this.SetParamSimple(map, prefix + "TrialCapacity", this.TrialCapacity);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

