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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CredentialEffectScope : AbstractModel
    {
        
        /// <summary>
        /// Whether to exclude the mode
        /// Enumeration values:
        /// 0: Inclusion mode (only takes effect on the Real Server in Instances). At this point, Instances is required.
        /// 1: Exclusion mode (Machines in Instances do not take effect, remaining machines take effect). At this point, Instances is selectable (Empty list means all machines take effect).
        /// </summary>
        [JsonProperty("Exclude")]
        public long? Exclude{ get; set; }

        /// <summary>
        /// Machine instance ID list. Required when Exclude is 0, means only these machines can access the credential; Option when Exclude is 1, means these machines cannot access the credential (Empty list means all machines take effect).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Instances")]
        public string[] Instances{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Exclude", this.Exclude);
            this.SetParamArraySimple(map, prefix + "Instances.", this.Instances);
        }
    }
}

