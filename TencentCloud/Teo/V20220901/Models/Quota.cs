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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Batch")]
        public long? Batch{ get; set; }

        /// <summary>
        /// Daily submission quota limit.
        /// </summary>
        [JsonProperty("Daily")]
        public long? Daily{ get; set; }

        /// <summary>
        /// Remaining daily submission quota.
        /// </summary>
        [JsonProperty("DailyAvailable")]
        public long? DailyAvailable{ get; set; }

        /// <summary>
        /// Type of cache purging/pre-warming. Values:
        /// <li>`purge_prefix`: Purge by prefix</li>
        /// <li>`purge_url`: Purge by URL</li>
        /// <li>`purge_host`: Purge by hostname</li>
        /// <li>`purge_all`: Purge all caches</li>
        /// <li>`purge_cache_tag`: Purge by cache tag</li><li>`prefetch_url`: Pre-warm by URL</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Batch", this.Batch);
            this.SetParamSimple(map, prefix + "Daily", this.Daily);
            this.SetParamSimple(map, prefix + "DailyAvailable", this.DailyAvailable);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

