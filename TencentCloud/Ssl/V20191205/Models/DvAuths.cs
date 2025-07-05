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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DvAuths : AbstractModel
    {
        
        /// <summary>
        /// Certificate domain name verification record key.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthKey")]
        public string DvAuthKey{ get; set; }

        /// <summary>
        /// Certificate domain name verification record value.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthValue")]
        public string DvAuthValue{ get; set; }

        /// <summary>
        /// Certificate domain name verification domain value.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthDomain")]
        public string DvAuthDomain{ get; set; }

        /// <summary>
        /// Certificate domain name verification file path, used only for file and file_proxy.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthPath")]
        public string DvAuthPath{ get; set; }

        /// <summary>
        /// Certificate domain name verification subdomain.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthSubDomain")]
        public string DvAuthSubDomain{ get; set; }

        /// <summary>
        /// Certificate domain verification type, valid values:.
        /// TXT: add txt record for dns domain verification.
        /// FILE: domain file verification.
        /// CNAME: add cname record for dns domain verification.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DvAuthVerifyType")]
        public string DvAuthVerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DvAuthKey", this.DvAuthKey);
            this.SetParamSimple(map, prefix + "DvAuthValue", this.DvAuthValue);
            this.SetParamSimple(map, prefix + "DvAuthDomain", this.DvAuthDomain);
            this.SetParamSimple(map, prefix + "DvAuthPath", this.DvAuthPath);
            this.SetParamSimple(map, prefix + "DvAuthSubDomain", this.DvAuthSubDomain);
            this.SetParamSimple(map, prefix + "DvAuthVerifyType", this.DvAuthVerifyType);
        }
    }
}

