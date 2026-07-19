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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyPaymentOpenDetailRes : AbstractModel
    {
        
        /// <summary>
        /// <p>Approval status. Valid values: 0: In progress; 10: Approved; 20: Rejected.</p>
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// <p>Application time.</p><p>Unit: Milliseconds.</p>
        /// </summary>
        [JsonProperty("ApplyTime")]
        public long? ApplyTime{ get; set; }

        /// <summary>
        /// <p>Approval time.</p><p>Unit: milliseconds.</p>
        /// </summary>
        [JsonProperty("ApprovalTime")]
        public long? ApprovalTime{ get; set; }

        /// <summary>
        /// <p>Approval note.</p>
        /// </summary>
        [JsonProperty("ApprovalNote")]
        public string ApprovalNote{ get; set; }

        /// <summary>
        /// <p>Specifies whether to display the approval records. Valid values: 0: No; 1: Yes.</p>
        /// </summary>
        [JsonProperty("ApprovalShow")]
        public long? ApprovalShow{ get; set; }

        /// <summary>
        /// <p>Specifies whether the activation of mini program payment can be requested again. Valid values: 0: No; 1: Yes.</p>
        /// </summary>
        [JsonProperty("ApplyShow")]
        public long? ApplyShow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ApprovalTime", this.ApprovalTime);
            this.SetParamSimple(map, prefix + "ApprovalNote", this.ApprovalNote);
            this.SetParamSimple(map, prefix + "ApprovalShow", this.ApprovalShow);
            this.SetParamSimple(map, prefix + "ApplyShow", this.ApplyShow);
        }
    }
}

