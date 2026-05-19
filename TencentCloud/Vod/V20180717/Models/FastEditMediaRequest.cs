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

    public class FastEditMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Input media file information. Supports up to 100 incoming media.
        /// </summary>
        [JsonProperty("FileInfos")]
        public FastEditMediaFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// ClipMode indicates whether to include a shard when the editing time point falls in the middle of a TS segment. There are two parameter values: <li>StartInclusiveEndInclusive: When both the start time point and end time point fall in the middle of a shard, the shard will be included;</li> <li>StartInclusiveEndExclusive: When the start time point falls in the middle of a shard, the shard will be included; when the end time point falls in the middle of a shard, the shard will not be included.</li> Default value: StartInclusiveEndInclusive.
        /// </summary>
        [JsonProperty("ClipMode")]
        public string ClipMode{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "ClipMode", this.ClipMode);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

