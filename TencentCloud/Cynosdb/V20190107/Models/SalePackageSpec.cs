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

    public class SalePackageSpec : AbstractModel
    {
        
        /// <summary>
        /// Resource package region of use.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Specifies the resource package type.
        /// CCU - compute resource package.
        /// Storage resource package.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource pack version.
        /// base - basic version; common - general version; enterprise - enterprise edition.
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Minimum number of resources in the current version of the resource package. compute resource unit: pieces; storage resource: GB.
        /// </summary>
        [JsonProperty("MinPackageSpec")]
        public float? MinPackageSpec{ get; set; }

        /// <summary>
        /// Specifies the maximum number of resources in the current version of the resource package. valid values: compute resource unit: pieces; storage resource: GB.
        /// </summary>
        [JsonProperty("MaxPackageSpec")]
        public float? MaxPackageSpec{ get; set; }

        /// <summary>
        /// Specifies the resource pack validity period. the measurement unit is day.
        /// </summary>
        [JsonProperty("ExpireDay")]
        public long? ExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "MinPackageSpec", this.MinPackageSpec);
            this.SetParamSimple(map, prefix + "MaxPackageSpec", this.MaxPackageSpec);
            this.SetParamSimple(map, prefix + "ExpireDay", this.ExpireDay);
        }
    }
}

