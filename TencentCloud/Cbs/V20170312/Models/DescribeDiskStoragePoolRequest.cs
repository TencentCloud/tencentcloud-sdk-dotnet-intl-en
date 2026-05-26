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

    public class DescribeDiskStoragePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of returned results, defaults to 20 with a maximum value of 100. For further introduction about `Limit`, see relevant sections in the API [overview](/document/product/362/15633).
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Specify the exclusive cluster ID list you want to query. This parameter cannot be used with Filters.
        /// </summary>
        [JsonProperty("CdcIds")]
        public string[] CdcIds{ get; set; }

        /// <summary>
        /// Filter conditions. `CdcIds` and `Filters` cannot be specified at the same time. <br><li>cdc-id - Array of String - Optional - Filter by the cluster ID. <br><li>zone - Array of String - Optional - Filter by the [availability zone](https://intl.cloud.tencent.com/document/product/213/15753?from_cn_redirect=1#ZoneInfo) where the cluster resides. <br><li>cage-id - Array of String - Optional - Filter by the ID of the cage where the cluster resides. <br><li>disk-type - Array of string - Optional - Filter by the media type of cloud disks (`CLOUD_BASIC`: HDD cloud disk | `CLOUD_PREMIUM`: Premium cloud disk. | `CLOUD_SSD`: SSD cloud disk.)
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset, defaults to 0. For further introduction about `Offset`, see the relevant sections in the API [overview](/document/product/362/15633).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "CdcIds.", this.CdcIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

