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

    public class BaselineCustomItemConf : AbstractModel
    {
        
        /// <summary>
        /// <p>Built-in detection item rule ID. Either this or CustomItemID needs to be imported.</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// <p>User-defined judgment value list, which must comply with the value constraints defined by the detection item WebEditParam.</p>
        /// </summary>
        [JsonProperty("CustomValueList")]
        public string[] CustomValueList{ get; set; }

        /// <summary>
        /// <p>Existing custom configuration ID. It can be omitted when projects are added and is filled in when editing.</p>
        /// </summary>
        [JsonProperty("CustomItemID")]
        public ulong? CustomItemID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "CustomValueList.", this.CustomValueList);
            this.SetParamSimple(map, prefix + "CustomItemID", this.CustomItemID);
        }
    }
}

