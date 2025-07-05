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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SchemaSpaceData : AbstractModel
    {
        
        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("TableSchema")]
        public string TableSchema{ get; set; }

        /// <summary>
        /// Data space in MB.
        /// </summary>
        [JsonProperty("DataLength")]
        public float? DataLength{ get; set; }

        /// <summary>
        /// Index space in MB.
        /// </summary>
        [JsonProperty("IndexLength")]
        public float? IndexLength{ get; set; }

        /// <summary>
        /// Fragmented space in MB.
        /// </summary>
        [JsonProperty("DataFree")]
        public float? DataFree{ get; set; }

        /// <summary>
        /// Total space usage in MB.
        /// </summary>
        [JsonProperty("TotalLength")]
        public float? TotalLength{ get; set; }

        /// <summary>
        /// Fragmented rate (%).
        /// </summary>
        [JsonProperty("FragRatio")]
        public float? FragRatio{ get; set; }

        /// <summary>
        /// Number of rows.
        /// </summary>
        [JsonProperty("TableRows")]
        public long? TableRows{ get; set; }

        /// <summary>
        /// The total size of the independent physical files corresponding to all the database tables (MB).
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhysicalFileSize")]
        public float? PhysicalFileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableSchema", this.TableSchema);
            this.SetParamSimple(map, prefix + "DataLength", this.DataLength);
            this.SetParamSimple(map, prefix + "IndexLength", this.IndexLength);
            this.SetParamSimple(map, prefix + "DataFree", this.DataFree);
            this.SetParamSimple(map, prefix + "TotalLength", this.TotalLength);
            this.SetParamSimple(map, prefix + "FragRatio", this.FragRatio);
            this.SetParamSimple(map, prefix + "TableRows", this.TableRows);
            this.SetParamSimple(map, prefix + "PhysicalFileSize", this.PhysicalFileSize);
        }
    }
}

