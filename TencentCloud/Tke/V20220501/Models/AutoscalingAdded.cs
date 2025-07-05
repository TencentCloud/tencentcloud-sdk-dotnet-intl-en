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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoscalingAdded : AbstractModel
    {
        
        /// <summary>
        /// Number of nodes being added
        /// </summary>
        [JsonProperty("Joining")]
        public long? Joining{ get; set; }

        /// <summary>
        /// Number of nodes being initialized
        /// </summary>
        [JsonProperty("Initializing")]
        public long? Initializing{ get; set; }

        /// <summary>
        /// Number of normal nodes
        /// </summary>
        [JsonProperty("Normal")]
        public long? Normal{ get; set; }

        /// <summary>
        /// Total number of nodes
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Joining", this.Joining);
            this.SetParamSimple(map, prefix + "Initializing", this.Initializing);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "Total", this.Total);
        }
    }
}

