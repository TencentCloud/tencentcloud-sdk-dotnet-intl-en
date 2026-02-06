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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Application introduction
        /// </summary>
        [JsonProperty("Intro")]
        public string Intro{ get; set; }

        /// <summary>
        /// Icon
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// Platform ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Android app package name
        /// </summary>
        [JsonProperty("AndroidAppKey")]
        [System.Obsolete]
        public string AndroidAppKey{ get; set; }

        /// <summary>
        /// iOS App bundleId
        /// </summary>
        [JsonProperty("IosAppKey")]
        [System.Obsolete]
        public string IosAppKey{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        [System.Obsolete]
        public string Remark{ get; set; }

        /// <summary>
        /// Scheme
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "Intro", this.Intro);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "AndroidAppKey", this.AndroidAppKey);
            this.SetParamSimple(map, prefix + "IosAppKey", this.IosAppKey);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
        }
    }
}

