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

    public class CreateResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type. currently fixed to cynosdb-serverless.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Resource package region of use: chineseMainland - common in the chinese mainland. overseas - universally applicable in hong kong (china), macao (china), taiwan (china), and overseas.
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// Resource pack type. Valid values: `CCU` (compute resource pack), `DISK` (storage resource pack).
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Resource pack edition. Valid values: `base` (basic edition), `common` (general edition), `enterprise` (enterprise edition).
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// Resource pack size. Unit of the compute resource pack: Ten thousand.  Unit of the storage resource pack:  GB
        /// </summary>
        [JsonProperty("PackageSpec")]
        public float? PackageSpec{ get; set; }

        /// <summary>
        /// Validity period of a resource pack in days
        /// </summary>
        [JsonProperty("ExpireDay")]
        public long? ExpireDay{ get; set; }

        /// <summary>
        /// Number of the resource packs to be purchased
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// Resource pack name
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

