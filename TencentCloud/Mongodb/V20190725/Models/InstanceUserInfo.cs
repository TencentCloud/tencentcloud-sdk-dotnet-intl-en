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

    public class InstanceUserInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Username.</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Authentication database</p>
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// <p>Get role list (new method)</p>
        /// </summary>
        [JsonProperty("Roles")]
        public Role[] Roles{ get; set; }

        /// <summary>
        /// <p>Permission list (old method)</p>
        /// </summary>
        [JsonProperty("AuthRole")]
        public Auth[] AuthRole{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Console password last update time</p>
        /// </summary>
        [JsonProperty("ConsolePassUpdateTime")]
        public string ConsolePassUpdateTime{ get; set; }

        /// <summary>
        /// <p>Whether to enable password rotation</p>
        /// </summary>
        [JsonProperty("EnablePasswordRotation")]
        public long? EnablePasswordRotation{ get; set; }

        /// <summary>
        /// <p>Custom description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamArrayObj(map, prefix + "AuthRole.", this.AuthRole);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ConsolePassUpdateTime", this.ConsolePassUpdateTime);
            this.SetParamSimple(map, prefix + "EnablePasswordRotation", this.EnablePasswordRotation);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

