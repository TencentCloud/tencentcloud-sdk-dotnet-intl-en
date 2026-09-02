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

    public class ModifyEDRRulesActionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Policy ID array</p>
        /// </summary>
        [JsonProperty("RuleIDs")]
        public string[] RuleIDs{ get; set; }

        /// <summary>
        /// <p>Target Action: 0-Alert 1-Allow 2-Alert and block</p>
        /// </summary>
        [JsonProperty("AlertAction")]
        public long? AlertAction{ get; set; }

        /// <summary>
        /// <p>Target account AppId list</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleIDs.", this.RuleIDs);
            this.SetParamSimple(map, prefix + "AlertAction", this.AlertAction);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

