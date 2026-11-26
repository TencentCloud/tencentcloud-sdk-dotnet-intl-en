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

    public class AuthenticationParameters : AbstractModel
    {
        
        /// <summary>
        /// Authentication type. Valid values:
        /// 
        /// <li>TypeA: authentication method type A. For its specific meaning, refer to [Authentication Method A](https://www.tencentcloud.com/document/product/1552/109329?from_cn_redirect=1);</li>
        /// <li>TypeB: authentication method B type. For its specific meaning, refer to [Authentication Method B](https://www.tencentcloud.com/document/product/1552/109330?from_cn_redirect=1);</li>
        /// <li>TypeC: authentication method C type. For its specific meaning, refer to [Authentication Method C](https://www.tencentcloud.com/document/product/1552/109331?from_cn_redirect=1);</li>
        /// <li>TypeD: authentication method D type. For its specific meaning, refer to [Authentication Method D](https://www.tencentcloud.com/document/product/1552/109332?from_cn_redirect=1);</li>
        /// <li>TypeVOD: authentication method V type. For its specific meaning, refer to [Authentication Method V](https://www.tencentcloud.com/document/product/1552/109333?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// Primary authentication key. It contains 6–40 uppercase/lowercase letters or digits and cannot contain " or $.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Valid duration of the authentication URL, in seconds. Value range: 1–630720000. It is used to determine whether the client access request is expired:
        /// <li>If the current time exceeds the "timestamp + valid duration" time, the request is expired and 403 is returned directly.</li>
        /// <li>If the current time has not exceeded the "timestamp + valid duration" time, the request is not expired. Proceed to validate the md5 string.</li>Note: This field is required when AuthType is one of TypeA, TypeB, TypeC, or TypeD.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Backup authentication key. It contains 6–40 uppercase/lowercase letters or digits and cannot contain " or $.
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }

        /// <summary>
        /// Authentication parameter name. The node will validate the value corresponding to this parameter name. It consists of 1–100 upper- and lower-case letters, digits, or underscores.<br>Note: This field is required when AuthType is one of TypeA and TypeD.
        /// </summary>
        [JsonProperty("AuthParam")]
        public string AuthParam{ get; set; }

        /// <summary>
        /// Authentication timestamp. It cannot be the same as the AuthParam field value.<br>Note: This field is required when AuthType is TypeD.
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// Authentication time format. Valid values:
        /// <li>dec: decimal;</li>
        /// <li>hex: hexadecimal.</li>Note: This field is required when AuthType is TypeD. Default value: hex.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
            this.SetParamSimple(map, prefix + "AuthParam", this.AuthParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

