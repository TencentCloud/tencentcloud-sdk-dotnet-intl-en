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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchApplyAccountBaselinesRequest : AbstractModel
    {
        
        /// <summary>
        /// Member account UIN, which is also the UIN of the account to which the baseline is applied.
        /// </summary>
        [JsonProperty("MemberUinList")]
        public long?[] MemberUinList{ get; set; }

        /// <summary>
        /// List of baseline item configuration information.
        /// </summary>
        [JsonProperty("BaselineConfigItems")]
        public BaselineConfigItem[] BaselineConfigItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberUinList.", this.MemberUinList);
            this.SetParamArrayObj(map, prefix + "BaselineConfigItems.", this.BaselineConfigItems);
        }
    }
}

