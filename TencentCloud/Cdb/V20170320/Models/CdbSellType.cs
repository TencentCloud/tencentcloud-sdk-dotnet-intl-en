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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CdbSellType : AbstractModel
    {
        
        /// <summary>
        /// Name of the purchasable instance. Valid values: `Z3` (High-availability instance. `DeviceType`:`UNIVERSAL`, `EXCLUSIVE`; `CVM` (basic instance. `DeviceType`: `BASIC`); `TKE` (basic v2 instance. `DeviceType`: `BASIC_V2`).
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// Engine version number
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string[] EngineVersion{ get; set; }

        /// <summary>
        /// Purchasable specifications ID
        /// </summary>
        [JsonProperty("ConfigIds")]
        public long?[] ConfigIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamArraySimple(map, prefix + "EngineVersion.", this.EngineVersion);
            this.SetParamArraySimple(map, prefix + "ConfigIds.", this.ConfigIds);
        }
    }
}

