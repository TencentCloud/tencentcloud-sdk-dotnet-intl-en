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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEmailIdentityResponse : AbstractModel
    {
        
        /// <summary>
        /// Verification type. The value is fixed to `DOMAIN`.
        /// </summary>
        [JsonProperty("IdentityType")]
        public string IdentityType{ get; set; }

        /// <summary>
        /// Verification passed or not.
        /// </summary>
        [JsonProperty("VerifiedForSendingStatus")]
        public bool? VerifiedForSendingStatus{ get; set; }

        /// <summary>
        /// DNS configuration details.
        /// </summary>
        [JsonProperty("Attributes")]
        public DNSAttributes[] Attributes{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityType", this.IdentityType);
            this.SetParamSimple(map, prefix + "VerifiedForSendingStatus", this.VerifiedForSendingStatus);
            this.SetParamArrayObj(map, prefix + "Attributes.", this.Attributes);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

