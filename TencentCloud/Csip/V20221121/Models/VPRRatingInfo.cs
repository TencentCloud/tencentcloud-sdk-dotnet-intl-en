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

    public class VPRRatingInfo : AbstractModel
    {
        
        /// <summary>
        /// VPR rating result
        /// Enumeration value:
        /// URGENT: Immediate repair
        /// SUGGESTED: Suggested repairs
        /// DEFERRABLE: Deferrable repair
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// Rating description
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// List of stage rating details
        /// </summary>
        [JsonProperty("Stage")]
        public VPRRatingStage[] Stage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Stage.", this.Stage);
        }
    }
}

