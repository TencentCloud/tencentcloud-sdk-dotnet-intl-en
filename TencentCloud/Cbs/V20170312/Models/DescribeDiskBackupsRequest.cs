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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDiskBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// List of IDs of the backup points to be queried. `DiskBackupIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("DiskBackupIds")]
        public string[] DiskBackupIds{ get; set; }

        /// <summary>
        /// Filter criteria. parameters must not be specified simultaneously for DiskBackupIds and Filters. filter conditions:<br><li>disk-backup-id - Array of String - required: no - (filter condition) Filters by backup point id. backup point id format: dbp-11112222.</li><br><li>disk-id - Array of String - required: no - (filter condition) Filters by cloud disk id where the backup point was created. cloud disk id format: disk-srftydert.</li><br><li>disk-usage - Array of String - required: no - (filter condition) Filters by cloud disk type (SYSTEM_disk: represents SYSTEM disk | DATA_disk: represents DATA disk).</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section of the API [Overview](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section of the API [Overview](https://intl.cloud.tencent.com/document/product/362/15633?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Specifies the sorting order of the CBS backup point list. default: ASC. valid values: <br><li>ASC: ascending order</li><br><li>DESC: descending order.</li>.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Field on which the list of cloud disk backup points is sorted. valid values: <br><li>CREATE_TIME: sort by creation TIME of the cloud disk backup point</li><br>sort by creation TIME by default.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskBackupIds.", this.DiskBackupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

