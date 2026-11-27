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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataRetrievalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>File system instance ID, which can be obtained through the DescribeCfsFileSystems API. Example value: cfs-xxxxxx</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Data retrieval name. Example value: DataDive</p>
        /// </summary>
        [JsonProperty("DataRetrievalName")]
        public string DataRetrievalName{ get; set; }

        /// <summary>
        /// <p>Aggregated retrieval condition. Example value: from entries|where size &gt;4096</p>
        /// </summary>
        [JsonProperty("CompoundCondition")]
        public string CompoundCondition{ get; set; }

        /// <summary>
        /// <p>List retrieval condition.</p>
        /// </summary>
        [JsonProperty("QueryCondition")]
        public string QueryCondition{ get; set; }

        /// <summary>
        /// <p>Monthly data retrieval. Valid values: 1–31. The retrieval will be automatically created on the specified day of each month. For example, 1 indicates the 1st day of a month. You must specify either this parameter or DayOfWeek. Example value: 1</p>
        /// </summary>
        [JsonProperty("DayOfMonth")]
        public string DayOfMonth{ get; set; }

        /// <summary>
        /// <p>Day of the week for data retrieval repetition. Valid values: 1–7. 1 indicates Monday and 7 indicates Sunday. You must specify either this parameter or DayOfMonth. Example value: 2,3</p>
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// <p>Hour of the day for repetition. Valid values: 0–23. Example value: 1,3,5</p>
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "DataRetrievalName", this.DataRetrievalName);
            this.SetParamSimple(map, prefix + "CompoundCondition", this.CompoundCondition);
            this.SetParamSimple(map, prefix + "QueryCondition", this.QueryCondition);
            this.SetParamSimple(map, prefix + "DayOfMonth", this.DayOfMonth);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
        }
    }
}

