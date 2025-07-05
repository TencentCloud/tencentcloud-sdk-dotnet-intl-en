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

namespace TencentCloud.Tcmpp.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationSimpleInfoResp : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationID")]
        public string ApplicationID{ get; set; }

        /// <summary>
        /// Product ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppIdentityID")]
        public long? AppIdentityID{ get; set; }

        /// <summary>
        /// The application name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationID", this.ApplicationID);
            this.SetParamSimple(map, prefix + "AppIdentityID", this.AppIdentityID);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
        }
    }
}

