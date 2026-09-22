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

    public class RestoreMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier list of media files. Maximum length: 100.
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// Accessible duration of thawed temporary media files. Must be greater than 0. Unit: day.
        /// </summary>
        [JsonProperty("RestoreDay")]
        public ulong? RestoreDay{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services on or after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether in the default application or a newly created application.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Thawing mode. If the current storage type of the media file is archive storage, the following values can be taken:
        /// <li>Speed mode: Expedited. The unfreeze task is completed in 5 minutes.</li>
        /// <li>Standard mode: Standard. The unfreeze task is completed after 5 hours.</li>
        /// <li>Batch mode: Bulk. The unfreeze task is completed after 12 hours.</li>
        /// When the storage type of a media file is DEEP_ARCHIVE, the parameter values are as follows:
        /// <li>Standard mode: Standard. The unfreeze task is completed after 24 hours.</li>
        /// <li>Batch mode: Bulk. The unfreeze task will be completed after 48 hours.</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "RestoreDay", this.RestoreDay);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
        }
    }
}

