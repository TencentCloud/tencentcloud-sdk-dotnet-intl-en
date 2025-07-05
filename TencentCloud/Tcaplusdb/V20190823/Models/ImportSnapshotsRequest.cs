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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportSnapshotsRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the cluster where the original table (from which the snapshot was created) resides
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The information of the snapshot to import
        /// </summary>
        [JsonProperty("Snapshots")]
        public SnapshotInfo Snapshots{ get; set; }

        /// <summary>
        /// Whether to import partial data of the snapshot. Valid values: `TRUE` (import partial data), `FALSE` (import all data).
        /// </summary>
        [JsonProperty("ImportSpecialKey")]
        public string ImportSpecialKey{ get; set; }

        /// <summary>
        /// Whether to import to the original table. Valid values: `TRUE` (import to the original table), `FALSE` (import to a new table).
        /// </summary>
        [JsonProperty("ImportOriginTable")]
        public string ImportOriginTable{ get; set; }

        /// <summary>
        /// The file of the keys of the partial data
        /// </summary>
        [JsonProperty("KeyFile")]
        public KeyFile KeyFile{ get; set; }

        /// <summary>
        /// The ID of the table group where the new table resides, which is valid only when `ImportOriginTable` is set to `FALSE`
        /// </summary>
        [JsonProperty("NewTableGroupId")]
        public string NewTableGroupId{ get; set; }

        /// <summary>
        /// The name of the new table, which is valid only when `ImportOriginTable` is set to `FALSE`. TcaplusDB will automatically create a table named `NewTableName` of the same structure as that of the original table.
        /// </summary>
        [JsonProperty("NewTableName")]
        public string NewTableName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "Snapshots.", this.Snapshots);
            this.SetParamSimple(map, prefix + "ImportSpecialKey", this.ImportSpecialKey);
            this.SetParamSimple(map, prefix + "ImportOriginTable", this.ImportOriginTable);
            this.SetParamObj(map, prefix + "KeyFile.", this.KeyFile);
            this.SetParamSimple(map, prefix + "NewTableGroupId", this.NewTableGroupId);
            this.SetParamSimple(map, prefix + "NewTableName", this.NewTableName);
        }
    }
}

