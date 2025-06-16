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

    public class ListDocItem : AbstractModel
    {
        
        /// <summary>
        /// Document ID.
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// The new document name after renaming. This name remains until the document is published after the renaming submission.
        /// </summary>
        [JsonProperty("NewName")]
        public string NewName{ get; set; }

        /// <summary>
        /// File type.
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// COS path.
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Document status.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Document status description.
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Reason.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Whether to refer to an answer.
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// Quantity of Q&A pairs.
        /// </summary>
        [JsonProperty("QaNum")]
        public long? QaNum{ get; set; }

        /// <summary>
        /// Whether it has been deleted.
        /// </summary>
        [JsonProperty("IsDeleted")]
        public bool? IsDeleted{ get; set; }

        /// <summary>
        /// Document source.
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// Document source description.
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// Whether regeneration is allowed.
        /// </summary>
        [JsonProperty("IsAllowRestart")]
        public bool? IsAllowRestart{ get; set; }

        /// <summary>
        /// Whether the Q&A has been deleted.
        /// </summary>
        [JsonProperty("IsDeletedQa")]
        public bool? IsDeletedQa{ get; set; }

        /// <summary>
        /// Whether the Q&A is being generated.
        /// </summary>
        [JsonProperty("IsCreatingQa")]
        public bool? IsCreatingQa{ get; set; }

        /// <summary>
        /// Whether deletion is allowed.
        /// </summary>
        [JsonProperty("IsAllowDelete")]
        public bool? IsAllowDelete{ get; set; }

        /// <summary>
        /// Whether to allow operation reference switch.
        /// </summary>
        [JsonProperty("IsAllowRefer")]
        public bool? IsAllowRefer{ get; set; }

        /// <summary>
        /// Whether Q&A has been generated.
        /// </summary>
        [JsonProperty("IsCreatedQa")]
        public bool? IsCreatedQa{ get; set; }

        /// <summary>
        /// Document character count.
        /// </summary>
        [JsonProperty("DocCharSize")]
        public string DocCharSize{ get; set; }

        /// <summary>
        /// Applicable range of attribute label.
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// Attribute label.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabel[] AttrLabels{ get; set; }

        /// <summary>
        /// Whether editing is allowed.
        /// </summary>
        [JsonProperty("IsAllowEdit")]
        public bool? IsAllowEdit{ get; set; }

        /// <summary>
        /// External reference URL type, 0: system URL; 1: custom URL.
        /// When the value is 1, the WebUrl field cannot be empty; otherwise, it will not take effect.
        /// </summary>
        [JsonProperty("ReferUrlType")]
        public ulong? ReferUrlType{ get; set; }

        /// <summary>
        /// Web page URL (or custom URL) .
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

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
        /// Whether retries are allowed, 0: no, 1: yes.
        /// </summary>
        [JsonProperty("IsAllowRetry")]
        public bool? IsAllowRetry{ get; set; }

        /// <summary>
        /// 0: document comparison processing; 1: Q&A generation from document.
        /// </summary>
        [JsonProperty("Processing")]
        public long?[] Processing{ get; set; }

        /// <summary>
        /// Time when the document was created and stored into the database.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// ID of the document's category.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// User-defined ID of the document.
        /// </summary>
        [JsonProperty("CustomerKnowledgeId")]
        public string CustomerKnowledgeId{ get; set; }

        /// <summary>
        /// Attribute label of the document. 0: Do not perform external user permission verification.
        /// </summary>
        [JsonProperty("AttributeFlags")]
        public ulong?[] AttributeFlags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "NewName", this.NewName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "QaNum", this.QaNum);
            this.SetParamSimple(map, prefix + "IsDeleted", this.IsDeleted);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "IsAllowRestart", this.IsAllowRestart);
            this.SetParamSimple(map, prefix + "IsDeletedQa", this.IsDeletedQa);
            this.SetParamSimple(map, prefix + "IsCreatingQa", this.IsCreatingQa);
            this.SetParamSimple(map, prefix + "IsAllowDelete", this.IsAllowDelete);
            this.SetParamSimple(map, prefix + "IsAllowRefer", this.IsAllowRefer);
            this.SetParamSimple(map, prefix + "IsCreatedQa", this.IsCreatedQa);
            this.SetParamSimple(map, prefix + "DocCharSize", this.DocCharSize);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "IsAllowEdit", this.IsAllowEdit);
            this.SetParamSimple(map, prefix + "ReferUrlType", this.ReferUrlType);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamSimple(map, prefix + "IsAllowRetry", this.IsAllowRetry);
            this.SetParamArraySimple(map, prefix + "Processing.", this.Processing);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "CustomerKnowledgeId", this.CustomerKnowledgeId);
            this.SetParamArraySimple(map, prefix + "AttributeFlags.", this.AttributeFlags);
        }
    }
}

