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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyWebVerificationBizTokenIntlRequest : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded string (max 8 MB in size) of the photo to be compared.
        /// </summary>
        [JsonProperty("CompareImageBase64")]
        public string CompareImageBase64{ get; set; }

        /// <summary>
        /// The web callback URL to redirect to after the verification is completed, including the protocol, hostname, and path. Example: `https://www.tencentcloud.com/products/faceid`.
        /// After the verification process is completed, the `BizToken` of this process will be spliced to the callback URL in the format of `https://www.tencentcloud.com/products/faceid?token={BizToken}` before redirect.
        /// </summary>
        [JsonProperty("RedirectURL")]
        public string RedirectURL{ get; set; }

        /// <summary>
        /// The passthrough parameter of the business, max 1,000 characters, which will be returned in `GetWebVerificationResultIntl`.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompareImageBase64", this.CompareImageBase64);
            this.SetParamSimple(map, prefix + "RedirectURL", this.RedirectURL);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

