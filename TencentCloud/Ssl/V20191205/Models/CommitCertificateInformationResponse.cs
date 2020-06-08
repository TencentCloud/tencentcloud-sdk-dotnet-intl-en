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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommitCertificateInformationResponse : AbstractModel
    {
        
        /// <summary>
        /// TrustAsia order ID
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// Certificate status. 0: being reviewed; 1: approved; 2: not approved; 3: expired; 4: DNS record added; 5: OV certificate, to be submitted; 6: order being canceled; 7: cancelled; 8: information submitted, confirmation letter to be uploaded; 9: certificate being revoked; 10: revoked; 11: reissuing; 12: revocation confirmation letter to be uploaded.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

