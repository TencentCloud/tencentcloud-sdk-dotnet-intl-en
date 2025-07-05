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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexPolicyField : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the warm phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WarmEnable")]
        public string WarmEnable{ get; set; }

        /// <summary>
        /// Min age before data transitions to the warm phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WarmMinAge")]
        public string WarmMinAge{ get; set; }

        /// <summary>
        /// Whether to enable the cold phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColdEnable")]
        public string ColdEnable{ get; set; }

        /// <summary>
        /// Min age before data transitions to the cold phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColdMinAge")]
        public string ColdMinAge{ get; set; }

        /// <summary>
        /// Whether to enable the frozen phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FrozenEnable")]
        public string FrozenEnable{ get; set; }

        /// <summary>
        /// Min age before data transitions to the frozen phase
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FrozenMinAge")]
        public string FrozenMinAge{ get; set; }

        /// <summary>
        /// /
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColdAction")]
        public string ColdAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarmEnable", this.WarmEnable);
            this.SetParamSimple(map, prefix + "WarmMinAge", this.WarmMinAge);
            this.SetParamSimple(map, prefix + "ColdEnable", this.ColdEnable);
            this.SetParamSimple(map, prefix + "ColdMinAge", this.ColdMinAge);
            this.SetParamSimple(map, prefix + "FrozenEnable", this.FrozenEnable);
            this.SetParamSimple(map, prefix + "FrozenMinAge", this.FrozenMinAge);
            this.SetParamSimple(map, prefix + "ColdAction", this.ColdAction);
        }
    }
}

