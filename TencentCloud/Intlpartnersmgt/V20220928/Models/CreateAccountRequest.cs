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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Account type of a new customer.
        /// Valid values: `personal`, `company`.
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// Registered email address, which should be valid and correct.
        /// such as "account@qq.com"
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// Account password.
        /// Length limit: 8-20 characters
        /// A password must contain numbers, letters, and symbols (!@#$%^&*()). Space is not allowed.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// The confirmed password, which must be the same as that entered in the `Password` field.
        /// </summary>
        [JsonProperty("ConfirmPassword")]
        public string ConfirmPassword{ get; set; }

        /// <summary>
        /// Customer's mobile number.
        /// The caller needs to ensure the validity and correctness of the mobile number. A global mobile number within a range of 1-32 digits is allowed.
        /// The system will perform binding limit verification of the mobile number you provide, allowing a maximum of 5 accounts per mobile number.
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// Customer's country/region code, which can be obtained via the  [GetCountryCodes API](https://www.tencentcloud.com/document/product/1085/51416), such as "852".
        /// Parameter value is not allowed to be 7,380,86.
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// Customer's ISO2 standard country/region code, which can be obtained via the [GetCountryCodes API](https://www.tencentcloud.com/document/product/1085/51416). It should correspond to the `CountryCode` field, such as `HK`.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// VerifyCode. This parameter is required. 
        /// Use the [SendVerifyCode API](https://www.tencentcloud.com/document/product/1085/65907) to obtain the verifycode.The SendVerifyCode API sends a 6-digit verifycode to your specified mobile number via SMS. After receiving it, you need to pass it along with other parameters.
        /// </summary>
        [JsonProperty("VerifyCode")]
        public string VerifyCode{ get; set; }

        /// <summary>
        /// Extension field, which is left empty by default.
        /// </summary>
        [JsonProperty("Extended")]
        public string Extended{ get; set; }

        /// <summary>
        /// Layer-1 industry id. This is a required item and can be obtained via the [ GetTradeConfigList  API](https://www.tencentcloud.com/zh/document/product/1085/68181),
        /// such as "kghy_01".
        /// </summary>
        [JsonProperty("TradeOne")]
        public string TradeOne{ get; set; }

        /// <summary>
        /// Layer-2 industry id. This is a required item and can be obtained via the [ GetTradeConfigList API](https://www.tencentcloud.com/zh/document/product/1085/68181),
        /// such as "kghy_0101"
        /// </summary>
        [JsonProperty("TradeTwo")]
        public string TradeTwo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ConfirmPassword", this.ConfirmPassword);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "VerifyCode", this.VerifyCode);
            this.SetParamSimple(map, prefix + "Extended", this.Extended);
            this.SetParamSimple(map, prefix + "TradeOne", this.TradeOne);
            this.SetParamSimple(map, prefix + "TradeTwo", this.TradeTwo);
        }
    }
}

