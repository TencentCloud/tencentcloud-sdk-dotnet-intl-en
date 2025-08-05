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

    public class BotPortraitRule : AbstractModel
    {
        
        /// <summary>
        /// Switch. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The rule ID, which is only used as an output parameter.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// The rule ID of JS challenge. default all rules without configuring JS challenge.
        /// </summary>
        [JsonProperty("AlgManagedIds")]
        public long?[] AlgManagedIds{ get; set; }

        /// <summary>
        /// Rule ID for digit captcha-intl. default is all rules without configuring digit captcha-intl.
        /// </summary>
        [JsonProperty("CapManagedIds")]
        public long?[] CapManagedIds{ get; set; }

        /// <summary>
        /// Rule ID for observation. by default, observation is not configured for all rules.
        /// </summary>
        [JsonProperty("MonManagedIds")]
        public long?[] MonManagedIds{ get; set; }

        /// <summary>
        /// Rule ID for interception. default to all rules with no configuration interception.
        /// </summary>
        [JsonProperty("DropManagedIds")]
        public long?[] DropManagedIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "AlgManagedIds.", this.AlgManagedIds);
            this.SetParamArraySimple(map, prefix + "CapManagedIds.", this.CapManagedIds);
            this.SetParamArraySimple(map, prefix + "MonManagedIds.", this.MonManagedIds);
            this.SetParamArraySimple(map, prefix + "DropManagedIds.", this.DropManagedIds);
        }
    }
}

