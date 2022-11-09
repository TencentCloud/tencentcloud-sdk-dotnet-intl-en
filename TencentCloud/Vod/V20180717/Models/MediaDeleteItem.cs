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

    public class MediaDeleteItem : AbstractModel
    {
        
        /// <summary>
        /// The type of files to delete. If this parameter is left empty, it will be invalid. Valid values:
        /// <li>`OriginalFiles`: The original file. After deleting an original file, you can no longer perform operations such as transcoding or WeChat publishing on the file ID.</li>
        /// <li>`TranscodeFiles`: Transcoding outputs</li>
        /// <li>`AdaptiveDynamicStreamingFiles`: Adaptive bitrate outputs</li>
        /// <li>`WechatPublishFiles`: The file for WeChat publishing</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// ID of the template for which to delete the videos of the type specified by the `Type` parameter. For the template definition, please see [Transcoding Template](https://intl.cloud.tencent.com/document/product/266/33478?from_cn_redirect=1#.3Cspan-id-.3D-.22zm.22-.3E.3C.2Fspan.3E.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF).
        /// Default value: 0, which indicates to delete all videos of the type specified by the `Type` parameter.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
        }
    }
}

