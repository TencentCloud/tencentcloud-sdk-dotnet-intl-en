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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCallOutSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Customer service user ID, generally the customer service email. ensure that the mobile number has been bound. https://intl.cloud.tencent.com/document/product/679/76067?from_cn_redirect=1#.E6.AD.A5.E9.AA.A42.EF.BC.9A.E5.AE.8C.E5.96.84.E8.B4.A6.E5.8F.B7.E4.BF.A1.E6.81.AF.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Called number must be preceded by 0086.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// Caller number (obsolete one and use callers) must be preceded by 0086.
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// Designated caller number list. if the prior number fails, it will automatically switch to the next number that must be preceded by 0086.
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// Whether to force the use of mobile outbound call. currently only supports true. if set to true, ensure the allowlist is configured. https://intl.cloud.tencent.com/document/product/679/76744?from_cn_redirect=1#.E6.93.8D.E4.BD.9C.E6.AD.A5.E9.AA.A4.
        /// </summary>
        [JsonProperty("IsForceUseMobile")]
        public bool? IsForceUseMobile{ get; set; }

        /// <summary>
        /// Custom data, length limited to 1024 bytes.
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// Custom data, length limited to 1024 bytes.
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "IsForceUseMobile", this.IsForceUseMobile);
            this.SetParamSimple(map, prefix + "Uui", this.Uui);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
        }
    }
}

