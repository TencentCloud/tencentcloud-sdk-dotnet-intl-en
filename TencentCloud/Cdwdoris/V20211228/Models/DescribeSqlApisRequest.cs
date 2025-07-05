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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSqlApisRequest : AbstractModel
    {
        
        /// <summary>
        /// The IP address of the user link
        /// </summary>
        [JsonProperty("WhiteHost")]
        public string WhiteHost{ get; set; }

        /// <summary>
        /// catalog name
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// Catalog collection
        /// </summary>
        [JsonProperty("Catalogs")]
        public string[] Catalogs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhiteHost", this.WhiteHost);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamArraySimple(map, prefix + "Catalogs.", this.Catalogs);
        }
    }
}

