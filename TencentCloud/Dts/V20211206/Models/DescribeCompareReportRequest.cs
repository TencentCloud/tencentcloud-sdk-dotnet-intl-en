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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCompareReportRequest : AbstractModel
    {
        
        /// <summary>
        /// Migration task ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Check task ID
        /// </summary>
        [JsonProperty("CompareTaskId")]
        public string CompareTaskId{ get; set; }

        /// <summary>
        /// Number of inconsistent objects to be returned
        /// </summary>
        [JsonProperty("DifferenceLimit")]
        public ulong? DifferenceLimit{ get; set; }

        /// <summary>
        /// Offset of inconsistent objects
        /// </summary>
        [JsonProperty("DifferenceOffset")]
        public ulong? DifferenceOffset{ get; set; }

        /// <summary>
        /// Search criterion: Inconsistent database name
        /// </summary>
        [JsonProperty("DifferenceDB")]
        public string DifferenceDB{ get; set; }

        /// <summary>
        /// Search criterion: Inconsistent table name
        /// </summary>
        [JsonProperty("DifferenceTable")]
        public string DifferenceTable{ get; set; }

        /// <summary>
        /// Number of unchecked objects to be returned
        /// </summary>
        [JsonProperty("SkippedLimit")]
        public ulong? SkippedLimit{ get; set; }

        /// <summary>
        /// Offset of unchecked objects
        /// </summary>
        [JsonProperty("SkippedOffset")]
        public ulong? SkippedOffset{ get; set; }

        /// <summary>
        /// Search criterion: Unchecked database name
        /// </summary>
        [JsonProperty("SkippedDB")]
        public string SkippedDB{ get; set; }

        /// <summary>
        /// Search criterion: Unchecked table name
        /// </summary>
        [JsonProperty("SkippedTable")]
        public string SkippedTable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CompareTaskId", this.CompareTaskId);
            this.SetParamSimple(map, prefix + "DifferenceLimit", this.DifferenceLimit);
            this.SetParamSimple(map, prefix + "DifferenceOffset", this.DifferenceOffset);
            this.SetParamSimple(map, prefix + "DifferenceDB", this.DifferenceDB);
            this.SetParamSimple(map, prefix + "DifferenceTable", this.DifferenceTable);
            this.SetParamSimple(map, prefix + "SkippedLimit", this.SkippedLimit);
            this.SetParamSimple(map, prefix + "SkippedOffset", this.SkippedOffset);
            this.SetParamSimple(map, prefix + "SkippedDB", this.SkippedDB);
            this.SetParamSimple(map, prefix + "SkippedTable", this.SkippedTable);
        }
    }
}

