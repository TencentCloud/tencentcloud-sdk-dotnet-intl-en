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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocSegment : AbstractModel
    {
        
        /// <summary>
        /// Fragment ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Business ID.
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// File type (markdown, word, txt).
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Document segment type (segment, table).
        /// </summary>
        [JsonProperty("SegmentType")]
        public string SegmentType{ get; set; }

        /// <summary>
        /// Title.
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Paragraph content.
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// Original paragraph.
        /// </summary>
        [JsonProperty("OrgData")]
        public string OrgData{ get; set; }

        /// <summary>
        /// Article ID.
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// Document business ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// Document URL.
        /// </summary>
        [JsonProperty("DocUrl")]
        public string DocUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamSimple(map, prefix + "OrgData", this.OrgData);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "DocUrl", this.DocUrl);
        }
    }
}

