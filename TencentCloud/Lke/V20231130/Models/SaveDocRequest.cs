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

    public class SaveDocRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File type (md|txt|docx|pdf|xlsx).
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// The cos path of the platform, consistent with the UploadPath parameter queried by the DescribeStorageCredential api.
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// ETag, short for entity tag, is an information tag that identifies the content of an object when it is created and can be used to check whether the content of the object has changed.
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// Verify the consistency of the uploaded file on the cloud and the local file by validating the crc64 encoding in the cos_hash x-cos-hash-crc64ecma header.<br> After the COS is successfully uploaded, obtain it from the response header.
        /// </summary>
        [JsonProperty("CosHash")]
        public string CosHash{ get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Applicable scope of labels: 1: all; 2: by conditional range.
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// Source (0: source file import; 1: web page import).
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// Web page (or custom link) address.
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

        /// <summary>
        /// Label reference.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabelRefer[] AttrLabels{ get; set; }

        /// <summary>
        /// External reference link type: 0: system link; 1: custom link.
        /// When the value is 1, the weburl field cannot be empty; otherwise, it will not take effect.
        /// </summary>
        [JsonProperty("ReferUrlType")]
        public ulong? ReferUrlType{ get; set; }

        /// <summary>
        /// Effective start time, unix timestamp.
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// Effective end time, unix timestamp. 0 indicates permanent validity.
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// Whether to reference a link.
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// Document operation type: 1: batch import (import Q&A pairs in batches); 2: document import (normally import a single document). The default value is 1.<br>Please note that when opt = 1, please download the Excel template from the Tencent Cloud Agent Development Platform/TCADP page.
        /// </summary>
        [JsonProperty("Opt")]
        public ulong? Opt{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "CosHash", this.CosHash);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "ReferUrlType", this.ReferUrlType);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "Opt", this.Opt);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
        }
    }
}

