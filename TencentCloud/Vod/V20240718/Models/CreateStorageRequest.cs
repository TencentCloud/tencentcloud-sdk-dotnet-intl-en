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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStorageRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The ID of [VOD Professional Application](http://tencentcloud.com/document/product/266/67977).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Storage region, which must be a region supported by the system. All storage regions and the regions where storage buckets have already been enabled can be queried using the [DescribeStorageRegions](https://www.tencentcloud.com/document/product/266/46542) API.
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// The name of the storage.
        /// <li>Only lowercase English letters, numbers, hyphens "-", and their combinations are supported.</li>
        /// <li>The storage name cannot start or end with a "-".</li>
        /// <li>The maximum length of the storage name is 64 characters.</li>
        /// </summary>
        [JsonProperty("StorageName")]
        public string StorageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "StorageName", this.StorageName);
        }
    }
}

