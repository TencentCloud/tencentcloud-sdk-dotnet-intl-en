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

    public class UserApplicationInfo : AbstractModel
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
        /// Application type (cloud 3D: Application3D; cloud XR: ApplicationXR; cloud Web: ApplicationWeb).
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// Application program execution path.
        /// </summary>
        [JsonProperty("ApplicationExePath")]
        public string ApplicationExePath{ get; set; }

        /// <summary>
        /// Application process list.
        /// </summary>
        [JsonProperty("ApplicationInterList")]
        public string ApplicationInterList{ get; set; }

        /// <summary>
        /// Application startup parameters.
        /// </summary>
        [JsonProperty("ApplicationParams")]
        public string ApplicationParams{ get; set; }

        /// <summary>
        /// Application running status (ApplicationDeleting: application deletion in progress; ApplicationCreateFail: application creation failed; ApplicationCreating: application creation in progress; ApplicationRunning: normal running; ApplicationNoConfigured: main execution program path not configured).
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
        /// Application basic data.
        /// </summary>
        [JsonProperty("ApplicationBaseInfo")]
        public ApplicationBaseInfo ApplicationBaseInfo{ get; set; }

        /// <summary>
        /// Application update progress.
        /// </summary>
        [JsonProperty("ApplicationUpdateProgress")]
        public long? ApplicationUpdateProgress{ get; set; }

        /// <summary>
        /// Application nature (PUBLIC: public application; PRIVATE: user application).
        /// </summary>
        [JsonProperty("ApplicationNature")]
        public string ApplicationNature{ get; set; }

        /// <summary>
        /// Application repository list.
        /// </summary>
        [JsonProperty("ApplicationStores")]
        public UserApplicationStore[] ApplicationStores{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "ApplicationExePath", this.ApplicationExePath);
            this.SetParamSimple(map, prefix + "ApplicationInterList", this.ApplicationInterList);
            this.SetParamSimple(map, prefix + "ApplicationParams", this.ApplicationParams);
            this.SetParamSimple(map, prefix + "ApplicationRunStatus", this.ApplicationRunStatus);
            this.SetParamSimple(map, prefix + "ApplicationUpdateStatus", this.ApplicationUpdateStatus);
            this.SetParamSimple(map, prefix + "ApplicationCreateTime", this.ApplicationCreateTime);
            this.SetParamArrayObj(map, prefix + "ApplicationVersions.", this.ApplicationVersions);
            this.SetParamObj(map, prefix + "ApplicationBaseInfo.", this.ApplicationBaseInfo);
            this.SetParamSimple(map, prefix + "ApplicationUpdateProgress", this.ApplicationUpdateProgress);
            this.SetParamSimple(map, prefix + "ApplicationNature", this.ApplicationNature);
            this.SetParamArrayObj(map, prefix + "ApplicationStores.", this.ApplicationStores);
        }
    }
}

