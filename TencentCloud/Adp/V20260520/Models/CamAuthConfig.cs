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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CamAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Role name.</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// <p>Key location HEADER/QUERY</p><p>Enumeration values:<br>| uint | Description |<br>| --- | --- |<br>| 0 | Header authentication |<br>| 1 | Request information authentication |</p>
        /// </summary>
        [JsonProperty("KeyLocation")]
        public long? KeyLocation{ get; set; }

        /// <summary>
        /// <p>SecretId field name</p>
        /// </summary>
        [JsonProperty("SecretIdName")]
        public string SecretIdName{ get; set; }

        /// <summary>
        /// <p>SecretKey field name</p>
        /// </summary>
        [JsonProperty("SecretKeyName")]
        public string SecretKeyName{ get; set; }

        /// <summary>
        /// <p>CAM Access Key Field Configuration</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public AccessKeyParamConfig[] ParamList{ get; set; }

        /// <summary>
        /// <p>Whether CAM role authorization is supported.</p>
        /// </summary>
        [JsonProperty("SupportRoleAuth")]
        public bool? SupportRoleAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "KeyLocation", this.KeyLocation);
            this.SetParamSimple(map, prefix + "SecretIdName", this.SecretIdName);
            this.SetParamSimple(map, prefix + "SecretKeyName", this.SecretKeyName);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "SupportRoleAuth", this.SupportRoleAuth);
        }
    }
}

