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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainHTTPSConfig : AbstractModel
    {
        
        /// <summary>
        /// Time when the certificate expires
        /// <li>The time is in [ISO 8601 date format](https://intl.cloud.tencent.com/document/product/266/11732).</li>
        /// </summary>
        [JsonProperty("CertExpireTime")]
        public string CertExpireTime{ get; set; }

        /// <summary>
        /// Certificate ID in Tencent Cloud SSL product.
        /// </summary>
        [JsonProperty("CloudCertId")]
        public string CloudCertId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertExpireTime", this.CertExpireTime);
            this.SetParamSimple(map, prefix + "CloudCertId", this.CloudCertId);
        }
    }
}

