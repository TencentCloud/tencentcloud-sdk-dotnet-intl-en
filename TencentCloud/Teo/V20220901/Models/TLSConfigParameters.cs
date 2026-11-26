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

    public class TLSConfigParameters : AbstractModel
    {
        
        /// <summary>
        /// TLS version. At least one is required. If multiple versions are specified, they need to be consecutive version numbers. For example, if you enable TLS 1, 1.1, 1.2, and 1.3, you cannot only enable 1 and 1.2 while disabling 1.1. Valid values: <li>TLSv1: TLSv1 version</li><li>TLSv1.1: TLSv1.1 version</li><li>TLSv1.2: TLSv1.2 version</li><li>TLSv1.3: TLSv1.3 version.</li>
        /// </summary>
        [JsonProperty("Version")]
        public string[] Version{ get; set; }

        /// <summary>
        /// Cipher suite. For details, see [TLS version and cipher suite description](https://www.tencentcloud.com/document/product/1552/86545?from_cn_redirect=1). Valid values: <li>loose-v2023: loose-v2023 cipher suite;</li><li>general-v2023: general-v2023 cipher suite;</li><li>strict-v2023: strict-v2023 cipher suite.</li>
        /// </summary>
        [JsonProperty("CipherSuite")]
        public string CipherSuite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Version.", this.Version);
            this.SetParamSimple(map, prefix + "CipherSuite", this.CipherSuite);
        }
    }
}

