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

    public class RoundPlayListItemInfo : AbstractModel
    {
        
        /// <summary>
        /// The file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// The type of the media played. Valid values:
        /// <li>`Transcode`: A transcoding output. Because a file may be bound to multiple transcoding templates, you need to specify `Definition` if the type is `Transcode`.</li>
        /// <li>`Original`: The original file.</li>
        /// The file must be in HLS format.
        /// </summary>
        [JsonProperty("AudioVideoType")]
        public string AudioVideoType{ get; set; }

        /// <summary>
        /// The transcoding template used to generate the transcoding output played. This parameter is required if `AudioVideoType` is `Transcode`.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "AudioVideoType", this.AudioVideoType);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
        }
    }
}

