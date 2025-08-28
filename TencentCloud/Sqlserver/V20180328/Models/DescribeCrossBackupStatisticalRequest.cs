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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCrossBackupStatisticalRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination number.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Pagination size.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Instance ID list.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Instance name list.
        /// </summary>
        [JsonProperty("InstanceNameSet")]
        public string[] InstanceNameSet{ get; set; }

        /// <summary>
        /// Cross-region backup status. enable: enabled; disable: disabled.
        /// </summary>
        [JsonProperty("CrossBackupStatus")]
        public string CrossBackupStatus{ get; set; }

        /// <summary>
        /// Target region for cross-region backups.
        /// </summary>
        [JsonProperty("CrossRegion")]
        public string CrossRegion{ get; set; }

        /// <summary>
        /// Sorting field. The default value is default, which indicates sorting by backup space in descending order. data - sort by data backup; log - sort by log backup.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Collation rule (desc - descending order; asc - ascending order). The default value is desc.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamArraySimple(map, prefix + "InstanceNameSet.", this.InstanceNameSet);
            this.SetParamSimple(map, prefix + "CrossBackupStatus", this.CrossBackupStatus);
            this.SetParamSimple(map, prefix + "CrossRegion", this.CrossRegion);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

