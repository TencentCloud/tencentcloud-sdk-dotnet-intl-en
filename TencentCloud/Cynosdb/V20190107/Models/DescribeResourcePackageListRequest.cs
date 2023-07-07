/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeResourcePackageListRequest : AbstractModel
    {
        
        /// <summary>
        /// The unique ID of a resource pack
        /// </summary>
        [JsonProperty("PackageId")]
        public string[] PackageId{ get; set; }

        /// <summary>
        /// Resource pack name
        /// </summary>
        [JsonProperty("PackageName")]
        public string[] PackageName{ get; set; }

        /// <summary>
        /// Resource pack type. Valid values: `CCU` (compute resource pack), `DISK` (storage resource pack).
        /// </summary>
        [JsonProperty("PackageType")]
        public string[] PackageType{ get; set; }

        /// <summary>
        /// Region of the resource pack. Valid values: `China` (Chinese mainland), `overseas` (outside Chinese mainland).
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string[] PackageRegion{ get; set; }

        /// <summary>
        /// Resource pack status. Valid values: `using`, `expired`, `normal_finish` (used up), `apply_refund` (requesting a refund), `refund` (refunded).
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// Sorting conditions. Valid values: `startTime` (effective time), `expireTime` (expiration date), `packageUsedSpec` (used capacity), `packageTotalSpec` (total storage capacity). 
        /// Sorting by array order
        /// </summary>
        [JsonProperty("OrderBy")]
        public string[] OrderBy{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: `ASC` (ascending), `DESC` (descending).
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PackageId.", this.PackageId);
            this.SetParamArraySimple(map, prefix + "PackageName.", this.PackageName);
            this.SetParamArraySimple(map, prefix + "PackageType.", this.PackageType);
            this.SetParamArraySimple(map, prefix + "PackageRegion.", this.PackageRegion);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

