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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserMobileApplicationInfo : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Application type (cloud APK: application APK).
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// Application running status (ApplicationRunning: normal running; ApplicationNoPackage: no available package).
        /// </summary>
        [JsonProperty("ApplicationRunStatus")]
        public string ApplicationRunStatus{ get; set; }

        /// <summary>
        /// Application update status (ApplicationUpdateCreating: version creation in progress; ApplicationUpdateCreateFail: version creation failed; ApplicationUpdateNoReleased: version to be released; ApplicationUpdateReleased: version release completed; ApplicationUpdateNormal: none).
        /// </summary>
        [JsonProperty("ApplicationUpdateStatus")]
        public string ApplicationUpdateStatus{ get; set; }

        /// <summary>
        /// Application creation time.
        /// </summary>
        [JsonProperty("ApplicationCreateTime")]
        public string ApplicationCreateTime{ get; set; }

        /// <summary>
        /// List of application versions.
        /// </summary>
        [JsonProperty("ApplicationVersions")]
        public UserApplicationVersion[] ApplicationVersions{ get; set; }

        /// <summary>
        /// Application nature (PUBLIC: public application; PRIVATE: user application).
        /// </summary>
        [JsonProperty("ApplicationNature")]
        public string ApplicationNature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "ApplicationRunStatus", this.ApplicationRunStatus);
            this.SetParamSimple(map, prefix + "ApplicationUpdateStatus", this.ApplicationUpdateStatus);
            this.SetParamSimple(map, prefix + "ApplicationCreateTime", this.ApplicationCreateTime);
            this.SetParamArrayObj(map, prefix + "ApplicationVersions.", this.ApplicationVersions);
            this.SetParamSimple(map, prefix + "ApplicationNature", this.ApplicationNature);
        }
    }
}

