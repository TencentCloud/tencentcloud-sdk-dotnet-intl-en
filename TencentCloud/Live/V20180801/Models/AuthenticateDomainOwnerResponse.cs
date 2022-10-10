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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticateDomainOwnerResponse : AbstractModel
    {
        
        /// <summary>
        /// The content verified.
        /// If `VerifyType` is `dnsCheck`, this is the TXT record that should be added for verification.
        /// If `VerifyType` is `fileCheck`, this is the file that should be uploaded for verification.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// The verification status.
        /// If the value of this parameter is 0 or greater, the domain has been verified.
        /// If the value of this parameter is smaller than 0, the domain has not been verified.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// The primary domain of the domain verified.
        /// Verification is not required if another domain under the same primary domain has been successfully verified.
        /// </summary>
        [JsonProperty("MainDomain")]
        public string MainDomain{ get; set; }

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
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MainDomain", this.MainDomain);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

