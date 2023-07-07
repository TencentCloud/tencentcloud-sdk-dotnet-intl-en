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
        /// Region of the resource pack Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Resource pack type. Valid values: `CCU` (compute resource pack), `DISK` (storage resource pack). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource pack edition. Valid values: `base` (basic edition), `common` (general edition), `enterprise` (enterprise edition). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Minimum number of resources for the current edition of the resource pack.  Unit of the compute resources: pcs.  Unit of the storage resources: GB. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinPackageSpec")]
        public float? MinPackageSpec{ get; set; }

        /// <summary>
        /// Maximum number of resources for the current edition of the resource pack.  Unit of the compute resources: pcs.  Unit of the storage resources: GB. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxPackageSpec")]
        public float? MaxPackageSpec{ get; set; }

        /// <summary>
        /// Validity period of a resource pack in days Note: This field may return null, indicating that no valid values can be obtained.
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

