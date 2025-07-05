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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <li>`YES`: Random password. In this case, `Password` cannot be specified. </li>
        /// <li>`No`: Custom. `Password` must be specified. </li>
        /// </summary>
        [JsonProperty("AutoGeneratePassword")]
        public string AutoGeneratePassword{ get; set; }

        /// <summary>
        /// Instance login password. 
        /// For Windows instances, the password must contain 12 to 30 characters of the following types. It cannot start with “/” and cannot include the username. 
        /// <li>Lowercase letters: [a–z]</li>
        /// <li>Uppercase letters: [A–Z]</li>
        /// <li>Digits: 0-9</li>
        /// <li>Symbols: ()`~!@#$%^&*-+=_|{}[]:;'<>,.?/</li>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoGeneratePassword", this.AutoGeneratePassword);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
        }
    }
}

