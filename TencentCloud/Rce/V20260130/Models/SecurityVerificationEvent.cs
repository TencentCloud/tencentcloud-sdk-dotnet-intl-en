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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityVerificationEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The event type being verified</p><p>Enumeration values:</p><ul><li>register</li><li>login</li><li>modify_account</li><li>modify_password</li><li>create_order</li><li>transaction</li><li>modify_order</li><li>withdraw</li><li>add_promotion</li><li>redeem</li></ul>
        /// </summary>
        [JsonProperty("VerificationEvent")]
        public string VerificationEvent{ get; set; }

        /// <summary>
        /// <p>The type of security verification: sms, phone call, email, captcha, shared knowledge, human face, fingerprint, etc</p>
        /// </summary>
        [JsonProperty("VerificationType")]
        public string VerificationType{ get; set; }

        /// <summary>
        /// <p>The content of the security verifcation.This value should be passed when the verification type is set to sms, phone_call, email captcha or shared_knowledge</p>
        /// </summary>
        [JsonProperty("VerificationContent")]
        public string VerificationContent{ get; set; }

        /// <summary>
        /// <p>The result of security verification</p>
        /// </summary>
        [JsonProperty("VerificationResult")]
        public Result VerificationResult{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerificationEvent", this.VerificationEvent);
            this.SetParamSimple(map, prefix + "VerificationType", this.VerificationType);
            this.SetParamSimple(map, prefix + "VerificationContent", this.VerificationContent);
            this.SetParamObj(map, prefix + "VerificationResult.", this.VerificationResult);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

