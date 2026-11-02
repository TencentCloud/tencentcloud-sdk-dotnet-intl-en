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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceUserRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Username.</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Password</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Encrypted password (choose either this or Password)</p>
        /// </summary>
        [JsonProperty("EncryptedPassword")]
        public string EncryptedPassword{ get; set; }

        /// <summary>
        /// <p>Authentication database (Belonging Database of the user).</p>
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// <p>Get role list (new method, can include built-in role and custom role)</p>
        /// </summary>
        [JsonProperty("Roles")]
        public Role[] Roles{ get; set; }

        /// <summary>
        /// <p>Permission list (old method)</p>
        /// </summary>
        [JsonProperty("AuthRole")]
        public Auth[] AuthRole{ get; set; }

        /// <summary>
        /// <p>Custom description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Whether password rotation is enabled (0: not enabled, 1: enabled)</p>
        /// </summary>
        [JsonProperty("EnablePasswordRotation")]
        public long? EnablePasswordRotation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "EncryptedPassword", this.EncryptedPassword);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamArrayObj(map, prefix + "AuthRole.", this.AuthRole);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnablePasswordRotation", this.EnablePasswordRotation);
        }
    }
}

