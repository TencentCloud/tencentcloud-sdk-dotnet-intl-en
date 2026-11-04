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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpirationPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Validity time</p>
        /// </summary>
        [JsonProperty("EffectivePeriod")]
        public EffectivePeriod EffectivePeriod{ get; set; }

        /// <summary>
        /// <p>Behavior after the validity period expires: 1=NOT_RETRIEVABLE cannot be retrieved, 2=RETRIEVABLE can still be retrieved; meaningless for permanent validity<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>EXPIRE_BEHAVIOR_UNKNOWN</td><td>0</td><td>Unspecified (server uses the default process)</td></tr><tr><td>EXPIRE_BEHAVIOR_NOT_RETRIEVABLE</td><td>1</td><td>Cannot be retrieved (removed upon expiration)</td></tr><tr><td>EXPIRE_BEHAVIOR_RETRIEVABLE</td><td>2</td><td>Can still be retrieved (not removed upon expiration, only the validity period is tagged)</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ExpireBehavior")]
        public long? ExpireBehavior{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EffectivePeriod.", this.EffectivePeriod);
            this.SetParamSimple(map, prefix + "ExpireBehavior", this.ExpireBehavior);
        }
    }
}

