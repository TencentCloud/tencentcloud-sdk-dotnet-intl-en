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

    public class ModifyMediaStorageClassRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier list of media files. Maximum length: 100.
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// Destination storage class. Optional values:
        /// <li> STANDARD: standard storage.</li>
        /// <li> STANDARD_IA: Infrequent storage.</li>
        /// <li> ARCHIVE: Archive storage.</li>
        /// <li> DEEP_ARCHIVE: deep archive storage.</li>
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, when accessing resources in VOD applications (whether the default application or a newly created application), this field must be set to the app ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Retrieval mode. When converting the file storage type from archive or deep archive to standard storage, you need to specify the mode of the retrieval (also known as unfreezing) operation. For details, see [Data Retrieval and Retrieval Mode](https://www.tencentcloud.com/document/product/266/56196?from_cn_redirect=1#retake).
        /// When the current storage type of a media file is archive storage, the following values are available:
        /// <li>Expedited: speed mode.</li>
        /// <li>Standard: standard mode.</li>
        /// <li>Bulk: batch mode.</li>
        /// When the current storage type of the media file is DEEP_ARCHIVE, the parameter values are as follows:
        /// <li>Standard: standard mode.</li>
        /// <li>Bulk: batch mode.</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
        }
    }
}

