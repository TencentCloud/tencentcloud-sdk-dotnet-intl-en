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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginSettings : AbstractModel
    {
        
        /// <summary>
        /// Instance login password. The password complexity requirements vary according to the operating system type. The details are as follows:
        /// - For a Linux system, the password should contain 8 to 30 characters consisting of at least two of the four character types: lowercase letters, uppercase letters, digits, and special characters.
        /// - For a Windows system, the password should contain 12 to 30 characters consisting of at least three of the four character types: lowercase letters, uppercase letters, digits, and special characters.
        /// - If this parameter is not specified, the system will generate a random password and notify the user via the message centerSupported special characters: ( ) ` ~ ! @ # $ % ^ & * - + = | { } [ ] : ; ' , . ? /
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// List of key IDs. After an instance is associated with a key, you can access the instance with the private key in the key pair. You can call `DescribeKeyPairs` to obtain `KeyId`. Key and password cannot be specified at the same time. Windows instances do not support keys. Currently, you can only specify one key when purchasing an instance.
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// Retain the original settings of the image. This parameter cannot be specified simultaneously with Password or KeyIds.N. It can only be set to TRUE when you create an instance by using a custom image, shared image, or externally imported image. Valid values:
        /// <li>TRUE: Retain the login settings of the image.</li>
        /// <li>FALSE: Do not retain the login settings of the image.</li> Default value: FALSE.
        /// </summary>
        [JsonProperty("KeepImageLogin")]
        public bool? KeepImageLogin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamSimple(map, prefix + "KeepImageLogin", this.KeepImageLogin);
        }
    }
}

