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

    public class UrlSignatureAuthPolicy : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable or disable [key hotlink protection](https://intl.cloud.tencent.com/document/product/266/33986). Valid values:
        /// <li>`Enabled`: enable</li>
        /// <li>`Disabled`: disable</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The key for generating the signature of [key hotlink protection](https://intl.cloud.tencent.com/document/product/266/33986).
        /// `EncryptedKey` can contain 8-40 bytes, and cannot contain non-printable characters.
        /// </summary>
        [JsonProperty("EncryptedKey")]
        public string EncryptedKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EncryptedKey", this.EncryptedKey);
        }
    }
}

