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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSnapOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// The total snapshot size of the user
        /// </summary>
        [JsonProperty("TotalSize")]
        public float? TotalSize{ get; set; }

        /// <summary>
        /// The total billed snapshot size of the user
        /// </summary>
        [JsonProperty("RealTradeSize")]
        public float? RealTradeSize{ get; set; }

        /// <summary>
        /// Free tier of snapshot
        /// </summary>
        [JsonProperty("FreeQuota")]
        public float? FreeQuota{ get; set; }

        /// <summary>
        /// Total number of snapshots
        /// </summary>
        [JsonProperty("TotalNums")]
        public long? TotalNums{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "RealTradeSize", this.RealTradeSize);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
            this.SetParamSimple(map, prefix + "TotalNums", this.TotalNums);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

