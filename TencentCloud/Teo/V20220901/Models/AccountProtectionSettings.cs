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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountProtectionSettings : AbstractModel
    {
        
        /// <summary>
        /// <p>Account protection feature switch.</p><p>Enumeration values: </p><ul><li>on: Enable;</li><li>off: Disable.</li></ul><p>Default value: off.</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// <p>Request target. Used to identify the business operation scenario the request belongs to.</p> <p>Enumeration values:</p> <ul> <li>ACCOUNT.CHANGE_PASSWORD: request to change the password when the original password is known;</li> <li>ACCOUNT.CHANGE_SECURITY_QUESTION: request to modify the account security question;</li> <li>ACCOUNT.CHECK_EXISTENCE: request to verify whether the account exists, commonly used for pre-verification after entering an email or phone number on the login or registration page;</li> <li>ACCOUNT.LOGIN: request to log in to an account;</li> <li>ACCOUNT.REGISTER: request to sign up for a new account;</li> <li>ACCOUNT.RESET_PASSWORD: request to reset the password, usually by verifying identity through email or SMS and then setting a new password;</li> <li>ACCOUNT.UPDATE: request to modify account association information, such as phone number, email, payment card number, shipping address, etc.;</li> <li>ASSET.CHECK_GIFTCARD_BALANCE: request to query the gift card balance by card number and other information;</li> <li>ASSET.CHECK_LOYALTY_POINTS: request to query the account point balance;</li> <li>ASSET.REDEEM_CODE: request to exchange rights and interests using a redemption code;</li> <li>BROWSE.QUERY: request for in-site search of products or services;</li> <li>PAYMENT.ADD_TO_CART: request to add merchandise to the shopping cart;</li> <li>PAYMENT.GET_METHODS: request to obtain the list of payment methods bound to the account;</li> <li>PAYMENT.MAKE_PAYMENT: request to submit a payment, settlement, or fund transfer.</li> </ul>
        /// </summary>
        [JsonProperty("RequestPurpose")]
        public string RequestPurpose{ get; set; }

        /// <summary>
        /// <p>The location of the user identity in the request source, where key is replaced with the actual parameter name.</p><p>Valid values:</p><ul><li>http.request.cookies["key"]: Obtain the Cookie value named key from the Cookie;</li><li>http.request.headers["key"]: Obtain the header value named key from the request header;</li><li>http.request.uri.args["key"]: Obtain the parameter value named key from the URL query parameter.</li></ul>
        /// </summary>
        [JsonProperty("UserIDSource")]
        public string UserIDSource{ get; set; }

        /// <summary>
        /// <p>User Risk Level configuration.</p>
        /// </summary>
        [JsonProperty("UserRiskProfile")]
        public UserRiskProfile UserRiskProfile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RequestPurpose", this.RequestPurpose);
            this.SetParamSimple(map, prefix + "UserIDSource", this.UserIDSource);
            this.SetParamObj(map, prefix + "UserRiskProfile.", this.UserRiskProfile);
        }
    }
}

