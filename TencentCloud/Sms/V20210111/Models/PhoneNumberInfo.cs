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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhoneNumberInfo : AbstractModel
    {
        
        /// <summary>
        /// Error code for mobile number information query. `Ok` will be returned if the query is successful.
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// Description of the error code for mobile number information query.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Country (or region) code.
        /// </summary>
        [JsonProperty("NationCode")]
        public string NationCode{ get; set; }

        /// <summary>
        /// Subscriber number in normal format such as 13711112222, without any prefix (country or region code).
        /// </summary>
        [JsonProperty("SubscriberNumber")]
        public string SubscriberNumber{ get; set; }

        /// <summary>
        /// The standardized mobile number in E.164 format after parsing, which is consistent with the parsed number for SMS message delivery. If the parsing fails, the original number will be returned.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Country or region code such as CN and US. If the country or region code cannot be identified, `DEF` will be returned by default.
        /// </summary>
        [JsonProperty("IsoCode")]
        public string IsoCode{ get; set; }

        /// <summary>
        /// Country code or region name such as China. For more information, see [Global SMS Price Overview](https://intl.cloud.tencent.com/document/product/382/18051?from_cn_redirect=1#.E6.97.A5.E7.BB.93.E5.90.8E.E4.BB.98.E8.B4.B9.3Ca-id.3D.22post-payment.22.3E.3C.2Fa.3E)
        /// </summary>
        [JsonProperty("IsoName")]
        public string IsoName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "NationCode", this.NationCode);
            this.SetParamSimple(map, prefix + "SubscriberNumber", this.SubscriberNumber);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "IsoCode", this.IsoCode);
            this.SetParamSimple(map, prefix + "IsoName", this.IsoName);
        }
    }
}

