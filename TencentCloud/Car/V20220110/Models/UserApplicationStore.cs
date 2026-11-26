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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserApplicationStore : AbstractModel
    {
        
        /// <summary>
        /// <p>Cos bucket name</p>
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// <p>Cos Bucket Region</p>
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// <p>Repository type. LOG: application logs; ARCHIVE: application archive.</p>
        /// </summary>
        [JsonProperty("StoreType")]
        public string StoreType{ get; set; }

        /// <summary>
        /// <p>Repository status. ON: enabled; OFF: disabled.</p>
        /// </summary>
        [JsonProperty("StoreState")]
        public string StoreState{ get; set; }

        /// <summary>
        /// <p>Repository path</p><p>Primary path data. If StoreType is ARCHIVE and SubStorePaths is configured, the system default value will be used.</p>
        /// </summary>
        [JsonProperty("StorePath")]
        public string StorePath{ get; set; }

        /// <summary>
        /// <p>Subpath list</p><p>Subpath data (multi-path pattern) supports only ARCHIVE StoreType; up to 25 data entries.</p>
        /// </summary>
        [JsonProperty("SubStorePaths")]
        public string[] SubStorePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "StoreType", this.StoreType);
            this.SetParamSimple(map, prefix + "StoreState", this.StoreState);
            this.SetParamSimple(map, prefix + "StorePath", this.StorePath);
            this.SetParamArraySimple(map, prefix + "SubStorePaths.", this.SubStorePaths);
        }
    }
}

