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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvInfo : AbstractModel
    {
        
        /// <summary>
        /// Environment ID.
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// Environment type. Valid values:
        /// <li>production: production environment;</li><li>staging: testing environment.</li>
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// Environment status. Valid values:
        /// <li>creating: under creation;</li>
        /// <li>running: running steadily. Version change can be performed;</li>
        /// <li>version_deploying: Version deployment in progress, cannot proceed with new changes.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Configuration effective range in the current environment:
        /// <li>When the value of EnvType is production, the value of this parameter is ["ALL"], which means it takes effect globally;</li>
        /// <li>When the value of EnvType is staging, the test node IP will be returned, which can be used to bind a host for testing.</li>
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// Versions that actually take effect for each configuration group in the current environment. According to the value of Status, there are the following two scenarios:
        /// <li>When the value of Status is version_deploying, the value returned by this field is the version effective before the change action is executed. That is, during the new version deployment, the version actually effective is the version prior to the execution of the change action;</li>
        /// <li>When the value of Status is running, the returned value of this field is the currently effective version.</li>
        /// </summary>
        [JsonProperty("CurrentConfigGroupVersionInfos")]
        public ConfigGroupVersionInfo[] CurrentConfigGroupVersionInfos{ get; set; }

        /// <summary>
        /// Creation time, which adopts Coordinated Universal Time (UTC) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time, which adopts Coordinated Universal Time (UTC) and follows the date and time format of the ISO 8601 standard.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamArrayObj(map, prefix + "CurrentConfigGroupVersionInfos.", this.CurrentConfigGroupVersionInfos);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

