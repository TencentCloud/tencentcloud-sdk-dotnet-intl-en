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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskDataRegistry : AbstractModel
    {
        
        /// <summary>
        /// Data source ID.
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Partition name
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// Input output table data type.
        /// Input stream:
        ///  UPSTREAM,
        /// Output stream:
        ///   DOWNSTREAM;.
        /// </summary>
        [JsonProperty("DataFlowType")]
        public string DataFlowType{ get; set; }

        /// <summary>
        /// Physical unique ID..
        /// </summary>
        [JsonProperty("TablePhysicalId")]
        public string TablePhysicalId{ get; set; }

        /// <summary>
        /// Database unique id..
        /// </summary>
        [JsonProperty("DbGuid")]
        public string DbGuid{ get; set; }

        /// <summary>
        /// Unique id of the table.
        /// </summary>
        [JsonProperty("TableGuid")]
        public string TableGuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "DataFlowType", this.DataFlowType);
            this.SetParamSimple(map, prefix + "TablePhysicalId", this.TablePhysicalId);
            this.SetParamSimple(map, prefix + "DbGuid", this.DbGuid);
            this.SetParamSimple(map, prefix + "TableGuid", this.TableGuid);
        }
    }
}

