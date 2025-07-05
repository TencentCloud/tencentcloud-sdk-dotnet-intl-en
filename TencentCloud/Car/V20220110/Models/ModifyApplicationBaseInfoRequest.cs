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

    public class ModifyApplicationBaseInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

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
        /// Application basic data.
        /// </summary>
        [JsonProperty("ApplicationBaseInfo")]
        public ApplicationBaseInfo ApplicationBaseInfo{ get; set; }

        /// <summary>
        /// Application startup parameters.
        /// </summary>
        [JsonProperty("ApplicationParams")]
        public string ApplicationParams{ get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Application repository information list.
        /// </summary>
        [JsonProperty("ApplicationStores")]
        public UserApplicationStore[] ApplicationStores{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationExePath", this.ApplicationExePath);
            this.SetParamSimple(map, prefix + "ApplicationInterList", this.ApplicationInterList);
            this.SetParamObj(map, prefix + "ApplicationBaseInfo.", this.ApplicationBaseInfo);
            this.SetParamSimple(map, prefix + "ApplicationParams", this.ApplicationParams);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamArrayObj(map, prefix + "ApplicationStores.", this.ApplicationStores);
        }
    }
}

