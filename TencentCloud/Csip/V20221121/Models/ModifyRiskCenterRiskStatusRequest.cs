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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRiskCenterRiskStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Data of risk assets
        /// </summary>
        [JsonProperty("RiskStatusKeys")]
        public RiskCenterStatusKey[] RiskStatusKeys{ get; set; }

        /// <summary>
        /// Specify how you want to change the risk status. `1`: Change to Handled, `2`: Change to Ignored; `3`: Remove from Handled; `4`: Remove from Ignored
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Risk type. `0`: Port risk; `1`: Vulnerability; `2`: Weak password; `3`: Website content risk; `4`: Configuration risk; `5`: Risk services
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RiskStatusKeys.", this.RiskStatusKeys);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

