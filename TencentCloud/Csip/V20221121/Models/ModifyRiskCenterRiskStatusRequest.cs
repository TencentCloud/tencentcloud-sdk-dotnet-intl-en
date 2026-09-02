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

    public class ModifyRiskCenterRiskStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Risky Asset Related Data
        /// </summary>
        [JsonProperty("RiskStatusKeys")]
        public RiskCenterStatusKey[] RiskStatusKeys{ get; set; }

        /// <summary>
        /// Disposition status. 1: Handled; 2: Ignored; 3: Cancel disposed; 4: Cancel ignored.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Risk Type. 0: Port Risk; 1: Vulnerability Risk; 2: Weak Password Risk; 3: Web Sites Content Risk; 4: Configuration Risk; 5: Exposed Risk Service
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RiskStatusKeys.", this.RiskStatusKeys);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

