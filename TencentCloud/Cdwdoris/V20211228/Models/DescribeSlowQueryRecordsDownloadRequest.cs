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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowQueryRecordsDownloadRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Slow log time
        /// </summary>
        [JsonProperty("QueryDurationMs")]
        public long? QueryDurationMs{ get; set; }

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
        /// Sort parameters
        /// </summary>
        [JsonProperty("DurationMs")]
        public string DurationMs{ get; set; }

        /// <summary>
        /// Query SQL
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// Sort parameters
        /// </summary>
        [JsonProperty("ReadRows")]
        public string ReadRows{ get; set; }

        /// <summary>
        /// Sort parameters
        /// </summary>
        [JsonProperty("ResultBytes")]
        public string ResultBytes{ get; set; }

        /// <summary>
        /// Sort parameters
        /// </summary>
        [JsonProperty("MemoryUsage")]
        public string MemoryUsage{ get; set; }

        /// <summary>
        /// IsQuery condition
        /// </summary>
        [JsonProperty("IsQuery")]
        public long? IsQuery{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("DbName")]
        public string[] DbName{ get; set; }

        /// <summary>
        /// catalog name
        /// </summary>
        [JsonProperty("CatalogName")]
        public string[] CatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "QueryDurationMs", this.QueryDurationMs);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ReadRows", this.ReadRows);
            this.SetParamSimple(map, prefix + "ResultBytes", this.ResultBytes);
            this.SetParamSimple(map, prefix + "MemoryUsage", this.MemoryUsage);
            this.SetParamSimple(map, prefix + "IsQuery", this.IsQuery);
            this.SetParamArraySimple(map, prefix + "DbName.", this.DbName);
            this.SetParamArraySimple(map, prefix + "CatalogName.", this.CatalogName);
        }
    }
}

