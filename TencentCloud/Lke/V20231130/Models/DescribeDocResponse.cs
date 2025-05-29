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

    public class DescribeDocResponse : AbstractModel
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
        /// Document status : 1: not generated; 2: generating; 3: generation successful; 4: generation failed; 5: deleting; 6: deleted successfully; 7: under review; 8: review failed; 9: review successful; 10: pending release; 11: releasing; 12: released; 13: learning; 14: learning failed; 15: updating; 16: update failed; 17: parsing; 18: parsing failed; 19: import failed; 20: expired; 21: excessive invalid; 22: excessive invalid recovered.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Document status description.
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// Reason for generation failure.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Whether to refer in the answer.
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// Number of Q&A pairs.
        /// </summary>
        [JsonProperty("QaNum")]
        public long? QaNum{ get; set; }

        /// <summary>
        /// Whether to delete.
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
        /// Whether Q&A has been deleted.
        /// </summary>
        [JsonProperty("IsDeletedQa")]
        public bool? IsDeletedQa{ get; set; }

        /// <summary>
        /// Whether Q&A is being generated.
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
        /// Whether editing is allowed.
        /// </summary>
        [JsonProperty("IsAllowEdit")]
        public bool? IsAllowEdit{ get; set; }

        /// <summary>
        /// Applicable scope of labels 1: all, 2: by condition range.
        /// </summary>
        [JsonProperty("AttrRange")]
        public long? AttrRange{ get; set; }

        /// <summary>
        /// Label.
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabel[] AttrLabels{ get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
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
            this.SetParamSimple(map, prefix + "IsAllowEdit", this.IsAllowEdit);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

