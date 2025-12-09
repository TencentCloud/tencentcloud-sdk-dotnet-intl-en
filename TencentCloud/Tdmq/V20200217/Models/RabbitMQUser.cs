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

    public class RabbitMQUser : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, such as amqp-xxxxxxxx. effective InstanceId can be queried by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Username, which is used for login.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Password, which is used for login.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// User description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// User tags, which determine the scope of permissions of this user to access RabbitMQ Management.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// User creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last user modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// User type. Valid values: `System` (Created by system), `User` (Created by user).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Maximum number of available connections per user.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxConnections")]
        public long? MaxConnections{ get; set; }

        /// <summary>
        /// Maximum number of available channels per user.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxChannels")]
        public long? MaxChannels{ get; set; }

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// Modification timestamp.
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MaxConnections", this.MaxConnections);
            this.SetParamSimple(map, prefix + "MaxChannels", this.MaxChannels);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}

