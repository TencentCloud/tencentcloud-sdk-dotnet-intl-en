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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SummaryOutput : AbstractModel
    {
        
        /// <summary>
        /// Output method: 1. streaming; 2. non-streaming.
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// Output requirement 1: text summary. 2: customized requirement.
        /// </summary>
        [JsonProperty("Requirement")]
        public ulong? Requirement{ get; set; }

        /// <summary>
        /// Custom requirement command.
        /// </summary>
        [JsonProperty("RequireCommand")]
        public string RequireCommand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Requirement", this.Requirement);
            this.SetParamSimple(map, prefix + "RequireCommand", this.RequireCommand);
        }
    }
}

