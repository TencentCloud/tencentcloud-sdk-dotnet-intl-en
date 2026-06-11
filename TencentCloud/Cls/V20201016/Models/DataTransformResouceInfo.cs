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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataTransformResouceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Log topic ID</p><ul><li>Get the log topic ID by <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">getting the log topic list</a>.</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Alias<br>Limitation: Cannot contain character |.</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>Whether it is a cross-account topic. false means it is not a cross-account topic, and true means it is a cross-account topic.</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("IsCrossAccount")]
        public bool? IsCrossAccount{ get; set; }

        /// <summary>
        /// <p>In a cross-account scenario, search for the role ARN value created by the delivery account for the shipping account in the roles of the shipping account.</p>
        /// </summary>
        [JsonProperty("RoleARN")]
        public string RoleARN{ get; set; }

        /// <summary>
        /// <p>External ID value. Can be found in the role-carrier of the shipping account.</p>
        /// </summary>
        [JsonProperty("ExternalId")]
        public string ExternalId{ get; set; }

        /// <summary>
        /// <p>topic name</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>Logset name</p>
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "IsCrossAccount", this.IsCrossAccount);
            this.SetParamSimple(map, prefix + "RoleARN", this.RoleARN);
            this.SetParamSimple(map, prefix + "ExternalId", this.ExternalId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
        }
    }
}

