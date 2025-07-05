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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataCheckStat : AbstractModel
    {
        
        /// <summary>
        /// Total Tables
        /// </summary>
        [JsonProperty("TableTotal")]
        public ulong? TableTotal{ get; set; }

        /// <summary>
        /// Total Number of Fields
        /// </summary>
        [JsonProperty("ColumnTotal")]
        public ulong? ColumnTotal{ get; set; }

        /// <summary>
        /// Number of Table Configuration Checks
        /// </summary>
        [JsonProperty("TableConfig")]
        public ulong? TableConfig{ get; set; }

        /// <summary>
        /// Number of Field Configuration Checks
        /// </summary>
        [JsonProperty("ColumnConfig")]
        public ulong? ColumnConfig{ get; set; }

        /// <summary>
        /// Actual Number of Table Checks
        /// </summary>
        [JsonProperty("TableExec")]
        public ulong? TableExec{ get; set; }

        /// <summary>
        /// Actual Number of Field Checks
        /// </summary>
        [JsonProperty("ColumnExec")]
        public ulong? ColumnExec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableTotal", this.TableTotal);
            this.SetParamSimple(map, prefix + "ColumnTotal", this.ColumnTotal);
            this.SetParamSimple(map, prefix + "TableConfig", this.TableConfig);
            this.SetParamSimple(map, prefix + "ColumnConfig", this.ColumnConfig);
            this.SetParamSimple(map, prefix + "TableExec", this.TableExec);
            this.SetParamSimple(map, prefix + "ColumnExec", this.ColumnExec);
        }
    }
}

