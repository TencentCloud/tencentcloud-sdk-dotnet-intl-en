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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLibraDBClusterTableMappingRequest : AbstractModel
    {
        
        /// <summary>
        /// Analysis Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Analysis engine instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Page history limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Source schema list
        /// </summary>
        [JsonProperty("SrcSchemas")]
        public string[] SrcSchemas{ get; set; }

        /// <summary>
        /// Source table list
        /// </summary>
        [JsonProperty("SrcTableName")]
        public string[] SrcTableName{ get; set; }

        /// <summary>
        /// Status list
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }

        /// <summary>
        /// Map database name
        /// </summary>
        [JsonProperty("MapSchemas")]
        public string[] MapSchemas{ get; set; }

        /// <summary>
        /// Mapping table name
        /// </summary>
        [JsonProperty("MapTableName")]
        public string[] MapTableName{ get; set; }

        /// <summary>
        /// Query records where the database name is not null
        /// </summary>
        [JsonProperty("MapSchemaNotEmpty")]
        public bool? MapSchemaNotEmpty{ get; set; }

        /// <summary>
        /// Query records where the mapping table name is not null
        /// </summary>
        [JsonProperty("MapTableNameNotEmpty")]
        public bool? MapTableNameNotEmpty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "SrcSchemas.", this.SrcSchemas);
            this.SetParamArraySimple(map, prefix + "SrcTableName.", this.SrcTableName);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArraySimple(map, prefix + "MapSchemas.", this.MapSchemas);
            this.SetParamArraySimple(map, prefix + "MapTableName.", this.MapTableName);
            this.SetParamSimple(map, prefix + "MapSchemaNotEmpty", this.MapSchemaNotEmpty);
            this.SetParamSimple(map, prefix + "MapTableNameNotEmpty", this.MapTableNameNotEmpty);
        }
    }
}

