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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsInfo : AbstractModel
    {
        
        /// <summary>
        /// Minimum number of instances
        /// </summary>
        [JsonProperty("MinAliveInstances")]
        public long? MinAliveInstances{ get; set; }

        /// <summary>
        /// Maximum number of instances
        /// </summary>
        [JsonProperty("MaxAliveInstances")]
        public long? MaxAliveInstances{ get; set; }

        /// <summary>
        /// Auto scaling policy. 1: CPU; 2: memory
        /// </summary>
        [JsonProperty("EsStrategy")]
        public long? EsStrategy{ get; set; }

        /// <summary>
        /// Auto scaling condition value
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// Version ID
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinAliveInstances", this.MinAliveInstances);
            this.SetParamSimple(map, prefix + "MaxAliveInstances", this.MaxAliveInstances);
            this.SetParamSimple(map, prefix + "EsStrategy", this.EsStrategy);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
        }
    }
}

