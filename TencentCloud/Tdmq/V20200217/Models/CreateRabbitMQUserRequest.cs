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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQUserRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID, such as amqp-xxxxxxxx. Effective InstanceId can be obtained by logging in to the <a href="https://console.cloud.tencent.com/trabbitmq/cluster?rid=1">TDMQ RabbitMQ Console</a> for querying.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Username, used when logging in</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>Password, used when logging in. Requirements: Cannot be empty, 8-64 characters, must contain at least two of the following: lowercase letter, uppercase letter, digit, special character [()`~!@#$%^&*_=|{}[]:;',.?/].</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>User tag, used to determine the access permission of the user to RabbitMQ Management<br>management: ordinary console user, monitoring: console user with management privileges, other value: non-console user</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>Maximum number of connections for this user. Leave it blank to set as unlimited.</p>
        /// </summary>
        [JsonProperty("MaxConnections")]
        public long? MaxConnections{ get; set; }

        /// <summary>
        /// <p>Maximum number of channels for the user. Not specified means no limit.</p>
        /// </summary>
        [JsonProperty("MaxChannels")]
        public long? MaxChannels{ get; set; }

        /// <summary>
        /// <p>Whether cam authentication is enabled</p>
        /// </summary>
        [JsonProperty("EnableCamAuth")]
        public bool? EnableCamAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "MaxConnections", this.MaxConnections);
            this.SetParamSimple(map, prefix + "MaxChannels", this.MaxChannels);
            this.SetParamSimple(map, prefix + "EnableCamAuth", this.EnableCamAuth);
        }
    }
}

