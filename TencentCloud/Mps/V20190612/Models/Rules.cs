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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Rules : AbstractModel
    {
        
        /// <summary>
        /// Judgment condition ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Judgment condition configuration.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Conditions")]
        public RuleConditionItem[] Conditions{ get; set; }

        /// <summary>
        /// Logical operator for the list of conditions. Valid values:
        /// 
        ///  - &&: logical AND
        ///  - ||: logical OR
        /// </summary>
        [JsonProperty("Linker")]
        public string Linker{ get; set; }

        /// <summary>
        /// Indexes of the nodes to execute if the judgment conditions are met.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RearDriveIndexs")]
        public long?[] RearDriveIndexs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "Linker", this.Linker);
            this.SetParamArraySimple(map, prefix + "RearDriveIndexs.", this.RearDriveIndexs);
        }
    }
}

