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

    public class CreateStorageRegionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Pending storage region, which must be a supported region.</p><p>For parameter values, see <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1">supported region list</a></p>
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be set to the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

