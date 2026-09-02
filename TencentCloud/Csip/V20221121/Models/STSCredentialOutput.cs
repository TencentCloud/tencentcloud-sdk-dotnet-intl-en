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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class STSCredentialOutput : AbstractModel
    {
        
        /// <summary>
        /// Credential provider identifier (original), for example tencentCam, aws, aliyun
        /// </summary>
        [JsonProperty("System")]
        public string System{ get; set; }

        /// <summary>
        /// SecretID (masked)
        /// Supplemental description: Reserve the first 3 and last 4 digits, replace the middle with ***. If the length is less than 7, use *** as a complete replacement.
        /// </summary>
        [JsonProperty("SecretID")]
        public string SecretID{ get; set; }

        /// <summary>
        /// SecretKey (masked)
        /// Supplemental description: Reserve the first 3 and last 4 digits, replace the middle with ***. If the length is less than 7, use *** as a complete replacement.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "System", this.System);
            this.SetParamSimple(map, prefix + "SecretID", this.SecretID);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
        }
    }
}

