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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstancePasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID. Example: crs-xjhsdj****. Log in to the [TencentDB for Redis console](https://console.cloud.tencent.com/redis) and copy the instance ID in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Old password of the instance.
        /// </summary>
        [JsonProperty("OldPassword")]
        public string OldPassword{ get; set; }

        /// <summary>
        /// New password of the instance. The password complexity requirements are as follows:
        /// - It can contain 8 to 30 characters. It is recommended to use a password of more than 12 characters.
        /// - It cannot start with a forward slash (/).
        /// - It should contain at least two of the following types: lowercase letters, uppercase letters, digits, and special characters (such as ()~!@#$%^&*-+=_|{}[]:;<>,.?/).
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldPassword", this.OldPassword);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

