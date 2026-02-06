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

    public class DescribeMNPSensitiveAPIPermissionApprovalData : AbstractModel
    {
        
        /// <summary>
        /// API ID
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// API method.
        /// </summary>
        [JsonProperty("APIMethod")]
        public string APIMethod{ get; set; }

        /// <summary>
        /// Reason for application
        /// </summary>
        [JsonProperty("ApplyReason")]
        public string ApplyReason{ get; set; }

        /// <summary>
        /// Reason for rejection.
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }

        /// <summary>
        /// Approval status. valid values: 20 (rejected), 30 (approved).
        /// </summary>
        [JsonProperty("ApprovalStatus")]
        public long? ApprovalStatus{ get; set; }

        /// <summary>
        /// API feature description.
        /// </summary>
        [JsonProperty("APIDesc")]
        public string APIDesc{ get; set; }

        /// <summary>
        /// API type. 1: system; 2: custom.
        /// </summary>
        [JsonProperty("APIType")]
        public long? APIType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "APIId", this.APIId);
            this.SetParamSimple(map, prefix + "APIMethod", this.APIMethod);
            this.SetParamSimple(map, prefix + "ApplyReason", this.ApplyReason);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
            this.SetParamSimple(map, prefix + "ApprovalStatus", this.ApprovalStatus);
            this.SetParamSimple(map, prefix + "APIDesc", this.APIDesc);
            this.SetParamSimple(map, prefix + "APIType", this.APIType);
        }
    }
}

