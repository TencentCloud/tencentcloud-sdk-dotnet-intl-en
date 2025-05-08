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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRabbitMQServerlessPermissionRequest : AbstractModel
    {
        
        /// <summary>
        /// instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the username, which is the user associated with the permission.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Specifies the vhost name.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Types of permissions. declare related operations. for the user, it is operable to perform operations on the resource name under the vhost that matches the regular expression.
        /// </summary>
        [JsonProperty("ConfigRegexp")]
        public string ConfigRegexp{ get; set; }

        /// <summary>
        /// Types of permissions. message write related operations. the user can operate on the resource names under the vhost that match the regular expression.
        /// </summary>
        [JsonProperty("WriteRegexp")]
        public string WriteRegexp{ get; set; }

        /// <summary>
        /// Types of permissions. message read related operations. the user can operate on the resource name under the vhost that matches the regular expression.
        /// </summary>
        [JsonProperty("ReadRegexp")]
        public string ReadRegexp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ConfigRegexp", this.ConfigRegexp);
            this.SetParamSimple(map, prefix + "WriteRegexp", this.WriteRegexp);
            this.SetParamSimple(map, prefix + "ReadRegexp", this.ReadRegexp);
        }
    }
}

