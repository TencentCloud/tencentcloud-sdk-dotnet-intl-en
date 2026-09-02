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

    public class CreateDspmApplyOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// Asset ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// Application type. `0`: sub-account authorization. `1`: visitor authorization.
        /// </summary>
        [JsonProperty("ApplyType")]
        public long? ApplyType{ get; set; }

        /// <summary>
        /// Permission information.
        /// </summary>
        [JsonProperty("Privilege")]
        public DspmDbAccountPrivilege Privilege{ get; set; }

        /// <summary>
        /// Host address. Currently only support '%'. Default: '%'.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// Access privilege expiration time calculated after approval is complete. The temporary account is valid. Milliseconds.
        /// </summary>
        [JsonProperty("ValidatePeriod")]
        public long? ValidatePeriod{ get; set; }

        /// <summary>
        /// List of approvers. If empty, all asset admins are used.
        /// </summary>
        [JsonProperty("ApproverUin")]
        public string[] ApproverUin{ get; set; }

        /// <summary>
        /// Reason for request
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Management type. 0: ordinary member; 1: admin.
        /// </summary>
        [JsonProperty("ManagerType")]
        public long? ManagerType{ get; set; }

        /// <summary>
        /// Authorized person. For sub-account authorization, pass the target uin. If empty, use the current uin by default. For visitor authorization, pass the visitor identity ID.
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "Privilege.", this.Privilege);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ValidatePeriod", this.ValidatePeriod);
            this.SetParamArraySimple(map, prefix + "ApproverUin.", this.ApproverUin);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ManagerType", this.ManagerType);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
        }
    }
}

