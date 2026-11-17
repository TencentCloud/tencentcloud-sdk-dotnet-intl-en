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

    public class TopicRule : AbstractModel
    {
        
        /// <summary>
        /// Topic name. For single-topic scenarios, all TopicNames should be the same.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Topic partition policy. When a topic is customized, the valid value is Random (random shipping); when centralizing shipping to a single topic is adopted, the valid values are AllInPartitionZero (ship all to partition 0), PartitionByTable (partition by table name), PartitionByTableAndKey (partition by table name and primary key), and PartitionByCols (partition by column).
        /// </summary>
        [JsonProperty("PartitionType")]
        public string PartitionType{ get; set; }

        /// <summary>
        /// Database name matching rule. For example: Regular (regular expression matching) and Default (remaining databases that do not meet any rule). The last item in the array should be Default.
        /// </summary>
        [JsonProperty("DbMatchMode")]
        public string DbMatchMode{ get; set; }

        /// <summary>
        /// Database name. It is valid when DbMatchMode=Regular.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Table name matching rule. For example: Regular (regular expression matching) and Default (remaining tables that do not meet any rule). The last item in the array should be Default.
        /// </summary>
        [JsonProperty("TableMatchMode")]
        public string TableMatchMode{ get; set; }

        /// <summary>
        /// Table name. It is valid when TableMatchMode is Regular.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// When partitioning by column, you need to select and configure column names. Multi-column selection is supported.
        /// </summary>
        [JsonProperty("Columns")]
        public string[] Columns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionType", this.PartitionType);
            this.SetParamSimple(map, prefix + "DbMatchMode", this.DbMatchMode);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "TableMatchMode", this.TableMatchMode);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamArraySimple(map, prefix + "Columns.", this.Columns);
        }
    }
}

