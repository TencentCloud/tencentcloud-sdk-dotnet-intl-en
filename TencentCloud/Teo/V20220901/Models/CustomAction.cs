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

    public class CustomAction : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the custom configuration item.</p><p>You can obtain it through the returned value CustomActionSet[].ActionId of the DescribeAvailableCustomActionsForRuleEngine API.</p>
        /// </summary>
        [JsonProperty("ActionId")]
        public string ActionId{ get; set; }

        /// <summary>
        /// <p>Parameter values of each parameter field under this custom configuration.</p><p>You can obtain them through the API return value CustomActionSet[].Parameters of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("Parameters")]
        public CustomActionParameter[] Parameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamArrayObj(map, prefix + "Parameters.", this.Parameters);
        }
    }
}

