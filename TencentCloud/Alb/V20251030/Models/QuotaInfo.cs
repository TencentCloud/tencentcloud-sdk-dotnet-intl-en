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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuotaInfo : AbstractModel
    {
        
        /// <summary>
        /// Current remaining available amount. Calculation method: Limit - Used. A valid value is returned only when the request parameter DisplayFields includes available. If not requested, it is not returned or is empty.
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }

        /// <summary>
        /// Quota upper limit. Different quota types have different units. It usually represents the number of resources. For timeout-related quotas, it represents seconds.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Quota type, corresponding to the values in the request parameter QuotaTypes. For the meaning of each quota type, see the QuotaTypes parameter description.
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Currently used amount. A valid value is returned only when the request parameter DisplayFields includes used. If not requested, it is not returned or is empty.
        /// </summary>
        [JsonProperty("Used")]
        public ulong? Used{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Used", this.Used);
        }
    }
}

