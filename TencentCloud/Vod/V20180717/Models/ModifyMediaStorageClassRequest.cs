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

    public class ModifyMediaStorageClassRequest : AbstractModel
    {
        
        /// <summary>
        /// Media file unique identifier list, maximum length: 100.
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// The target storage class. Valid values:
        /// <li>STANDARD</li>
        /// <li>STANDARD_IA</li>
        /// <li>ARCHIVE</li>
        /// <li>DEEP_ARCHIVE</li>
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The retrieval mode. When switching files from DEEP ARCHIVE or ARCHIVE to STANDARD, you need to specify the retrieval mode. For details, see [Data retrieval and retrieval mode](https://intl.cloud.tencent.com/document/product/266/43051#data-retrieval-and-retrieval-mode.3Ca-id.3D.22retake.22.3E.3C.2Fa.3E).
        /// If the current storage class is ARCHIVE, the valid values for this parameter are as follows:
        /// <li>Expedited</li>
        /// <li>Standard</li>
        /// <li>Bulk</li>
        /// If the current storage class is DEEP ARCHIVE, the valid values for this parameter are as follows:
        /// <li>Standard</li>
        /// <li>Bulk</li>
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

