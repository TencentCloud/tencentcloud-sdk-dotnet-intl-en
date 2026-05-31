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

    public class TableMappingObject : AbstractModel
    {
        
        /// <summary>
        /// Source instance Id
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

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
        /// Map database name
        /// </summary>
        [JsonProperty("MapDatabaseName")]
        public string MapDatabaseName{ get; set; }

        /// <summary>
        /// Mapping table name
        /// </summary>
        [JsonProperty("MapTableName")]
        public string MapTableName{ get; set; }

        /// <summary>
        /// Synchronization status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Sync progress
        /// </summary>
        [JsonProperty("Process")]
        public float? Process{ get; set; }

        /// <summary>
        /// Delay
        /// </summary>
        [JsonProperty("Lag")]
        public long? Lag{ get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Whether it is the main table
        /// </summary>
        [JsonProperty("IsPrimary")]
        public bool? IsPrimary{ get; set; }

        /// <summary>
        /// Virtual column padding value
        /// </summary>
        [JsonProperty("VirtualColValue")]
        public string VirtualColValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "MapDatabaseName", this.MapDatabaseName);
            this.SetParamSimple(map, prefix + "MapTableName", this.MapTableName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamSimple(map, prefix + "Lag", this.Lag);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "IsPrimary", this.IsPrimary);
            this.SetParamSimple(map, prefix + "VirtualColValue", this.VirtualColValue);
        }
    }
}

