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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SRTFECFullOptions : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable FEC.
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// Number of FEC data packet Layout columns. Value range: >0
        /// </summary>
        [JsonProperty("Cols")]
        public long? Cols{ get; set; }

        /// <summary>
        /// Number of FEC data packet Layout rows. Value ranges from >=2 or <=-2.
        /// </summary>
        [JsonProperty("Rows")]
        public long? Rows{ get; set; }

        /// <summary>
        /// ARQ policy when FEC is enabled. Value: "always", "onreq", "never".
        /// </summary>
        [JsonProperty("ARQ")]
        public string ARQ{ get; set; }

        /// <summary>
        /// FEC data packet Layout organization. Value: "even", "staircase"
        /// </summary>
        [JsonProperty("Layout")]
        public string Layout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Cols", this.Cols);
            this.SetParamSimple(map, prefix + "Rows", this.Rows);
            this.SetParamSimple(map, prefix + "ARQ", this.ARQ);
            this.SetParamSimple(map, prefix + "Layout", this.Layout);
        }
    }
}

