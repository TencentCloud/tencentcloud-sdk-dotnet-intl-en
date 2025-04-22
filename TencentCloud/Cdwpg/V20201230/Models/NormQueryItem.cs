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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NormQueryItem : AbstractModel
    {
        
        /// <summary>
        /// Number of calls.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CallTimes")]
        public long? CallTimes{ get; set; }

        /// <summary>
        /// Number of read-only shared memory blocks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SharedReadBlocks")]
        public long? SharedReadBlocks{ get; set; }

        /// <summary>
        /// Number of write-only shared memory blocks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SharedWriteBlocks")]
        public long? SharedWriteBlocks{ get; set; }

        /// <summary>
        /// Database.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Statement after masking.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NormalQuery")]
        public string NormalQuery{ get; set; }

        /// <summary>
        /// The statement with the longest execution time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxElapsedQuery")]
        public string MaxElapsedQuery{ get; set; }

        /// <summary>
        /// Total consumption time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// Client IP address.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Username.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Proportion of total count.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCallTimesPercent")]
        public float? TotalCallTimesPercent{ get; set; }

        /// <summary>
        /// Proportion of total consumption time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCostTimePercent")]
        public float? TotalCostTimePercent{ get; set; }

        /// <summary>
        /// Minimum consumption time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinCostTime")]
        public float? MinCostTime{ get; set; }

        /// <summary>
        /// Maximum consumption time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxCostTime")]
        public float? MaxCostTime{ get; set; }

        /// <summary>
        /// Time of the earliest item.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// Time of the latest item.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// Total consumption time of I/O reading.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReadCostTime")]
        public float? ReadCostTime{ get; set; }

        /// <summary>
        /// Total consumption time I/O writing.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WriteCostTime")]
        public float? WriteCostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallTimes", this.CallTimes);
            this.SetParamSimple(map, prefix + "SharedReadBlocks", this.SharedReadBlocks);
            this.SetParamSimple(map, prefix + "SharedWriteBlocks", this.SharedWriteBlocks);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "NormalQuery", this.NormalQuery);
            this.SetParamSimple(map, prefix + "MaxElapsedQuery", this.MaxElapsedQuery);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TotalCallTimesPercent", this.TotalCallTimesPercent);
            this.SetParamSimple(map, prefix + "TotalCostTimePercent", this.TotalCostTimePercent);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "ReadCostTime", this.ReadCostTime);
            this.SetParamSimple(map, prefix + "WriteCostTime", this.WriteCostTime);
        }
    }
}

