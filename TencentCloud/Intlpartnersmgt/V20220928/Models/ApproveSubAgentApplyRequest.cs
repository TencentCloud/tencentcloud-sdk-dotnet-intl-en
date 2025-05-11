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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApproveSubAgentApplyRequest : AbstractModel
    {
        
        /// <summary>
        /// Second-level reseller UIN.
        /// </summary>
        [JsonProperty("SubAgentUin")]
        public long? SubAgentUin{ get; set; }

        /// <summary>
        /// Approval type. Only pass and reject are supported.
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// Reason for rejection. Fill in only when ApproveType is reject.
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAgentUin", this.SubAgentUin);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
        }
    }
}

