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

    public class UserApplicationVersion : AbstractModel
    {
        
        /// <summary>
        /// <p>Application version Id</p>
        /// </summary>
        [JsonProperty("ApplicationVersionId")]
        public string ApplicationVersionId{ get; set; }

        /// <summary>
        /// <p>Application version size</p>
        /// </summary>
        [JsonProperty("ApplicationVersionSize")]
        public long? ApplicationVersionSize{ get; set; }

        /// <summary>
        /// <p>Application version status (Uploading: Creating, Creating: Creating, CreateFailed: Failed to create, Deleting: Deleting, Inuse: Current version, Normal: To be released, Usable: Available)</p>
        /// </summary>
        [JsonProperty("ApplicationVersionStatus")]
        public string ApplicationVersionStatus{ get; set; }

        /// <summary>
        /// <p>Application version name</p>
        /// </summary>
        [JsonProperty("ApplicationVersionName")]
        public string ApplicationVersionName{ get; set; }

        /// <summary>
        /// <p>Application version creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Application version distribution regions (<br>Standard regions:<br>ap-chinese-mainland: Chinese mainland,<br>na-north-america: North America,<br>eu-frankfurt: Frankfurt,<br>ap-mumbai: Mumbai,<br>ap-tokyo: Tokyo,<br>ap-seoul: Seoul,<br>ap-singapore: Singapore,<br>ap-bangkok: Bangkok,<br>ap-hongkong: Hong Kong (China),<br>Fusion regions:<br>me-middle-east-fusion: Middle East<br>na-north-america-fusion: North America<br>sa-south-america-fusion: South America<br>ap-tokyo-fusion: Tokyo<br>ap-seoul-fusion: Seoul<br>eu-frankfurt-fusion: Frankfurt<br>ap-singapore-fusion: Singapore<br>ap-hongkong-fusion: Hong Kong (China)<br>)</p>
        /// </summary>
        [JsonProperty("ApplicationVersionRegions")]
        public string[] ApplicationVersionRegions{ get; set; }

        /// <summary>
        /// <p>Application version update mode: <br>FULL: Full update, <br>INCREMENT: Incremental update</p>
        /// </summary>
        [JsonProperty("ApplicationVersionUpdateMode")]
        public string ApplicationVersionUpdateMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationVersionId", this.ApplicationVersionId);
            this.SetParamSimple(map, prefix + "ApplicationVersionSize", this.ApplicationVersionSize);
            this.SetParamSimple(map, prefix + "ApplicationVersionStatus", this.ApplicationVersionStatus);
            this.SetParamSimple(map, prefix + "ApplicationVersionName", this.ApplicationVersionName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "ApplicationVersionRegions.", this.ApplicationVersionRegions);
            this.SetParamSimple(map, prefix + "ApplicationVersionUpdateMode", this.ApplicationVersionUpdateMode);
        }
    }
}

