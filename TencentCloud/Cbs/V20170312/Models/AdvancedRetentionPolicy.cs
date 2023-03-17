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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedRetentionPolicy : AbstractModel
    {
        
        /// <summary>
        /// Retains one latest snapshot each day within `Days` days. Value range: [0, 100].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Days")]
        public ulong? Days{ get; set; }

        /// <summary>
        /// Retains one latest snapshot each week within `Weeks` weeks. Value range: [0, 100].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weeks")]
        public ulong? Weeks{ get; set; }

        /// <summary>
        /// Retains one latest snapshot each month within `Months` months. Value range: [0, 100].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Months")]
        public ulong? Months{ get; set; }

        /// <summary>
        /// Retains one latest snapshot each year within `Years` years. Value range: [0, 100].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Years")]
        public ulong? Years{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Days", this.Days);
            this.SetParamSimple(map, prefix + "Weeks", this.Weeks);
            this.SetParamSimple(map, prefix + "Months", this.Months);
            this.SetParamSimple(map, prefix + "Years", this.Years);
        }
    }
}

