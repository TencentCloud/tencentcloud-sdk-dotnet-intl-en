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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticationTypeA : AbstractModel
    {
        
        /// <summary>
        /// Key used for signature calculation.
        /// Only allow upper- and lower-case letters and digits, with a length of 6 to 32 characters.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Signature parameter name setting;
        /// Only allow upper- and lower-case letters, digits, or underscores, with a length of 1 to 100 characters, and cannot start with a digit.
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// Signature expiration time setting;
        /// In seconds. Maximum settable value: 630720000.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// List of filename extensions for authentication/no authentication settings;
        /// If it contains the character *, it indicates all files.
        /// </summary>
        [JsonProperty("FileExtensions")]
        public string[] FileExtensions{ get; set; }

        /// <summary>
        /// whitelist: allowlist, means to authenticate all types except the FileExtensions list;
        /// blacklist: blocklist, means only applicable to authenticate the types in FileExtensions.
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// Secondary key for signature calculation;
        /// Only allow upper- and lower-case letters and digits, with a length of 6 to 32 characters.
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "FileExtensions.", this.FileExtensions);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
        }
    }
}

