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

    public class TableGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// Table group ID
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// Table group name
        /// </summary>
        [JsonProperty("TableGroupName")]
        public string TableGroupName{ get; set; }

        /// <summary>
        /// Table group creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Number of tables in table group
        /// </summary>
        [JsonProperty("TableCount")]
        public ulong? TableCount{ get; set; }

        /// <summary>
        /// Total table storage capacity in MB in table group
        /// </summary>
        [JsonProperty("TotalSize")]
        public ulong? TotalSize{ get; set; }

        /// <summary>
        /// The number of days before the backup files of the Txh tables expire and are deleted.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }

        /// <summary>
        /// Whether MySQL load rebalancing is enabled. Valid values: `0` (Disabled), `1` (Enabling), `2` (Enabled).
        /// </summary>
        [JsonProperty("EnableMysql")]
        public ulong? EnableMysql{ get; set; }

        /// <summary>
        /// MySQL load rebalancing vip
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MysqlConnIp")]
        public string MysqlConnIp{ get; set; }

        /// <summary>
        /// MySQL load rebalancing vport
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MysqlConnPort")]
        public ulong? MysqlConnPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableGroupName", this.TableGroupName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "TableCount", this.TableCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "TxhBackupExpireDay", this.TxhBackupExpireDay);
            this.SetParamSimple(map, prefix + "EnableMysql", this.EnableMysql);
            this.SetParamSimple(map, prefix + "MysqlConnIp", this.MysqlConnIp);
            this.SetParamSimple(map, prefix + "MysqlConnPort", this.MysqlConnPort);
        }
    }
}

