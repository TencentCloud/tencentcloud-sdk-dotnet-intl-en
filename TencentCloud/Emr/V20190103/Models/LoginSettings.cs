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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginSettings : AbstractModel
    {
        
        /// <summary>
        /// Instance login password, with 8 to 16 characters, including uppercase letters, lowercase letters, digits, and special characters. Special characters only support !@%^*. The password cannot start with a special character.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Key ID. After a key is associated, the instance can be accessed with the corresponding private key; PublicKeyId can be obtained through the API [DescribeKeyPairs](https://www.tencentcloud.com/document/api/213/15699?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("PublicKeyId")]
        public string PublicKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PublicKeyId", this.PublicKeyId);
        }
    }
}

