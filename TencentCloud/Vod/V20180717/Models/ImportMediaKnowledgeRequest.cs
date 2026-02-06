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

    public class ImportMediaKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>Specifies the VOD application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// media file ID, the globally unique identifier of the file in vod, is assigned by the vod backend after successful upload. can be obtained from the [video upload completion event notification](https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) or [vod console](https://console.tencentcloud.com//vod/media).
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Specifies the task type for importing the knowledge base. valid values:.
        /// - AiAnalysis.DescriptionTask
        /// - SmartSubtitle.AsrFullTextTask
        /// </summary>
        [JsonProperty("ImportTasks")]
        public string[] ImportTasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamArraySimple(map, prefix + "ImportTasks.", this.ImportTasks);
        }
    }
}

