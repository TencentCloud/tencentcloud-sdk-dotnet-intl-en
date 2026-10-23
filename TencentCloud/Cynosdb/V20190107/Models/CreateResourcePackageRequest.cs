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

    public class CreateResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type. Currently fixed to cynosdb-serverless.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Region of resource package use. chineseMainland: common in the Chinese mainland; overseas: common in Hong Kong (China), Macao (China), Taiwan (China), and overseas regions.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Resource package type. CCU: compute resource package. DISK: storage resource package.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource pack version
        /// base: basic version, common: general version, enterprise: Enterprise Edition
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Package size. Compute resource unit: count. Storage resource: GB.
        /// </summary>
        [JsonProperty("PackageSpec")]
        public float? PackageSpec{ get; set; }

        /// <summary>
        /// Resource pack validity period. Unit: day.
        /// </summary>
        [JsonProperty("ExpireDay")]
        public long? ExpireDay{ get; set; }

        /// <summary>
        /// Number of resource packages to purchase
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// Resource package name.
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "PackageSpec", this.PackageSpec);
            this.SetParamSimple(map, prefix + "ExpireDay", this.ExpireDay);
            this.SetParamSimple(map, prefix + "PackageCount", this.PackageCount);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

