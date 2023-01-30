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

    public class DescribeProVersionInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Start time of the Pro Edition, which is not empty only when the edition is purchased.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the Pro Edition, which is not empty only when more resources are purchased.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Number of cores to be purchased
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// Upper limit for elastic billing
        /// </summary>
        [JsonProperty("MaxPostPayCoresCnt")]
        public ulong? MaxPostPayCoresCnt{ get; set; }

        /// <summary>
        /// Resource ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Purchase status
        /// `Pending`: To be purchased.
        /// `Normal`: Purchased.
        /// `Isolate`: Isolated.
        /// </summary>
        [JsonProperty("BuyStatus")]
        public string BuyStatus{ get; set; }

        /// <summary>
        /// Whether it has been purchased before. Valid values: `false` (no); `true` (yes).
        /// </summary>
        [JsonProperty("IsPurchased")]
        public bool? IsPurchased{ get; set; }

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
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "MaxPostPayCoresCnt", this.MaxPostPayCoresCnt);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "IsPurchased", this.IsPurchased);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

