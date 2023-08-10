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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvironmentRoleSet : AbstractModel
    {
        
        /// <summary>
        /// The IDs of the bound namespaces cannot be delicate and the namespaces must contain resources
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Permissions to be bound to a namespace. Enumerated values: `consume`, `produce`, and `consume, produce`. This parameter cannot be left empty.
        /// 
        /// Note: u200dThis field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
        }
    }
}

