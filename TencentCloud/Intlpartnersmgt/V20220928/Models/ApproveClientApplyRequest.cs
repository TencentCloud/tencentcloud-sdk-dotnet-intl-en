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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApproveClientApplyRequest : AbstractModel
    {
        
        /// <summary>
        /// Sub-customer uin.
        /// </summary>
        [JsonProperty("ClientUin")]
        public long? ClientUin{ get; set; }

        /// <summary>
        /// Approval type. only supports pass and reject.
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// Reason for rejection. required only when approvetype is reject.
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
        }
    }
}

