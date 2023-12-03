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
        /// <li>production: Production environment.</li><li> staging: Test environment. </li>
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// Environment status. Valid values: 
        /// <li>creating: Being created.</li>
        /// <li>running: The environment is stable, with version changes allowed.</li>
        /// <li>version_deploying: The version is currently being deployed, with no more changes allowed. </li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Effective scope of the configuration in the current environment. Valid values: 
        /// <li>ALL: It takes effect on the entire network when EnvType is set to production.</li>
        /// <li>It returns the IP address of the test node for host binding during testing when EnvType is set to staging. </li>
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// For the effective versions of each configuration group in the current environment, there are two possible scenarios based on the value of Status: 
        /// <li>When Status is set to version_deploying, the returned value of this field represents the previously effective version. In other words, during the deployment of the new version, the effective version is the one that was in effect before any changes were made.</li>
        /// <li>When Status is set to running, the value returned by this field is the currently effective version. </li>
        /// </summary>
        [JsonProperty("CurrentConfigGroupVersionInfos")]
        public ConfigGroupVersionInfo[] CurrentConfigGroupVersionInfos{ get; set; }

        /// <summary>
        /// Creation time. The time format follows the ISO 8601 standard and is represented in Coordinated Universal Time (UTC).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time. The time format follows the ISO 8601 standard and is represented in Coordinated Universal Time (UTC).
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

