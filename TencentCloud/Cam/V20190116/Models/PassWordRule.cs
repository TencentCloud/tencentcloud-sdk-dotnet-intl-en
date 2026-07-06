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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PassWordRule : AbstractModel
    {
        
        /// <summary>
        /// Minimum length required for the password.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinimumLength")]
        public long? MinimumLength{ get; set; }

        /// <summary>
        /// Types of characters the password must contain. 
        /// A: Must contain uppercase letter
        /// a: Must contain lowercase letter
        /// 1: Must contain number
        /// !: Must contain special character
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MustContain")]
        public string MustContain{ get; set; }

        /// <summary>
        /// Password validity period in days, after which the password must be reset. 0 (no expiration)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForcePasswordChange")]
        public long? ForcePasswordChange{ get; set; }

        /// <summary>
        /// Number of previous passwords that cannot be reused. 
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReusePasswordLimit")]
        public long? ReusePasswordLimit{ get; set; }

        /// <summary>
        /// Maximum number of failed login attempts allowed within a one hour window.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetryPasswordLimit")]
        public long? RetryPasswordLimit{ get; set; }

        /// <summary>
        /// Indicates whether a user can reset their own password after it has expired. 
        /// 1: Yes, 2: No (Yes: After password expiration, sub-users are unable to log in and require administrator reset. No: After password expiration, sub-users can log in and are forced to change password based on old password.)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PasswordExpirationInvalidation")]
        public long? PasswordExpirationInvalidation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinimumLength", this.MinimumLength);
            this.SetParamSimple(map, prefix + "MustContain", this.MustContain);
            this.SetParamSimple(map, prefix + "ForcePasswordChange", this.ForcePasswordChange);
            this.SetParamSimple(map, prefix + "ReusePasswordLimit", this.ReusePasswordLimit);
            this.SetParamSimple(map, prefix + "RetryPasswordLimit", this.RetryPasswordLimit);
            this.SetParamSimple(map, prefix + "PasswordExpirationInvalidation", this.PasswordExpirationInvalidation);
        }
    }
}

