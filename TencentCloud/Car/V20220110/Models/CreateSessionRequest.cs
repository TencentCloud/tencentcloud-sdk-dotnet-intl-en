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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// The user’s unique ID. Tencent Cloud does not parse the ID. You need to manage your own user IDs. Based on your needs, you can either define unique IDs for users or use timestamps to generate random IDs. Make sure the same ID is used when a user reconnects to your application.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Public IP of user’s application client, which is used for nearby scheduling.
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// The client-side session data, which is obtained from the SDK. If `RunMode` is `RunWithoutClient`, this parameter can be null.
        /// </summary>
        [JsonProperty("ClientSession")]
        public string ClientSession{ get; set; }

        /// <summary>
        /// The on-cloud running mode.
        /// `RunWithoutClient`: Keep the application running on the cloud even when there are no client connections.
        /// Empty string (default): Keep the application running on the cloud only when there are client connections.
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// Application startup parameter.
        /// If the user requests a multi-application project or a prelaunch-disabled single-application project, this parameter takes effect.
        ///  
        /// If the user requests a prelaunch-enabled single-application project, this parameter is invalid.
        /// 
        /// Note: When this parameter takes effect, the `ApplicationParameters` parameter will be appended to the end of the application startup parameter. The application startup parameter is set in the application or project configuration in the console.
        /// For example, for a prelaunch-disabled single-application project, if its application startup parameter `bar` is `0` and the `ApplicationParameters` parameter `foo` is `1`, the actual application startup parameters will be `bar=0 foo=1`.
        /// </summary>
        [JsonProperty("ApplicationParameters")]
        public string ApplicationParameters{ get; set; }

        /// <summary>
        /// The user ID of the host in **multi-person interaction** scenarios, which is required.
        /// If the current user is the host, `HostUserId` must be the same as their `UserId`; otherwise, `HostUserId` should be the host's `UserId`.
        /// </summary>
        [JsonProperty("HostUserId")]
        public string HostUserId{ get; set; }

        /// <summary>
        /// The role in **multi-person interaction** scenarios. Valid values:
        /// `Player`: A user who can operate an application by using a keyboard and mouse
        /// `Viewer`: A user who can only watch the video in the room but cannot operate the application
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "ClientSession", this.ClientSession);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ApplicationParameters", this.ApplicationParameters);
            this.SetParamSimple(map, prefix + "HostUserId", this.HostUserId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
        }
    }
}

