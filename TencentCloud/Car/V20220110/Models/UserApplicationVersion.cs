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
        /// Application version ID.
        /// </summary>
        [JsonProperty("ApplicationVersionId")]
        public string ApplicationVersionId{ get; set; }

        /// <summary>
        /// Application version size.
        /// </summary>
        [JsonProperty("ApplicationVersionSize")]
        public long? ApplicationVersionSize{ get; set; }

        /// <summary>
        /// Application version status (Uploading: uploading; Creating: in creation; CreateFailed: creation failed; Deleting: deleting; Inuse: current version; Normal: to be released; Usable: available).
        /// </summary>
        [JsonProperty("ApplicationVersionStatus")]
        public string ApplicationVersionStatus{ get; set; }

        /// <summary>
        /// Application version name.
        /// </summary>
        [JsonProperty("ApplicationVersionName")]
        public string ApplicationVersionName{ get; set; }

        /// <summary>
        /// Application version creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Region for application version distribution (
        /// Standard zone:
        /// ap-chinese-mainland: Chinese mainland
        /// na-north-america: North America
        /// eu-frankfurt: Frankfurt
        /// ap-mumbai: Mumbai
        /// ap-tokyo: Tokyo
        /// ap-seoul: Seoul
        /// ap-singapore: Singapore
        /// ap-bangkok: Bangkok
        /// ap-hongkong: Hong Kong (China)
        /// Integration zone:
        /// me-middle-east-fusion: Middle East
        /// na-north-america-fusion: North America
        /// sa-south-america-fusion: South America
        /// ap-tokyo-fusion: Tokyo
        /// ap-seoul-fusion: Seoul
        /// eu-frankfurt-fusion: Frankfurt
        /// ap-singapore-fusion: Singapore
        /// ap-hongkong-fusion: Hong Kong (China)
        /// ).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationVersionRegions")]
        public string[] ApplicationVersionRegions{ get; set; }

        /// <summary>
        /// Application version update method.
        /// FULL: full update.
        /// INCREMENT: incremental update.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

