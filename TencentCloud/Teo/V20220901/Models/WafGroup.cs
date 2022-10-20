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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WafGroup : AbstractModel
    {
        
        /// <summary>
        /// Action to be executed. Values:
        /// <li>`block`: Block</li>
        /// <li>`observe: Observe</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The protection level. Values:
        /// <li>`loose`: Loose</li>
        /// <li>`normal`: Moderate</li>
        /// <li>`strict`: Strict</li>
        /// <li>`stricter`: Super strict</li>
        /// <li>`custom`: Custom</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// ID of the rule type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
        }
    }
}

