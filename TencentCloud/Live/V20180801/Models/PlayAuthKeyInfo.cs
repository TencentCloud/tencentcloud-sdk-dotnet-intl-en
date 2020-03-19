/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlayAuthKeyInfo : AbstractModel
    {
        
        /// <summary>
        /// Domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Whether to enable. 0: disabled; 1: enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Authentication key.
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }

        /// <summary>
        /// Validity period in seconds.
        /// </summary>
        [JsonProperty("AuthDelta")]
        public ulong? AuthDelta{ get; set; }

        /// <summary>
        /// Authentication BackKey.
        /// </summary>
        [JsonProperty("AuthBackKey")]
        public string AuthBackKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "AuthKey", this.AuthKey);
            this.SetParamSimple(map, prefix + "AuthDelta", this.AuthDelta);
            this.SetParamSimple(map, prefix + "AuthBackKey", this.AuthBackKey);
        }
    }
}

