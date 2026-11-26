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
        /// <p>Application Id</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>Application name</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>App type (Cloud APK: ApplicationAPK)</p>
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// <p>Application running status (ApplicationRunning: normal running; ApplicationNoPackage: no available package)</p>
        /// </summary>
        [JsonProperty("ApplicationRunStatus")]
        public string ApplicationRunStatus{ get; set; }

        /// <summary>
        /// <p>Application update status (ApplicationUpdateCreating: version creation in progress; ApplicationUpdateCreateFail: version creation failed; ApplicationUpdateNoReleased: version to be released; ApplicationUpdateReleased: version release completed; ApplicationUpdateNormal: none)</p>
        /// </summary>
        [JsonProperty("ApplicationUpdateStatus")]
        public string ApplicationUpdateStatus{ get; set; }

        /// <summary>
        /// <p>Application creation time</p>
        /// </summary>
        [JsonProperty("ApplicationCreateTime")]
        public string ApplicationCreateTime{ get; set; }

        /// <summary>
        /// <p>Application version list</p>
        /// </summary>
        [JsonProperty("ApplicationVersions")]
        public UserApplicationVersion[] ApplicationVersions{ get; set; }

        /// <summary>
        /// <p>Application nature (PUBLIC: public application; PRIVATE: user application)</p>
        /// </summary>
        [JsonProperty("ApplicationNature")]
        public string ApplicationNature{ get; set; }

        /// <summary>
        /// <p>Application tag</p>
        /// </summary>
        [JsonProperty("ApplicationTags")]
        public Tag[] ApplicationTags{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "ApplicationTags.", this.ApplicationTags);
        }
    }
}

