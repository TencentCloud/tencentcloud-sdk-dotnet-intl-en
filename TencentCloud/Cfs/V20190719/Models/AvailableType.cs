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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableType : AbstractModel
    {
        
        /// <summary>
        /// <p>Protocol and sale details</p>
        /// </summary>
        [JsonProperty("Protocols")]
        public AvailableProtoStatus[] Protocols{ get; set; }

        /// <summary>
        /// <p>Storage type. In the return value, SD indicates General Standard Storage, HP indicates General Performance Storage, TB indicates Standard Turbo, and TP indicates High-Performance Turbo.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Support for prepaid. In the return value, true means supported and false means unsupported.</p>
        /// </summary>
        [JsonProperty("Prepayment")]
        public bool? Prepayment{ get; set; }

        /// <summary>
        /// <p>File system version</p><p>Enumeration value:</p><ul><li>v1.5: Universal Series</li><li>v3.1: Universal Series (enhanced)</li><li>v4.0: Turbo series</li></ul>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Prepayment", this.Prepayment);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

