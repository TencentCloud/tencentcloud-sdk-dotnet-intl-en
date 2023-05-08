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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddNatAcRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT access control rules to be added.
        /// </summary>
        [JsonProperty("Rules")]
        public CreateNatRuleItem[] Rules{ get; set; }

        /// <summary>
        /// Source of the rules to be added. Generally, this parameter is not used. The value insert_rule indicates that rules in the specified location are inserted, and the value batch_import indicates that rules are imported in batches. If the parameter is left empty, rules defined in the API request are added.
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "From", this.From);
        }
    }
}

