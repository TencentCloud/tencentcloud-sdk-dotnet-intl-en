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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullSmsReplyStatus : AbstractModel
    {
        
        /// <summary>
        /// SMS code number extension, which is not activated by default. If you need to activate it, please contact [SMS Helper](https://intl.cloud.tencent.com/document/product/382/3773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ExtendCode")]
        public string ExtendCode{ get; set; }

        /// <summary>
        /// Country (or region) code.
        /// </summary>
        [JsonProperty("NationCode")]
        public string NationCode{ get; set; }

        /// <summary>
        /// Mobile number in the e.164 standard (+[country/region code][mobile number]), such as +8613711112222, which has a + sign followed by 86 (country/region code) and then by 13711112222 (mobile number).
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// SMS signature.
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// User reply.
        /// </summary>
        [JsonProperty("ReplyContent")]
        public string ReplyContent{ get; set; }

        /// <summary>
        /// Reply time (e.g., 2019-10-08 17:18:37).
        /// </summary>
        [JsonProperty("ReplyTime")]
        public string ReplyTime{ get; set; }

        /// <summary>
        /// Reply time in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("ReplyUnixTime")]
        public ulong? ReplyUnixTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExtendCode", this.ExtendCode);
            this.SetParamSimple(map, prefix + "NationCode", this.NationCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamSimple(map, prefix + "ReplyContent", this.ReplyContent);
            this.SetParamSimple(map, prefix + "ReplyTime", this.ReplyTime);
            this.SetParamSimple(map, prefix + "ReplyUnixTime", this.ReplyUnixTime);
        }
    }
}

